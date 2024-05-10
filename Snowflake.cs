using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_data_type_investigation
{
    /// <summary>
    /// Represents a unique identifier constructed around a timestamp, sequence value, and node ID.
    /// </summary>
    internal sealed class Snowflake
    {
        private const long Twepoch = 1620000000000; // Timestamp at which the Snowflake epoch starts (in milliseconds)

        private const int SequenceBits = 12;
        private const int WorkerIdBits = 5;
        private const int DatacenterIdBits = 5;

        private readonly object _lock = new object();

        private long _lastTimestamp = -1L;
        private long _sequence = 0L;

        public long DatacenterId { get; private set; }
        public long WorkerId { get; private set; }
        
        /// <summary>
        /// Construct the Snowflake object with unique IDs for the machine the object is instanciated on.
        /// </summary>
        /// <param name="datacenterId">
        /// A unique ID for the datacenter the mahcine is running in.
        /// </param>
        /// <param name="workerId">
        /// A unique ID for the machine the object is instanciated on.
        /// </param>
        /// <exception cref="ArgumentException"></exception>
        public Snowflake(long datacenterId, long workerId)
        {
            if (datacenterId < 0 || datacenterId >= (1 << DatacenterIdBits))
                throw new ArgumentException($"Datacenter ID must be between 0 and {(1 << DatacenterIdBits) - 1}");

            if (workerId < 0 || workerId >= (1 << WorkerIdBits))
                throw new ArgumentException($"Worker ID must be between 0 and {(1 << WorkerIdBits) - 1}");

            DatacenterId = datacenterId;
            WorkerId = workerId;
        }

        /// <summary>
        /// Function to generate a new snowflake ID.
        /// </summary>
        /// <returns>
        /// Returns a snowflake ID as a long.
        /// </returns>
        /// <exception cref="Exception"></exception>
        public long NextId()
        {
            lock (_lock)
            {
                var timestamp = GetCurrentTimestamp();

                if (timestamp < _lastTimestamp)
                    throw new Exception($"Clock moved backwards. Refusing to generate ID for {_lastTimestamp - timestamp} milliseconds");

                if (_lastTimestamp == timestamp)
                {
                    _sequence = (_sequence + 1) & ((1 << SequenceBits) - 1);
                    if (_sequence == 0)
                    {
                        timestamp = WaitNextMillis(_lastTimestamp);
                    }
                }
                else
                {
                    _sequence = 0;
                }

                _lastTimestamp = timestamp;

                var id = ((timestamp - Twepoch) << (SequenceBits + WorkerIdBits + DatacenterIdBits))
                       | (DatacenterId << (SequenceBits + WorkerIdBits))
                       | (WorkerId << SequenceBits)
                       | _sequence;

                return id;
            }
        }

        /// <summary>
        /// Function to get the current timestamp.
        /// </summary>
        /// <returns>
        /// Returns the current timestamp as a long.
        /// </returns>
        private long GetCurrentTimestamp()
        {
            return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        }

        /// <summary>
        /// Function to generate a new timestamp for the next millisecond to ensure iniqueness if 2 snowflakes are generated in the same millisecond.
        /// </summary>
        /// <param name="lastTimestamp">
        /// The original timestamp generated for snowflake creation.
        /// </param>
        /// <returns>
        /// Returns a new timestamp that is unique from any previous timestamps.
        /// </returns>
        private long WaitNextMillis(long lastTimestamp)
        {
            var timestamp = GetCurrentTimestamp();
            while (timestamp <= lastTimestamp)
            {
                timestamp = GetCurrentTimestamp();
            }
            return timestamp;
        }
    }
}

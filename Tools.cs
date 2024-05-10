using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_data_type_investigation
{
    /// <summary>
    /// Represents a static class of tool functions useful around the repo
    /// </summary>
    internal static class Tools
    {
        /// <summary>
        /// Function to generate the required datacenterID and workerID for the core Snowflake and generate the core Snowflake.
        /// </summary>
        /// <returns>
        /// Returns the core Snowflake object.
        /// </returns>
        public static Snowflake createCoreSnowflake()
        {
            Random random = new Random();
            long dataCenterID = random.Next(100, 1000);
            long workerID = random.Next(100, 1000);
            Snowflake snowflake = new Snowflake(dataCenterID, workerID);
            return snowflake;
        }

        /// <summary>
        /// Function to generate an array of players based on a given player count.
        /// </summary>
        /// <param name="playerCount">
        /// The number of players to be generated.
        /// </param>
        /// <param name="snowflake">
        /// The core snowflake object that can be used to generate snowflake IDs.
        /// </param>
        /// <returns>
        /// Returns a Player[] of the number of players equal to the entered player count.
        /// </returns>
        public static Player[] generatePlayerArray(int playerCount, Snowflake snowflake)
        {
            Player[] playerArray = new Player[playerCount];
            for (int i = 0; i < playerCount; i++)
            {
                playerArray[i] = new Player(snowflake);
            }
            return playerArray;
        }

        /// <summary>
        /// Function to generate an array of players based on a given player count.
        /// </summary>
        /// <param name="playerCount">
        /// The number of players to be generated.
        /// </param>
        /// <param name="snowflake">
        /// The core snowflake object that can be used to generate snowflake IDs.
        /// </param>
        /// <returns>
        /// Returns a Player[] of the number of players equal to the entered player count.
        /// </returns>
        public static LinkedList<Player> generatePlayerLinkedList(int playerCount, Snowflake snowflake)
        {
            LinkedList<Player> playerLinkedList = new LinkedList<Player>();
            for (int i = 0; i < playerCount; i++)
            {
                playerLinkedList.AddLast(new Player(snowflake));
            }
            return playerLinkedList;
        }
    }
}

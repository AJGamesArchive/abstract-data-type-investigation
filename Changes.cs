using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace abstract_data_type_investigation
{
    /// <summary>
    /// Represents a single change to be made to a single players heath
    /// </summary>
    internal class Changes
    {
        private long playerID;
        private int healthChange;

        /// <summary>
        /// Construct the change object.
        /// </summary>
        /// <param name="playerID">
        /// The snowflake ID of the player to update.
        /// </param>
        /// <param name="healthChange">
        /// The value to update their health by (Possitive for increase, Negative for decrease).
        /// </param>
        public Changes(long playerID, int healthChange)
        {
            this.playerID = playerID;
            this.healthChange = healthChange;
        }

        /// <returns>
        /// Returns the ID of the player to make the change to.
        /// </returns>
        public long getPlayerID()
        {
            return playerID;
        }

        /// <returns>
        /// Returns the amount to update the players health by.
        /// </returns>
        public int getHealthChange()
        {
            return healthChange;
        }

        /// <summary>
        /// .ToString() override to return the changes details as a single string.
        /// </summary>
        /// <returns>
        /// Returns a string of all the changes details.
        /// </returns>
        public override string ToString()
        {
            return $"Player ID: {playerID}\nHealth Change: {healthChange}";
        }
    }
}

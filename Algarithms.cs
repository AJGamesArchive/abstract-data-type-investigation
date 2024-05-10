using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_data_type_investigation
{
    /// <summary>
    /// Represents an algarithm used to test ADTs.
    /// </summary>
    internal static class Algarithms
    {
        /// <summary>
        /// Function to make all the given updates to the players array.
        /// </summary>
        /// <param name="players">
        /// The generated array of players.
        /// </param>
        /// <param name="changes">
        /// The generated array of changes.
        /// </param>
        public static void makeArrayChangesLoops(this Player[] players, Changes[] changes)
        {
            foreach (Changes change in changes)
            {
                foreach (Player player in players)
                {
                    if (change.getPlayerID() != player.getSnowflake()) continue;
                    player.updateHealth(change.getHealthChange());
                    break;
                }
            }
            return;
        }

        /// <summary>
        /// Function to make all the given updates to the players linked list.
        /// </summary>
        /// <param name="players">
        /// The generated linked list of players.
        /// </param>
        /// <param name="changes">
        /// The generated array of changes.
        /// </param>
        public static void makeLinkedListChangesLoops(this LinkedList<Player> players, Changes[] changes)
        {
            foreach (Changes change in changes)
            {
                foreach (Player player in players)
                {
                    if (change.getPlayerID() != player.getSnowflake()) continue;
                    player.updateHealth(change.getHealthChange());
                    break;
                }
            }
            return;
        }
    }
}

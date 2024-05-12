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

        /// <summary>
        /// Function to make all the given updates to the players array using a binary search algorithm.
        /// </summary>
        /// <param name="players">
        /// The generated array of players.
        /// </param>
        /// <param name="changes">
        /// The generated array of changes.
        /// </param>
        public static void makeArrayChangesBinary(this Player[] players, Changes[] changes)
        {
            Array.Sort(players, (p1, p2) => p1.getSnowflake().CompareTo(p2.getSnowflake()));
            for(int i = 0; i < changes.Length; i++)
            {
                int index = binarySearch(players, changes[i].getPlayerID());
                if (index >= 0)
                {
                    players[index].updateHealth(changes[i].getHealthChange());
                }
            }
            return;
        }

        /// <summary>
        /// Function to perform a binary search on a given players array to locate a spesific player.
        /// </summary>
        /// <param name="players">
        /// The generated array of players.
        /// </param>
        /// <param name="targetSnowflake">
        /// The snowflake of the player being searched for.
        /// </param>
        /// <returns>
        /// Returns the array element index of the player being searched for.
        /// </returns>
        public static int binarySearch(Player[] players, long targetSnowflake)
        {
            int left = 0;
            int right = players.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                long snowflake = players[mid].getSnowflake();

                if (snowflake == targetSnowflake)
                {
                    return mid; // Player found
                }
                else if (snowflake < targetSnowflake)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // Player not found
        }
    }
}

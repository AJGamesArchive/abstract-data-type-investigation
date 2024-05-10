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

        /// <summary>
        /// Function to generate a random selection of changes to make to the players array.
        /// </summary>
        /// <param name="changesCount">
        /// The nubmer of changes to generate.
        /// </param>
        /// <param name="healthChange">
        /// The value to change each selected players health by.
        /// </param>
        /// <param name="playersArray">
        /// The generated array of players.
        /// </param>
        /// <returns>
        /// Returns a Changes[] of all generated changes.
        /// </returns>
        public static Changes[] generateArrayChanges(int changesCount, int healthChange, Player[] playersArray)
        {
            Random random = new Random();
            Changes[] changes = new Changes[changesCount];
            for(int i = 0; i < changesCount; i++)
            {
                int playerIndex = random.Next(0, playersArray.Length);
                long playerId = playersArray[playerIndex].getSnowflake();
                changes[i] = new Changes(playerId, healthChange);
            }
            return changes;
        }

        /// <summary>
        /// Function to generate a random selection of changes to make to the players linked list.
        /// </summary>
        /// <param name="changesCount">
        /// The nubmer of changes to generate.
        /// </param>
        /// <param name="healthChange">
        /// The value to change each selected players health by.
        /// </param>
        /// <param name="playersArray">
        /// The generated linked list of players.
        /// </param>
        /// <returns>
        /// Returns a Changes[] of all generated changes.
        /// </returns>
        public static Changes[] generateLinkedListChanges(int changesCount, int healthChange, LinkedList<Player> playersLinkedList)
        {
            Random random = new Random();
            Changes[] changes = new Changes[changesCount];
            for (int i = 0; i < changesCount; i++)
            {
                int playerIndex = random.Next(0, playersLinkedList.Count);
                LinkedListNode<Player> playerNode = playersLinkedList.First;
                for (int j = 0; j < playerIndex; j++)
                {
                    playerNode = playerNode.Next;
                }

                long playerId = playerNode.Value.getSnowflake();
                changes[i] = new Changes(playerId, healthChange);
            }
            return changes;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace abstract_data_type_investigation
{
    /// <summary>
    /// Represents tests that can be done to test the speed and memory usage of ADTs
    /// </summary>
    internal static class Tests
    {
        /// <summary>
        /// TASK 1 - Initial Testing
        /// Function to perform initial tests on the program and it's classes to ensure no bugs are present.
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void initialCodeTest(Snowflake snowflake)
        {
            Console.WriteLine("Initial Code Test Started");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Player[] playersArray = Tools.generatePlayerArray(10, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(10, snowflake);

            Console.WriteLine("Outputing starting player array:");
            foreach (Player player in playersArray)
            {
                Console.WriteLine(player.ToString());
            }
            Console.WriteLine("")
            Console.WriteLine("Outputing starting player linkedlist:");
            foreach (Player player in playersLinkedList)
            {
                Console.WriteLine(player.ToString());
            }
            Console.WriteLine("")

            Changes[] playerArrayChanges = Tools.generateArrayChanges(5, 10, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(5, 10, playersLinkedList);

            stopwatch.Start();
            playersArray.makeArrayChangesLoops(playerArrayChanges);
            stopwatch.Stop();
            Console.WriteLine($"Time taken to update array: {stopwatch.Elapsed}");
            stopwatch.Reset();

            stopwatch.Start();
            playersLinkedList.makeLinkedListChangesLoops(playerLinkedListChanges);
            stopwatch.Stop();
            Console.WriteLine($"Time taken to update linked list: {stopwatch.Elapsed}");
            Console.WriteLine("")
            stopwatch.Reset();

            Console.WriteLine("Outputing ending player array:");
            foreach (Player player in playersArray)
            {
                Console.WriteLine(player.ToString());
            }
            Console.WriteLine("")
            Console.WriteLine("Outputing ending player linkedlist:");
            foreach (Player player in playersLinkedList)
            {
                Console.WriteLine(player.ToString());
            }
            Console.WriteLine("")

            Console.WriteLine("Initial Code Test Complete");
            return;
        }
    }
}

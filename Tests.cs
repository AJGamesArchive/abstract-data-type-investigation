using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime;
using System.Numerics;

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

            Player[] playersArray = Tools.generatePlayerArray(5, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(5, snowflake);

            
            Console.WriteLine("Outputing starting player array:");
            foreach (Player player in playersArray)
            {
                Console.WriteLine(player.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine("Outputing starting player linkedlist:");
            foreach (Player player in playersLinkedList)
            {
                Console.WriteLine(player.ToString());
            }
            Console.WriteLine("");
            

            Changes[] playerArrayChanges = Tools.generateArrayChanges(5, 5, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(5, 5, playersLinkedList);


            Console.WriteLine("Outputing generated changes for array:");
            foreach (Changes change in playerArrayChanges)
            {
                Console.WriteLine(change.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine("Outputing generated changes for linked list:");
            foreach (Changes change in playerLinkedListChanges)
            {
                Console.WriteLine(change.ToString());
            }
            Console.WriteLine("");


            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesLoops(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            long startMemoryLinkedList = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersLinkedList.makeLinkedListChangesLoops(playerLinkedListChanges);
            stopwatch.Stop();
            long endMemoryLinkedList = GC.GetTotalMemory(true);
            Console.WriteLine("Linked List Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryLinkedList - startMemoryLinkedList}");
            Console.WriteLine("");
            stopwatch.Reset();

            
            Console.WriteLine("Outputing ending player array:");
            foreach (Player player in playersArray)
            {
                Console.WriteLine(player.ToString());
            }
            Console.WriteLine("");
            Console.WriteLine("Outputing ending player linkedlist:");
            foreach (Player player in playersLinkedList)
            {
                Console.WriteLine(player.ToString());
            }
            Console.WriteLine("");
            

            Console.WriteLine("Initial Code Test Complete");
            return;
        }

        /// <summary>
        /// TASK 1 - Initial Testing
        /// Function to perform scaled up initial tests with a bigger data set.
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void initialCodeTestBigDataSet(Snowflake snowflake)
        {
            Console.WriteLine("Initial Code Test (Big Data Set) Started");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();



            Console.WriteLine("Test 1 - 10 Players per ADT, 10 Changes per ADT, 10 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(10, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(10, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(10, 10, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(10, 10, playersLinkedList);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesLoops(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            long startMemoryLinkedList = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersLinkedList.makeLinkedListChangesLoops(playerLinkedListChanges);
            stopwatch.Stop();
            long endMemoryLinkedList = GC.GetTotalMemory(true);
            Console.WriteLine("Linked List Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryLinkedList - startMemoryLinkedList}");
            Console.WriteLine("");
            stopwatch.Reset();



            Console.WriteLine("Test 2 - 100 Players per ADT, 50 Changes per ADT, 10 Health Change Value");
            Console.WriteLine("");

            playersArray = Tools.generatePlayerArray(100, snowflake);
            playersLinkedList = Tools.generatePlayerLinkedList(100, snowflake);

            playerArrayChanges = Tools.generateArrayChanges(50, 10, playersArray);
            playerLinkedListChanges = Tools.generateLinkedListChanges(50, 10, playersLinkedList);

            long startMemoryArrayA1 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesLoops(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArrayA1 = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArrayA1 - startMemoryArrayA1}");
            Console.WriteLine("");
            stopwatch.Reset();

            long startMemoryLinkedListL1 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersLinkedList.makeLinkedListChangesLoops(playerLinkedListChanges);
            stopwatch.Stop();
            long endMemoryLinkedListL1 = GC.GetTotalMemory(true);
            Console.WriteLine("Linked List Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryLinkedListL1 - startMemoryLinkedListL1}");
            Console.WriteLine("");
            stopwatch.Reset();



            Console.WriteLine("Test 3 - 1000 Players per ADT, 500 Changes per ADT, 5 Health Change Value");
            Console.WriteLine("");

            playersArray = Tools.generatePlayerArray(1000, snowflake);
            playersLinkedList = Tools.generatePlayerLinkedList(1000, snowflake);

            playerArrayChanges = Tools.generateArrayChanges(500, 5, playersArray);
            playerLinkedListChanges = Tools.generateLinkedListChanges(500, 5, playersLinkedList);

            long startMemoryArrayA2 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesLoops(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArrayA2 = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArrayA2 - startMemoryArrayA2}");
            Console.WriteLine("");
            stopwatch.Reset();

            long startMemoryLinkedListL2 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersLinkedList.makeLinkedListChangesLoops(playerLinkedListChanges);
            stopwatch.Stop();
            long endMemoryLinkedListL2 = GC.GetTotalMemory(true);
            Console.WriteLine("Linked List Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryLinkedListL2 - startMemoryLinkedListL2}");
            Console.WriteLine("");
            stopwatch.Reset();



            Console.WriteLine("Test 4 - 10,000 Players per ADT, 1000 Changes per ADT, 5 Health Change Value");
            Console.WriteLine("");

            playersArray = Tools.generatePlayerArray(10000, snowflake);
            playersLinkedList = Tools.generatePlayerLinkedList(10000, snowflake);

            playerArrayChanges = Tools.generateArrayChanges(1000, 5, playersArray);
            playerLinkedListChanges = Tools.generateLinkedListChanges(1000, 5, playersLinkedList);

            long startMemoryArrayA3 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesLoops(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArrayA3 = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArrayA3 - startMemoryArrayA3}");
            Console.WriteLine("");
            stopwatch.Reset();

            long startMemoryLinkedListL3 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersLinkedList.makeLinkedListChangesLoops(playerLinkedListChanges);
            stopwatch.Stop();
            long endMemoryLinkedListL3 = GC.GetTotalMemory(true);
            Console.WriteLine("Linked List Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryLinkedListL3 - startMemoryLinkedListL3}");
            Console.WriteLine("");
            stopwatch.Reset();



            Console.WriteLine("Test 5 - 100,000 Players per ADT, 50,000 Changes per ADT, 2 Health Change Value");
            Console.WriteLine("");

            playersArray = Tools.generatePlayerArray(100000, snowflake);
            playersLinkedList = Tools.generatePlayerLinkedList(100000, snowflake);

            playerArrayChanges = Tools.generateArrayChanges(50000, 2, playersArray);
            playerLinkedListChanges = Tools.generateLinkedListChanges(50000, 2, playersLinkedList);

            long startMemoryArrayA4 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesLoops(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArrayA4 = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArrayA4 - startMemoryArrayA4}");
            Console.WriteLine("");
            stopwatch.Reset();

            long startMemoryLinkedListL4 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersLinkedList.makeLinkedListChangesLoops(playerLinkedListChanges);
            stopwatch.Stop();
            long endMemoryLinkedListL4 = GC.GetTotalMemory(true);
            Console.WriteLine("Linked List Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryLinkedListL4 - startMemoryLinkedListL4}");
            Console.WriteLine("");
            stopwatch.Reset();



            Console.WriteLine("Initial Code Test (Big Data Set) Complete");
            return;
        }

        /// <summary>
        /// TASK 1 - Initial Testing
        /// Function to perform scaled up initial tests with a bigger data set.
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void initialCodeTestLargeDataSet(Snowflake snowflake)
        {
            Console.WriteLine("Initial Code Test (Large Data Set) Started");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();



            Console.WriteLine("Test 1 - 100,000 Players per ADT, 50,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(100000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(100000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(50000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(50000, 1, playersLinkedList);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesLoops(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            long startMemoryLinkedList = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersLinkedList.makeLinkedListChangesLoops(playerLinkedListChanges);
            stopwatch.Stop();
            long endMemoryLinkedList = GC.GetTotalMemory(true);
            Console.WriteLine("Linked List Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryLinkedList - startMemoryLinkedList}");
            Console.WriteLine("");
            stopwatch.Reset();



            Console.WriteLine("Test 2 - 100,000 Players per ADT, 50,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            playersArray = Tools.generatePlayerArray(100000, snowflake);
            playersLinkedList = Tools.generatePlayerLinkedList(100000, snowflake);

            playerArrayChanges = Tools.generateArrayChanges(50000, 1, playersArray);
            playerLinkedListChanges = Tools.generateLinkedListChanges(50000, 1, playersLinkedList);

            long startMemoryArrayA2 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesLoops(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArrayA2 = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArrayA2 - startMemoryArrayA2}");
            Console.WriteLine("");
            stopwatch.Reset();

            long startMemoryLinkedListL2 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersLinkedList.makeLinkedListChangesLoops(playerLinkedListChanges);
            stopwatch.Stop();
            long endMemoryLinkedListL2 = GC.GetTotalMemory(true);
            Console.WriteLine("Linked List Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryLinkedListL2 - startMemoryLinkedListL2}");
            Console.WriteLine("");
            stopwatch.Reset();



            Console.WriteLine("Test 3 - 100,000 Players per ADT, 50,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            playersArray = Tools.generatePlayerArray(100000, snowflake);
            playersLinkedList = Tools.generatePlayerLinkedList(100000, snowflake);

            playerArrayChanges = Tools.generateArrayChanges(50000, 1, playersArray);
            playerLinkedListChanges = Tools.generateLinkedListChanges(50000, 1, playersLinkedList);

            long startMemoryArrayA3 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesLoops(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArrayA3 = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArrayA3 - startMemoryArrayA3}");
            Console.WriteLine("");
            stopwatch.Reset();

            long startMemoryLinkedListL3 = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersLinkedList.makeLinkedListChangesLoops(playerLinkedListChanges);
            stopwatch.Stop();
            long endMemoryLinkedListL3 = GC.GetTotalMemory(true);
            Console.WriteLine("Linked List Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryLinkedListL3 - startMemoryLinkedListL3}");
            Console.WriteLine("");
            stopwatch.Reset();



            Console.WriteLine("Initial Code Test (Big Data Set) Complete");
            return;
        }
    }
}

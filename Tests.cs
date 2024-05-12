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



        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed health changes test on 100 players
        /// Health Changes: 100,000
        /// Players: 100
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedChangesTestOne(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 1 - 100 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(100, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(100, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(100000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed health changes test on 1,000 players
        /// Health Changes: 100,000
        /// Players: 1,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedChangesTestTwo(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 2 - 1,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(1000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(1000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(100000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed health changes test on 2,000 players
        /// Health Changes: 100,000
        /// Players: 2,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedChangesTestThree(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 3 - 2,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(2000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(2000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(100000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed health changes test on 4,000 players
        /// Health Changes: 100,000
        /// Players: 4,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedChangesTestFour(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 4 - 4,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(4000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(4000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(100000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed health changes test on 6,000 players
        /// Health Changes: 100,000
        /// Players: 6,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedChangesTestFive(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 5 - 6,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(6000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(6000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(100000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed health changes test on 8,000 players
        /// Health Changes: 100,000
        /// Players: 8,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedChangesTestSix(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 6 - 8,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(8000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(8000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(100000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed health changes test on 10,000 players
        /// Health Changes: 100,000
        /// Players: 10,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedChangesTestSeven(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 7 - 10,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(10000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(10000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(100000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }



        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed players test with 50,000 changes
        /// Health Changes: 50,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedPlayersTestOne(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 1 - 5,000 Players per ADT, 50,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(5000, snowflake);

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

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed players test with 100,000 changes
        /// Health Changes: 100,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedPlayersTestTwo(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 2 - 5,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(5000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(100000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed players test with 200,000 changes
        /// Health Changes: 200,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedPlayersTestThree(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 3 - 5,000 Players per ADT, 200,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(5000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(200000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(200000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed players test with 300,000 changes
        /// Health Changes: 300,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedPlayersTestFour(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 4 - 5,000 Players per ADT, 300,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(5000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(300000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(300000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed players test with 400,000 changes
        /// Health Changes: 400,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedPlayersTestFive(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 5 - 5,000 Players per ADT, 400,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(5000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(400000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(400000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 2 - ADT Testing...
        /// Function to perform a fixed players test with 500,000 changes
        /// Health Changes: 500,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void fixedPlayersTestSix(Snowflake snowflake)
        {
            Console.WriteLine("Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 6 - 5,000 Players per ADT, 500,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);
            LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(5000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(500000, 1, playersArray);
            Changes[] playerLinkedListChanges = Tools.generateLinkedListChanges(500000, 1, playersLinkedList);

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

            Console.WriteLine("Test Complete");
            return;
        }



        /// <summary>
        /// TASK 3 - Initial Binary Search Testing
        /// Function to perform initial tests on the binary search algorithm to ensure there are no bugs.
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryInitialCodeTest(Snowflake snowflake)
        {
            Console.WriteLine("Initial Binary Search Test Started");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Player[] playersArray = Tools.generatePlayerArray(10, snowflake);

            Console.WriteLine("Outputing starting player array:");
            foreach (Player player in playersArray)
            {
                Console.WriteLine(player.ToString());
            }
            Console.WriteLine("");

            Changes[] playerArrayChanges = Tools.generateArrayChanges(10, 10, playersArray);

            Console.WriteLine("Outputing generated changes for array:");
            foreach (Changes change in playerArrayChanges)
            {
                Console.WriteLine(change.ToString());
            }
            Console.WriteLine("");

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Outputing ending player array:");
            foreach (Player player in playersArray)
            {
                Console.WriteLine(player.ToString());
            }
            Console.WriteLine("");

            Console.WriteLine("Initial Binary Search Test Complete");
            return;
        }



        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed health changes test on 100 players
        /// Health Changes: 100,000
        /// Players: 100
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedChangesTestOne(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 1 - 100 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(100, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed health changes test on 1,000 players
        /// Health Changes: 100,000
        /// Players: 1,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedChangesTestTwo(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 2 - 1,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(1000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed health changes test on 2,000 players
        /// Health Changes: 100,000
        /// Players: 2,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedChangesTestThree(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 3 - 2,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(2000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed health changes test on 4,000 players
        /// Health Changes: 100,000
        /// Players: 4,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedChangesTestFour(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 4 - 4,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(4000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed health changes test on 6,000 players
        /// Health Changes: 100,000
        /// Players: 6,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedChangesTestFive(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 5 - 6,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(6000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed health changes test on 8,000 players
        /// Health Changes: 100,000
        /// Players: 8,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedChangesTestSix(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 6 - 8,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(8000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed health changes test on 10,000 players
        /// Health Changes: 100,000
        /// Players: 10,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedChangesTestSeven(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Health Changes Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 7 - 10,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(10000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }



        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed players test with 50,000 changes
        /// Health Changes: 50,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedPlayersTestOne(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 1 - 5,000 Players per ADT, 50,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(50000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed players test with 100,000 changes
        /// Health Changes: 100,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedPlayersTestTwo(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 2 - 5,000 Players per ADT, 100,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(100000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed players test with 200,000 changes
        /// Health Changes: 200,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedPlayersTestThree(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 3 - 5,000 Players per ADT, 200,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(200000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed players test with 300,000 changes
        /// Health Changes: 300,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedPlayersTestFour(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 4 - 5,000 Players per ADT, 300,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(300000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed players test with 400,000 changes
        /// Health Changes: 400,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedPlayersTestFive(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 5 - 5,000 Players per ADT, 400,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(400000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }

        /// <summary>
        /// TASK 3 - Binary Search Testing
        /// Function to perform a fixed players test with 500,000 changes
        /// Health Changes: 500,000
        /// Players: 5,000
        /// </summary>
        /// <param name="snowflake">
        /// The core snowflake that snowflake IDs can be generated from.
        /// </param>
        public static void binaryFixedPlayersTestSix(Snowflake snowflake)
        {
            Console.WriteLine("Binary Fixed Players Test");
            Console.WriteLine("");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Test 6 - 5,000 Players per ADT, 500,000 Changes per ADT, 1 Health Change Value");
            Console.WriteLine("");

            Player[] playersArray = Tools.generatePlayerArray(5000, snowflake);

            Changes[] playerArrayChanges = Tools.generateArrayChanges(500000, 1, playersArray);

            long startMemoryArray = GC.GetTotalMemory(true);
            stopwatch.Start();
            playersArray.makeArrayChangesBinary(playerArrayChanges);
            stopwatch.Stop();
            long endMemoryArray = GC.GetTotalMemory(true);
            Console.WriteLine("Array Test:");
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}\nMemory used: {endMemoryArray - startMemoryArray}");
            Console.WriteLine("");
            stopwatch.Reset();

            Console.WriteLine("Test Complete");
            return;
        }
    }
}

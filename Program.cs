using abstract_data_type_investigation;
/// <summary>
/// Represents the core program
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        // Generate the core snowflake object
        Snowflake snowflake = Tools.createCoreSnowflake();

        // Loop through multiple tests
        while (true)
        {
            // Simple user interface
            Console.WriteLine("Select a test: ");
            string input = Console.ReadLine();

            // Exit program
            if (input == "e") break;



            // Run the initial code test
            if (input == "i-s") Tests.initialCodeTest(snowflake);

            // Run initial code test with big data set
            if (input == "i-b") Tests.initialCodeTestBigDataSet(snowflake);

            // Run Initial code test with large data set
            if (input == "i-l") Tests.initialCodeTestLargeDataSet(snowflake);



            // Run fixed health changes test 1 - 100 players
            if (input == "h-1") Tests.fixedChangesTestOne(snowflake);

            // Run fixed health changes test 2 - 1,000 players
            if (input == "h-2") Tests.fixedChangesTestTwo(snowflake);

            // Run fixed health changes test 3 - 2,000 players
            if (input == "h-3") Tests.fixedChangesTestThree(snowflake);

            // Run fixed health changes test 4 - 4,000 players
            if (input == "h-4") Tests.fixedChangesTestFour(snowflake);

            // Run fixed health changes test 5 - 6,000 players
            if (input == "h-5") Tests.fixedChangesTestFive(snowflake);

            // Run fixed health changes test 6 - 8,000 players
            if (input == "h-6") Tests.fixedChangesTestSix(snowflake);

            // Run fixed health changes test 7 - 10,000 players
            if (input == "h-7") Tests.fixedChangesTestSeven(snowflake);



            // Run fixed players test 1 - 50,000 changes
            if (input == "p-1") Tests.fixedPlayersTestOne(snowflake);

            // Run fixed players test 2 - 100,000 changes
            if (input == "p-2") Tests.fixedPlayersTestTwo(snowflake);

            // Run fixed players test 3 - 200,000 changes
            if (input == "p-3") Tests.fixedPlayersTestThree(snowflake);

            // Run fixed players test 4 - 300,000 changes
            if (input == "p-4") Tests.fixedPlayersTestFour(snowflake);

            // Run fixed players test 5 - 400,000 changes
            if (input == "p-5") Tests.fixedPlayersTestFive(snowflake);

            // Run fixed players test 6 - 500,000 changes
            if (input == "p-6") Tests.fixedPlayersTestSix(snowflake);
        }
    }
}
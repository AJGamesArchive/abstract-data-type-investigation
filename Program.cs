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

        // Run the initial code test
        // Tests.initialCodeTest(snowflake);

        // Run initial code test with big data set
        Tests.initialCodeTestBigDataSet(snowflake);

        // Hold program at end and await key press
        Console.ReadLine();
    }
}
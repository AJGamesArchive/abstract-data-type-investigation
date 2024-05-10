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

        // Generate an array of players
        Player[] playersArray = Tools.generatePlayerArray(10, snowflake);

        // Generate a linked list of players
        LinkedList<Player> playersLinkedList = Tools.generatePlayerLinkedList(10, snowflake);

        // Generate an array of changes
        // TO IMPLEMENT
    }
}
namespace Iterator;

/**
 * A simple CLI for printing out collections
 *
 * The CLI creates a IIterableCollection, creates an iterator from it,
 * and runs the iterator while logging out each value
 */
public class Cli
{
    #region command runner

    public void Run()
    {
        Console.WriteLine("Collection Printing System");

        var command = GetNextCommand();

        while (command != null && command != "quit" && command != "exit")
        {
            RunCommand(command);
            command = GetNextCommand();
        }
    }

    private string? GetNextCommand()
    {
        Console.Write("\n> ");
        return Console.ReadLine();
    }

    private void RunCommand(string command)
    {
        try
        {
            if (command == "print-collection")
            {
                PrintCollection();
            }
            else
            {
                Console.WriteLine("unknown command: {0}", command);
                Console.WriteLine("valid commands are: " +
                                  "'print-collection', 'quit', 'exit'");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }

    #endregion

    #region commands

    public void PrintCollection()
    {
        Console.Write("collection: ");
        var collectionName = Console.ReadLine() ?? "";
        
        Console.Write("collection length: ");
        var length = ReadInt();

        var collection = CreateCollection(collectionName, length);

        var iterator = collection.CreateIterator();

        while (!iterator.IsDone())
        {
            Console.WriteLine(iterator.Current);
            iterator.MoveNext();
        }
    }

    #endregion

    #region helpers

    private IIterableCollection<int> CreateCollection(string collectionName, int length)
    {
        switch (collectionName)
        {
            case "list":
                return LinkedListGenerator.Generate(length);
            // uncomment when these are implemented
            //case "lazy-list":
            //    return LazyListGenerator.Generate(length);
            //case "fibonacci":
            //    return FibonacciGenerator.Generate(length);
            default:
                throw new Exception($"unknown collection {collectionName}");
        }
    }

    private int ReadInt()
    {
        var rawValue = Console.ReadLine();

        if (int.TryParse(rawValue, out var value))
        {
            return value;
        }
        else
        {
            throw new Exception($"{rawValue} is not a valid int");
        }
    }

    #endregion
}
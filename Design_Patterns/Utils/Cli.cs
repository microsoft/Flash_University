namespace Utils;

public abstract class CliBase
{
    public CliBase()
    {
        Commands = new()
        {
            { "help", Help }
        };
    }

    public CliBase(Dictionary<string, Action> commands)
    {
        Commands = commands;
        Commands.Add("help", Help);
    }

    public abstract string Title { get; }

    protected Dictionary<string, Action> Commands { get; }

    #region command runner

    public void Run()
    {
        Console.WriteLine(Title);

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
            if (Commands.TryGetValue(command, out var commandAction))
            {
                commandAction();
            }
            else
            {
                String.Join("', '", Commands.Keys);

                Console.WriteLine("unknown command: {0}", command);
                Help();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }

    private void Help()
    {
        Console.WriteLine($"valid commands are: '{String.Join("', '", Commands.Keys)}', 'quit', 'exit'");
    }

    #endregion
}

public static class CliUtils
{
    #region Methods for reading input

    public static int ReadInt()
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

    public static string ReadMultipleLines()
    {
        var text = "";
        var line = Console.ReadLine() ?? "";

        while (line != "")
        {
            if (text != "") text += "\n";
            text += line;

            line = Console.ReadLine() ?? "";
        }

        return text;
    }

    public static bool ReadYesNo()
    {
        var rawValue = Console.ReadLine() ?? "";
        return rawValue.Equals("y", StringComparison.OrdinalIgnoreCase);
    }

    #endregion
}

public static class CommandExtensions
{
    public static void MergeIn<TKey, TValue>(this IDictionary<TKey, TValue> target, IDictionary<TKey, TValue> source)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));
        if (target == null)
            throw new ArgumentNullException(nameof(target));

        foreach (var keyValue in source)
        {
            target.Add(keyValue.Key, keyValue.Value);
        }
    }
}

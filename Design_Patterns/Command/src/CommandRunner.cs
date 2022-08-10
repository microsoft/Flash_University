namespace Command;

/**
 * The Command runner
 *
 * This is the "Invoker" object in the Command pattern
 *
 * It reads input from the command line and executes the corresponding Command.
 * It works with any commands, since it doesn't need to know what they do.
 */
public class CommandRunner
{
    private readonly Dictionary<string, Command> _commandTable;

    public CommandRunner(Dictionary<string, Command> commandTable)
    {
        _commandTable = commandTable;
        _commandTable.Add("help", new Help(this._commandTable));
    }

    public void Run()
    {
        Console.WriteLine("(type 'help' for help, and 'quit' or 'exit' to exit)");

        var commandName = Console.ReadLine();
        while (commandName != null && commandName != "quit" && commandName != "exit")
        {
            if (_commandTable.ContainsKey(commandName))
            {
                _commandTable[commandName].Execute();
            }
            else
            {
                Console.WriteLine("unknown command: {0}", commandName);
            }

            commandName = Console.ReadLine();
        }
    }
}

/**
 * The Help command
 *
 * When invoked, prints out all of the available commands (key, name, and description)
 *
 * This command doesn't contain a receiver; it directly invokes Console methods (since they are static).
 * I could have added a Console facade object and used that as the receiver.
 */
public class Help : Command
{
    private readonly Dictionary<string, Command> _commands;

    public Help(Dictionary<string, Command> commands)
    {
        _commands = commands;
    }

    public override string Name => "Help";
    public override string Description => "displays the help message";

    public override void Execute()
    {
        Console.WriteLine("\nHere are the available commands:");
        
        foreach (var commandEntry in _commands)
        {
            Console.WriteLine("{0} - {1} ({2})", commandEntry.Key, commandEntry.Value.Name, commandEntry.Value.Description);
        }

        Console.WriteLine();
    }
}
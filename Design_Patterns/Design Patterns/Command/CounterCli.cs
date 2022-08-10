namespace Command;

/**
 * This is the main class that sets everything up and runs it.
 *
 * It instantiates a counter (the receiver), it instantiates
 * all the counter commands (with the counter object),
 * passes them to the invoker, and runs the invoker.
 */
public class CounterCli
{
    public void Run()
    {
        var counter = new Counter();

        var commandTable = new Dictionary<string, Command>
        {
            { "inc", new Increment(counter) },
            { "dec", new Decrement(counter) },
            { "reset", new SetToZero(counter) },
            { "print", new PrintValue(counter) },
        };

        Console.WriteLine("Welcome to the Counter CounterCli");

        var runner = new CommandRunner(commandTable);
        runner.Run();

        Console.WriteLine("\nfinal counter value: {0}", counter.Value);
    }
}

public class PrintValue : CounterCommand
{
    public PrintValue(Counter counter) : base(counter) { }

    public override string Name => "PrintValue";
    public override string Description => "prints the value of the counter";

    public override void Execute()
    {
        Console.WriteLine("counter: {0}", Counter.Value);
    }
}
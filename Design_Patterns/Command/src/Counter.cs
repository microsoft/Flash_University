namespace Command;

/**
 * A simple counter
 *
 * This is a "Receiver" in the Command pattern.
 *
 * It has two operations: Increment and Decrement.
 * The concrete counter commands will use these two
 * operations when executing.
 */
public class Counter
{
    public int Value { get; private set; }

    public void Increment()
    {
        Value += 1;
    }

    public void Decrement()
    {
        Value -= 1;
    }
}

/**
 * A base class for all counter commands
 *
 * This just adds a private field for the Counter receiver.
 *
 * This class is not necessary, I just added it to
 * simplify the other counter commands.
 */
public abstract class CounterCommand : Command
{
    protected readonly Counter Counter;

    protected CounterCommand(Counter counter)
    {
        Counter = counter;
    }
}

/**
 * The Increment command
 *
 * When invoked, simply increments the counter
 */
public class Increment : CounterCommand
{
    public Increment(Counter counter) : base(counter) { }

    public override string Name => "Increment";
    public override string Description => "increments the counter";

    public override void Execute()
    {
        Counter.Increment();
    }
}

/**
 * The Decrement command
 *
 * When invoked, simply decrements the counter
 */
public class Decrement : CounterCommand
{
    public Decrement(Counter counter) : base(counter) { }

    public override string Name => "Decrement";
    public override string Description => "decrements the counter";

    public override void Execute()
    {
        Counter.Decrement();
    }
}

/**
 * The SetToZero command
 *
 * When invoked, decrements (or increments) the counter until it reaches 0
 *
 * Commands can do more than just delegate to a single operation on
 * the receiver object. They can invoke multiple operations and
 * they can contain logic in the execution method too.
 */
public class SetToZero : CounterCommand
{
    public SetToZero(Counter counter) : base(counter) { }

    public override string Name => "SetToZero";
    public override string Description => "sets the counter to 0";

    public override void Execute()
    {
        while (Counter.Value != 0)
        {
            if (Counter.Value > 0) Counter.Decrement();
            else Counter.Increment();
        }
    }
}
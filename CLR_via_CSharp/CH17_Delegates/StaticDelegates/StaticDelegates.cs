// Simplified version of the example in the book.

internal sealed class StaticDelegates
{
    public static void Main()
    {
        StaticDelegateDemo();
    }

    private static void StaticDelegateDemo()
    {
        Console.WriteLine("----- Static Delegate Demo -----");
        Counter(1, 3, null);
        Counter(1, 3, FeedbackToConsole);
        Console.WriteLine();
    }

    private static void SimplifiedDelegateDemo()
    {
        Console.WriteLine("----- Static Delegate Demo -----");
        Counter(1, 3, null);
        Counter(1, 3, FeedbackToConsole);
        Console.WriteLine();
    }

    private static void Counter(int from, int to, Feedback fb)
    {
        for (var val = from; val <= to; val++) // If any callbacks are specified, call them
            if (fb != null)
                fb(val);
    }

    private static void FeedbackToConsole(int value)
    {
        Console.WriteLine("Item=" + value);
    }

    private void FeedbackToFile(int value)
    {
        var sw = new StreamWriter("Status", true);
        sw.WriteLine("Item=" + value);
        sw.Close();
    }

    // Old school delegate
    internal delegate void Feedback(int value);
}
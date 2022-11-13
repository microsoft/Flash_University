internal sealed class InstanceDelegates
{
    public static void Main()
    {
        InstanceDelegateDemo();
    }

    private static void InstanceDelegateDemo()
    {
        Console.WriteLine("----- Instance Delegate Demo -----");
        var di = new InstanceDelegates();
        Counter(1, 3, di.FeedbackToFile);
    }

    private static void Counter(int from, int to, Feedback fb)
    {
        for (var val = from; val <= to; val++)
            // If any callbacks are specified, call them
            if (fb != null)
                fb(val);
    }

    private void FeedbackToFile(int value)
    {
        Console.WriteLine("Item=" + value);
    }
    // Declare a delegate type; instances refer to a method that

    internal delegate void Feedback(int value);
}
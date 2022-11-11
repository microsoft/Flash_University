
internal sealed class InstanceDelegates
{
    // Declare a delegate type; instances refer to a method that

    internal delegate void Feedback(Int32 value);
    public static void Main()
    {
        InstanceDelegateDemo();
    }

    private static void InstanceDelegateDemo()
    {
        Console.WriteLine("----- Instance Delegate Demo -----");
        InstanceDelegates di = new InstanceDelegates();
        Counter(1, 3, new Feedback(di.FeedbackToFile));
    }

    private static void Counter(Int32 from, Int32 to, Feedback fb)
    {
        for (Int32 val = from; val <= to; val++)
        {
            // If any callbacks are specified, call them
            if (fb != null)
                fb(val);
        }
    }
    
    private void FeedbackToFile(Int32 value)
    {
        Console.WriteLine("Item=" + value);
    }
}

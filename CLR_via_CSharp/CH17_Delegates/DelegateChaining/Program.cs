internal sealed class DelegateIntro
{
    public static void Main()
    {
        ChainDelegateDemo1(new DelegateIntro());
    }


    private static void ChainDelegateDemo1(DelegateIntro di)
    {
        Console.WriteLine("----- Chain Delegate Demo 1 -----");
        Feedback fb1 = FeedbackToConsole;
        Feedback fb3 = di.FeedbackToFile;

        Feedback fbChain = null;
        fbChain = (Feedback)Delegate.Combine(fbChain, fb1);
        fbChain = (Feedback)Delegate.Combine(fbChain, fb3);
        Counter(1, 2, fbChain);

        Console.WriteLine();
        Counter(1, 2, fbChain);
    }

    private static void Counter(int from, int to, Feedback fb)
    {
        for (var val = from; val <= to; val++)
            // If any callbacks are specified, call them
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

    // Declare a delegate type; instances refer to a method that
    // takes an Int32 parameter and returns void.
    internal delegate void Feedback(int value);
}
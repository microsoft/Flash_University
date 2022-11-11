internal sealed class DelegateIntro
{
    // Declare a delegate type; instances refer to a method that
    // takes an Int32 parameter and returns void.
    internal delegate void Feedback(Int32 value);

    public static void Main()
    {

        ChainDelegateDemo1(new DelegateIntro());
    }


    private static void ChainDelegateDemo1(DelegateIntro di)
    {
        Console.WriteLine("----- Chain Delegate Demo 1 -----");
        Feedback fb1 = new Feedback(FeedbackToConsole);
        Feedback fb3 = new Feedback(di.FeedbackToFile);

        Feedback fbChain = null;
        fbChain = (Feedback)Delegate.Combine(fbChain, fb1);
        fbChain = (Feedback)Delegate.Combine(fbChain, fb3);
        Counter(1, 2, fbChain);

        Console.WriteLine();
        Counter(1, 2, fbChain);
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

    private static void FeedbackToConsole(Int32 value)
    {
        Console.WriteLine("Item=" + value);
    }

    private void FeedbackToFile(Int32 value)
    {
        StreamWriter sw = new StreamWriter("Status", true);
        sw.WriteLine("Item=" + value);
        sw.Close();
    }
}

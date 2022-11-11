

    Action<int> printActionDel = ConsolePrint;
    printActionDel(10);

    static void ConsolePrint(int i)
    {
        Console.WriteLine(i);
    }

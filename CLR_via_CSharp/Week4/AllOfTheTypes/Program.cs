//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Here for programmatic support");

public sealed class SomeType
{
    private const Int32 c_Const = 1;
    private readonly String m_SomeReadOnly = "2";
    private static Int32 s_ReadWrite = 3;

    private class ItsInHere { }
    public SomeType(Int32 x) { }
    public SomeType() { }

    static SomeType() { }

    private String InstanceMethod()
    {
        return "What is weather > 100?";
    }
    public static void Main() { }

    public Int32 SomeProp
    {
        get { return 0; }
        set { }
    }
 
    public Int32 this[String s]
    {
        get { return 0; }
        set { }
    }

    public event EventHandler SomeEvent;

}

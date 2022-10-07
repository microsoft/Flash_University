internal sealed class Atype
{
}

internal sealed class AType<T>
{
}

internal sealed class AType<T1, T2>
{
}


// 1 Constraints do not differentiate types
//internal sealed class AType<T> where T : IComparable<T>
//{
//}

// 2 Why do none of these cause any errors?
internal sealed class AnotherType
{
    private static void M()
    {
    }

    private static void M<T>()
    {
    }

    // Will this cause an error?
    //private static void M<T1, T2>()
    //{
    //}

    // will this cause an error?
    //private static void M<T>() where T : IComparable<T>
    //{
    //}

}

//What do you think the rules for overriding classes are -- kind of what you'd expect

internal class Dog
{
    public virtual void M<T1, T2>() where T1 : struct where T2 : class
    {

    }
}

internal sealed class Retriever : Dog
{
    public override void M<T1, T2>() where T1 :struct where T2 :class
    {
    }
}
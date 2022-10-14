var n = new Number();
//int
IComparable<int> val = n;
Console.WriteLine(val.CompareTo(5));
//string
IComparable<string> val2 = n;
Console.WriteLine(val2.CompareTo("5"));

public sealed class Number : IComparable<int>, IComparable<string>
{
    private readonly int M_val = 5;

    public int CompareTo(int other)
    {
        return M_val.CompareTo(other);
    }

    public int CompareTo(string? other)
    {
        if (other != null) return M_val.CompareTo(int.Parse(other));
        return -1;
    }
}
Console.WriteLine((int)CardValues.ace);
Console.WriteLine(CardValues.ace.LowAce());

internal enum CardValues
{
    ace = 11,
    two = 2,
    three = 3,
    four = 4,
    five = 5,
    six = 6,
    seven = 7,
    eight = 8,
    nine = 9,
    ten = 10,
    jack = 10
}

internal static class CardValuesExtensions
{
    public static int LowAce(this CardValues cv)
    {
        return 1;
    }
}
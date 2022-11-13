using BetterList = System.Collections.Generic.List<System.DateTime>;

var dt1 = new List<DateTime>();

var bad = new DateTimeList();

var same = typeof(List<DateTime>) == typeof(DateTimeList);
Console.WriteLine(same);

var betterButWhy = new BetterList();

same = typeof(List<DateTime>) == typeof(BetterList);
Console.WriteLine(same);

internal sealed class DateTimeList : List<DateTime>
{
}
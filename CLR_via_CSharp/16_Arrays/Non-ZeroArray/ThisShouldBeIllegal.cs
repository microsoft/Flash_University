// Straight from the book

int[] lowerBounds = { 1995, 1 };
int[] lengths = { 10, 4 };
var quarterlyRevenue = (decimal[,])
    Array.CreateInstance(typeof(decimal), lengths, lowerBounds);

var firstYear = quarterlyRevenue.GetLowerBound(0);
var lastYear = quarterlyRevenue.GetUpperBound(0);
Console.WriteLine("{0,4}  {1,9}  {2,9}  {3,9}  {4,9}", "Year", "Q1", "Q2", "Q3", "Q4");

var r = new Random();
for (var year = firstYear; year <= lastYear; year++)
{
    Console.Write(year + "  ");

    for (var quarter = quarterlyRevenue.GetLowerBound(1); quarter <= quarterlyRevenue.GetUpperBound(1); quarter++)
    {
        quarterlyRevenue[year, quarter] = r.Next(10000);

        Console.Write("{0,9:C}  ", quarterlyRevenue[year, quarter]);
    }

    Console.WriteLine();
}
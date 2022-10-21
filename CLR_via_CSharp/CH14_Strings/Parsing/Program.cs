using System.Globalization;

//simple type
try
{
    int x = int.Parse("123", NumberStyles.None, null);
    Console.WriteLine(x);
}
catch(FormatException)
{
    Console.WriteLine("Invalid format");
}


//what about something a little more complicated?

var date = DateTime.Parse("2022-10-21T12:41:29Z");
Console.WriteLine(date);
var date2 = DateTime.Parse("2022-10-21");
Console.WriteLine(date2);


//var date3 = DateTime.ParseExact("2022-10-21", "YYYY-MM-DD", CultureInfo.InvariantCulture);
//Console.WriteLine(date3);
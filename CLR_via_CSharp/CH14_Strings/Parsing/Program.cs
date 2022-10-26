using System.Globalization;

//simple type
try
{
    var x = int.Parse("123", NumberStyles.None, null);
    Console.WriteLine(x);
}
catch (FormatException)
{
    Console.WriteLine("Invalid format");
}


//what about something a little more complicated?

var date = DateTime.Parse("2022-10-21T12:41:29Z");
Console.WriteLine(date);
var date2 = DateTime.Parse("2022-10-21");
Console.WriteLine(date2);

String dateString = "18/08/2015 06:30:15.006542";
string format = "dd/MM/yyyy HH:mm:ss.ffffff";

var date3 = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
Console.WriteLine(date3);
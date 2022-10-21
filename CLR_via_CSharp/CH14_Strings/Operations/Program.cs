using System.Text;

//string s = "somestring";

//s.ToUpper();
//s.ToLower();
//s.ToUpperInvariant();
//s.ToLowerInvariant();

//what is the optimal way to do this here?
//String output = s+ s.ToUpper() + s.ToLowerInvariant();


var output2 =
    new StringBuilder().Append("1").Append("2").Append("3");

Console.WriteLine(output2);
//Console.WriteLine("How many strings exist here?");
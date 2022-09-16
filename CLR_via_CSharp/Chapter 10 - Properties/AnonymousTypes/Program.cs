//Anonymouse Types

var o1 = new {Name = "Orwell", Year = 1984};

Console.WriteLine(o1.Name + " " +o1.Year);


Console.WriteLine(o1.Name.GetType());

//Most commonly used in LINQ (something i haven't seen/touched yet)v
//What do we think the IL looks like

//Look Ma, arrays too
var humanity = new[]
{
    o1,
    new {Name = "Charles", Year = 1885},
    new {Name = "Bronte", Year = 1870},
};


//System.Tuple from MSDN

var primes = Tuple.Create(2, 3, 5, 7, 11, 13, 17, 19);
Console.WriteLine("Prime numbers less than 20: " +
                  "{0}, {1}, {2}, {3}, {4}, {5}, {6}, and {7}",
    primes.Item1, primes.Item2, primes.Item3,
    primes.Item4, primes.Item5, primes.Item6,
    primes.Item7, primes.Rest.Item1);
// The example displays the following output:
//    Prime numbers less than 20: 2, 3, 5, 7, 11, 13, 17, and 19
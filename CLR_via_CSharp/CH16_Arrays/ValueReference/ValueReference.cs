int[] fibonacci;
fibonacci = new int[10];

foreach (int i in fibonacci)
{
    Console.WriteLine(i);
}

var references = new UsefulClass[2];

//What do we expect here. 

// foreach (var i in references)
// {
//     Console.WriteLine(i.X);
// }


for (int i = 0; i < references.Length; i++)
{
    references[i] = new UsefulClass();
}

foreach (var i in references)
{
    Console.WriteLine(i.X);
}


internal class UsefulClass
{
    public int X { get; set; } 

    public UsefulClass()
    {
        X = 0;
    }
}


int[] fibonacci;
fibonacci = new int[10];

foreach (var i in fibonacci) Console.WriteLine(i);

var references = new UsefulClass[2];

//What do we expect here. 

// foreach (var i in references)
// {
//     Console.WriteLine(i.X);
// }


for (var i = 0; i < references.Length; i++) references[i] = new UsefulClass();

foreach (var i in references) Console.WriteLine(i.X);


internal class UsefulClass
{
    public UsefulClass()
    {
        X = 0;
    }

    public int X { get; set; }
}
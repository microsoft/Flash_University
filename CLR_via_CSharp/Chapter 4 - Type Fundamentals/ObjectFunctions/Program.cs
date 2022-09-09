//this is a namespace --> essentially it's shorthand for us; if the compiler can't find a function/method, it basically tried prepending all of the possible namespaces until one works
using System.Runtime.CompilerServices;

Object O = new Object();
Object R = new Object();

//publicly available methods (there are 2 protected methods, one for cloning and the other for deleting)
Console.WriteLine(O.Equals(O));
Console.WriteLine(O.Equals(R));


Horse horse = new Horse();
Horse horse2 = new Horse();

Console.WriteLine(horse.GetType());



//what do you expect here?
Console.WriteLine(horse.ToString());
Console.WriteLine(horse.GetHashCode());
Console.WriteLine(horse2.ToString());
Console.WriteLine(horse2.GetHashCode());

//How do we get this to work-- default equality vs the equality we're using here-- answer is fully explained in ch 5
Console.WriteLine(horse.Equals(horse2));


//Guess the output, this is discussed more in the next chapter
//Console.Write(horse2.Equals(horse));
class Horse
{
    /*public override string ToString()
    {
        return "not 'Horse'";
    }*/

    // public override bool Equals(object? obj)
    // {
    //     return base.ToString().Equals(obj.ToString());
    // }
}
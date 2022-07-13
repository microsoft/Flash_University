//this is a namespace --> essentially it's shorthand for us
using System.Runtime.CompilerServices;

Object O = new Object();
Object R = new Object();

//publicly available methods
Console.WriteLine(O.Equals(O));
Console.WriteLine(O.Equals(R));

Horse horse = new Horse();
Horse horse2 = new Horse();

Console.WriteLine(horse.GetType());



Console.WriteLine(horse.ToString());
Console.WriteLine(horse.GetHashCode());

//Guess the output, this is discussed more in the next chapter
//Console.Write(horse2.Equals(horse));
class Horse
{
    /*public override string ToString()
    {
        return "not 'Horse'";
    }*/

}
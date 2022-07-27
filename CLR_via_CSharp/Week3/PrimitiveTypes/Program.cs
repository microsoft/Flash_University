Console.WriteLine("Primitive Types map their values directly to FCL (Framework class libraries) types");
Console.WriteLine("In effect, this means that there are both multiple ways to get the same type and that some type errors might have slight inefficiencies");

//This is a working definition, but atm, primitives are base classes that come w/ a framework upon which the rest of the program/types are built

//Overflow and primitive operations 101

//The book example is the following:

Byte b = 100;
//here we expect the byte to have a value of 300
b = (Byte) (b+200);
Console.WriteLine("b {0}", Convert.ToString(b, 2));

//explain
Console.WriteLine("Please explain why the following is not 300");
Console.WriteLine(b);

// play around with the number here to figure out range of byte and range of sbyte, 
// b = 300;
// sbyte s = 127;


//using the same logic, what would we expect the following to be

sbyte c =100;
sbyte d = 1;
sbyte e = 127;
Console.WriteLine("c {0}", Convert.ToString(c, 2));
Console.WriteLine("d {0}", Convert.ToString(d, 2));
Console.WriteLine("e +1 {0}", Convert.ToString(e+1, 2));

c = (sbyte) (c+28);
Console.WriteLine(c);

//biggest takeaway, there are multiple ways to represent something

//How do we get around it? checks of course

// Byte f = 100;
// checked
// {
//     f += 200;
// }
// Console.Write("what is the value of f: {0}", f);

checked
{
    Byte g = 100;
    // g += 100;
    // Console.WriteLine(g);
    // g += 100;
    // Console.WriteLine(g);
}

// what type of eexception is this

// Boxing
// Examples basically verbatim from book
//int? a=null;
//Object o = a;

//Console.WriteLine($"o is null = {o}");

//a = 5;
//o = a;
//Console.WriteLine($"o is a {o.GetType()}");

//Unboxing


// Create a boxed Int32
Object o = 5;

// Unbox it into a Nullable<Int32> and into an Int32
Int32? a = (Int32?)o; // a = 5
Int32 b = (Int32)o;  // b = 5

// Create a reference initialized to null
o = null;

// “Unbox” it into a Nullable<Int32> and into an Int32
a = (Int32?)o;       // a = null
b = (Int32)o;       // NullReferenceException


Int32? x = 5;

// The line below displays "System.Int32"; 
// not "System.Nullable<Int32>"
Console.WriteLine(x.GetType());



Int32? n = 5;
Int32 result = ((IComparable<Int32>)n).CompareTo(5); // Compiles & runs OK
Console.WriteLine(result);                           // 0
result = ((IComparable)(Int32)n).CompareTo(5);       // Cumbersome
Console.WriteLine(result);                           // 0

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

object o = 5;

// Unbox it into a Nullable<Int32> and into an Int32
var a = (int?)o; // a = 5
var b = (int)o; // b = 5

// Create a reference initialized to null
o = null;

// “Unbox” it into a Nullable<Int32> and into an Int32
a = (int?)o; // a = null
b = (int)o; // NullReferenceException


int? x = 5;

// The line below displays "System.Int32"; 
// not "System.Nullable<Int32>"
Console.WriteLine(x.GetType());


int? n = 5;
var result = ((IComparable<int>)n).CompareTo(5); // Compiles & runs OK
Console.WriteLine(result); // 0
result = ((IComparable)(int)n).CompareTo(5); // Cumbersome
Console.WriteLine(result); // 0
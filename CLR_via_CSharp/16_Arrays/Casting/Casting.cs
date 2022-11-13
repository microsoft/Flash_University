// Again, directly from the book

var fs2dim = new FileStream[5, 10];

// Implicit cast to a 2-dim Object array
object[,] o2dim = fs2dim;

//Why doesn't this work?
//Stream[] s1dim = (Stream[])o2dim;

// Explicit cast to 2-dim Stream array
var s2dim = (Stream[,])o2dim;

// Explicit cast to 2-dim Type array 
//What happens here?
//try
//{
//    var t2dim = (Type[,])o2dim;
//}
//catch (InvalidCastException)
//{
//}


//Value types
var i1dim = new int[5];


//Object[] o1dim = (Object[])i1dim;

// However, Array.Copy knows how to coerce an array 
// of value types to an array of boxed references

var o1dim = new object[i1dim.Length];
Array.Copy(i1dim, o1dim, i1dim.Length);

Console.WriteLine(i1dim.GetType());
Console.WriteLine(o1dim.GetType());
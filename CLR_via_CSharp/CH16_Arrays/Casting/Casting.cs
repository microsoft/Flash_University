// Again, directly from the book

FileStream[,] fs2dim = new FileStream[5, 10];

// Implicit cast to a 2-dim Object array
Object[,] o2dim = fs2dim;

//Why doesn't this work?
//Stream[] s1dim = (Stream[]) o2dim;

// Explicit cast to 2-dim Stream array
Stream[,] s2dim = (Stream[,])o2dim;

// Explicit cast to 2-dim Type array 
//What happens here?
try
{
    Type[,] t2dim = (Type[,])o2dim;
}
catch (InvalidCastException)
{
}


//Value types
Int32[] i1dim = new Int32[5];


// Object[] o1dim = (Object[]) i1dim;

// However, Array.Copy knows how to coerce an array 
// of value types to an array of boxed references

Object[] o1dim = new Object[i1dim.Length];
Array.Copy(i1dim, o1dim, 0);



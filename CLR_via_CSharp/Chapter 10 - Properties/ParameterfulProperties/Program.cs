using System;
var stringCollection = new SampleCollection<string>();
stringCollection[0] = "Hello, World";
Console.WriteLine(stringCollection[0]);

//indexer example from msdn

class SampleCollection<T>
{
    // Declare an array to store the data elements.
    private T[] arr = new T[100];

    // Define the indexer to allow client code to use [] notation.
    public T this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
}


// The example displays the following output:
//       Hello, World.
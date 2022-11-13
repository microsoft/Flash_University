// also from the book...

const Int32 c_numElements = 10000;


    // Declare a 2-dimensional array
    Int32[,] a2Dim = new Int32[c_numElements, c_numElements];



Unsafe2DimArrayAccess(a2Dim);

static unsafe Int32 Unsafe2DimArrayAccess(Int32[,] a)
{
    Int32 sum = 0, numElements = c_numElements * c_numElements;
    fixed (Int32* pi = a)
    {
        for (Int32 x = 0; x < numElements; x++)
        {
            sum += pi[x];
        }
    }
    return sum;
}
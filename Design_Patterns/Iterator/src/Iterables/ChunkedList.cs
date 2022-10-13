namespace Iterator.Iterables;

/*
 * Exercise: make ChunkedList iterable
 */

/**
 * A list that's broken up into equal sized chunks
 */
public class ChunkedList<T>
{
    private readonly T[,] _chunks;

    public int ChunkSize { get; }
    public int Length { get; }

    public ChunkedList(int length, int chunkSize)
    {
        ChunkSize = chunkSize;
        Length = length;

        var numChunks = (length + chunkSize - 1) / chunkSize;
        _chunks = new T[numChunks, chunkSize];
    }

    public T this[int chunk, int index]
    {
        get => _chunks[chunk, index];
        set => _chunks[chunk, index] = value;
    }
}


#region generator

/**
 * A helper class used to generate a ChunkedList with random elements
 *
 * This class has nothing to do with the Iterator pattern, it's simply
 * to help generate ChunkedLists
 */
public static class ChunkedListGenerator
{
    public static ChunkedList<int> Generate(int length, int chunkSize = 3)
    {
        Random random = new Random();
        ChunkedList<int> list = new ChunkedList<int>(length, chunkSize);

        for (int i = 0; i < length; i++)
        {
            list[i / chunkSize, i % chunkSize] = random.Next(0, 10);
        }

        return list;
    }
}

#endregion
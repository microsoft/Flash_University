namespace Iterator.Iterables;

/*
 * Exercise: make FibonacciSequence iterable
 */

public class FibonacciSequence
{
    public FibonacciSequence(int length)
    {
        Length = length;
    }

    public int Length { get; }
}

#region generator

/**
 * A helper class used to generate a FibonacciSequence instance
 *
 * This class has nothing to do with the Iterator pattern, it's simply
 * to help generate a FibonacciSequence
 */
public static class FibonacciGenerator
{
    public static FibonacciSequence Generate(int length)
    {
        return new FibonacciSequence(length);
    }
}

#endregion

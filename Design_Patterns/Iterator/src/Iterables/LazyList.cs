namespace Iterator.Iterables;

/*
 * Exercise: make LazyList iterable
 */

public class LazyList<T>
{
    private readonly List<T> _elements;
    private readonly Func<int, T> _getElement;

    public int Length { get; }

    public LazyList(int length, Func<int, T> getElement)
    {
        Length = length;
        _elements = new List<T>();
        _getElement = getElement;
    }

    public T GetAtIndex(int index)
    {
        while (_elements.Count <= index)
        {
            _elements.Add(_getElement(_elements.Count));
        }

        return _elements[index];
    }
}


#region generator

/**
 * A helper class used to generate a LazyList with random elements
 *
 * This class has nothing to do with the Iterator pattern, it's simply
 * to help generate LazyLists
 */
public static class LazyListGenerator
{
    public static LazyList<int> Generate(int length)
    {
        Random random = new Random();

        return new LazyList<int>(length, (index) => random.Next(0, 10));
    }
}

#endregion

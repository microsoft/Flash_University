namespace Iterator.Iterables;

/*
 * Exercise: implement the method necessary to make the iterator work
 */

/**
 * A simple immutable LinkedList
 *
 * This is a "ConcreteAggregate"
 */
public class LinkedList<T> : IIterableCollection<T>
{
    public LinkedList(Element? head)
    {
        Head = head;
    }

    public Element? Head { get; }

    public class Element
    {
        public T Value { get; init; }
        public Element? Next { get; init; }
    }

    public IIterator<T> CreateIterator()
    {
        throw new NotImplementedException();
    }
}

/**
 * A simple forward iterator for a LinkedList
 *
 * This is a "ConcreteIterator"
 */
public class LinkedListIterator<T> : IIterator<T>
{
    public T Current => throw new NotImplementedException();

    public void MoveNext()
    {
        throw new NotImplementedException();
    }

    public bool IsDone()
    {
        throw new NotImplementedException();
    }
}

#region generator

/**
 * A helper class used to generate a LinkedList with random elements
 *
 * This class has nothing to do with the Iterator pattern, it's simply
 * to help generate LinkedLists
 */
public static class LinkedListGenerator
{
    public static LinkedList<int> Generate(int length)
    {
        Random random = new Random();

        LinkedList<int>.Element? current = null;

        for (int i = 0; i < length; i++)
        {
            current = new LinkedList<int>.Element()
            {
                Value = random.Next(0, 10),
                Next = current
            };
        }

        return new LinkedList<int>(current);
    }
}

#endregion

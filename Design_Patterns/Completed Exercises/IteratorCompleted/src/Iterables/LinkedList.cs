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
        public Element(T value)
        {
            Value = value;
        }

        public T Value { get; }
        public Element? Next { get; init; }
    }

    public IIterator<T> CreateIterator()
    {
        // both are equivalent
        return new LinkedListIterator<T>(this);
        //return new LinkedListIterator<T>(Head);
    }
}

/**
 * A simple forward iterator for a LinkedList
 *
 * This is a "ConcreteIterator"
 */
public class LinkedListIterator<TValue> : IIterator<TValue>
{
    public LinkedListIterator(LinkedList<TValue> list)
    {
        _current = list.Head;
    }

    public LinkedListIterator(LinkedList<TValue>.Element? head)
    {
        _current = head;
    }

    public TValue Current
    {
        get
        {
            if (_current == null)
            {
                throw new Exception("can't get current after iterator is done");
            }

            return _current.Value;
        }
    }

    public void MoveNext()
    {
        if (_current == null)
        {
            throw new Exception("can't move to next after iterator is done");
        }

        _current = _current.Next;
    }

    public bool IsDone()
    {
        return _current == null;
    }

    private LinkedList<TValue>.Element? _current;
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
            current = new LinkedList<int>.Element(value: random.Next(0, 10))
            {
                Next = current
            };
        }

        return new LinkedList<int>(current);
    }
}

#endregion

#region Manual Iteration vs Iterator

public class Example
{
    /*
     * Manually looping through a linked list is remarkably similar
     * to using an iterator - the iterator just abstracts away the
     * steps to iteration
     */
    public static void PrintLinkedList(LinkedList<int> list)
    {
        // print out all elements manually

        var element = list.Head;

        while (element != null)
        {
            Console.WriteLine(element.Value);
            element = element.Next;
        }

        // print out all elements using iterator
        // (iterator implementation listed in comments above each line)

        // _current = list.Head;
        var iterator = list.CreateIterator();

        // !(_current == null)
        while (!iterator.IsDone())
        {
            // _current.Value
            Console.WriteLine(iterator.Current);

            // _current = _current.Next
            iterator.MoveNext();
        }
    }
}

#endregion

﻿namespace Iterator.Iterables;

/*
 * TODO Exercise: implement the methods necessary to make the iterator work
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
        throw new NotImplementedException();
    }
}

/**
 * A simple forward iterator for a LinkedList
 *
 * This is a "ConcreteIterator"
 */
public class LinkedListIterator<TValue> : IIterator<TValue>
{
    public TValue Current => throw new NotImplementedException();

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
            current = new LinkedList<int>.Element(value: random.Next(0, 10))
            {
                Next = current
            };
        }

        return new LinkedList<int>(current);
    }
}

#endregion

#region LinkedList Example

public class Example
{
    /*
     * Quick example to show how to build a linked list
     */
    public static LinkedList<int> BuildLinkedList()
    {
        var head = new LinkedList<int>.Element(0)
        {
            Next = new LinkedList<int>.Element(1)
            {
                Next = new LinkedList<int>.Element(2)
            }
        };

        var list = new LinkedList<int>(head);

        return list;
    }

    /*
     * Quick example to show how to manually iterate through the linked list
     */
    public static void UseLinkedList(LinkedList<int> list)
    {
        var element = list.Head;

        while (element != null)
        {
            Console.WriteLine(element.Value);
            element = element.Next;
        }
    }
}

#endregion

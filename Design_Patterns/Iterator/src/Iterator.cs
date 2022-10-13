namespace Iterator;

/**
 * A simple iterator interface
 *
 * This is the "Iterator"
 *
 * It only contains the basic iterator functionality,
 * but can easily be extended (eg MoveBack, Reset)
 */
public interface IIterator<out T>
{
    T Current { get; }
    void MoveNext();
    bool IsDone();
}

/**
 * A simple iterable collection interface
 *
 * This is the "Aggregate"
 *
 * It simple provides a way to create a new iterator
 */
public interface IIterableCollection<out T>
{
    IIterator<T> CreateIterator();
}




//You can actually do everyone's favorite algorithm, linkedlist and then 'reverse it' for both
//TODO.Srikar if you have time

var alphabet = new Node<char>('a');
alphabet = new Node<char>('b', alphabet);
alphabet = new Node<char>('c', alphabet);

Console.WriteLine(alphabet);

var counting = new Node<int>(1);
counting = new Node<int>(2, counting);
counting = new Node<int>(3, counting);

Console.WriteLine(counting);

internal class Node<T>
{
    public T _data;
    public Node<T> _next;

    public Node(T data)
    {
        _data = data;
    }

    public Node(T data, Node<T> next)
    {
        _data = data;
        _next = next;
    }

    public override string ToString()
    {
        return _data + (_next != null ? _next.ToString() : string.Empty);
    }
}


//internal class Node
//{
//    protected
//}
//internal sealed class TypedNode<T> : Node
//{
//    public T _data;

//    public TypedNode(T data) : this(data, null)
//    {

//    }

//}
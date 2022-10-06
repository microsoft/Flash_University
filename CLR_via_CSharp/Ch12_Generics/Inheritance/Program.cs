//You can actually do everyone's favorite algorithm, linkedlist and then 'reverse it' for both
//TODO.Srikar if you have time

using System.Xml;

Node<char> alphabet = new Node<char>('a');
alphabet = new Node<char>('b', alphabet);
alphabet = new Node<char>('c', alphabet);

Console.WriteLine(alphabet);

Node<int> counting = new Node<int>(1);
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

    public override String ToString()
    {
        return _data.ToString() + ((_next != null) ? _next.ToString() : String.Empty);
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
using System;
using System.Collections.Generic;
using System.Linq;

// Given a binary tree, print out the tree in "plough" order. This is left to right, right to left, alternating on every row.\
// all inputs integers
class Program
{
    //Modified bfs, flag for left right
    public static void Main(string[] args)
    {
        // Tests cases
        // Single node
        Node testA = new Node(1);
        List<int> outputA = new List<int> { 1 };
        TestOutput(testA, outputA);

        Node testB = new Node(1);
        Node b = new Node(2);
        Node c = new Node(3);
        testB.left = b;
        testB.right = c;

        List<int> outputB = new List<int> { 1, 3, 2 };
        TestOutput(testB, outputB);

        Node testC = new Node(1);
        b = new Node(2);
        c = new Node(3);
        Node d = new Node(4);
        Node e = new Node(5);
        Node f = new Node(6);
        Node g = new Node(7);
        Node h = new Node(8);
        Node i = new Node(9);
        Node j = new Node(10);
        Node k = new Node(11);
        testC.left = b;
        testC.right = c;
        b.left = d;
        b.right = e;
        c.left = f;
        c.right = g;
        d.left = h;
        h.left = j;
        h.right = k;
        g.left = i;
        var outputC = new List<int> { 1, 3, 2, 4, 5, 6, 7, 9, 8, 10, 11 };

        TestOutput(testC, outputC);

    }

    static List<int> ploughOrderTraversal(Node root)
    {
        List<int> output = new List<int> { };
        if (root == null)
            return output;

        bool leftToRight = false;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(root);
        output.Add(root.value);
        Node cur = null;

        // 1
        //3 2
        // array 2
        List<Node> temp = new List<Node>();
        while (q.Count > 0)
        {
            int size = q.Count;

            for (int i = 0; i < size; i++)
            {
                cur = q.Dequeue();

                if (cur.left != null)
                {
                    temp.Add(cur.left);
                    q.Enqueue(cur.left);
                }
                if (cur.right != null)
                {
                    temp.Add(cur.right);
                    q.Enqueue(cur.right);
                }
            }
            if (!leftToRight)
            {
                temp.Reverse();
            }
            while (temp.Count > 0)
            {
                output.Add(temp.First().value);
                temp.RemoveAt(0);
            }
            leftToRight = !leftToRight;
        }

        return output;
    }

    static void TestOutput(Node root, List<int> expected)
    {
        if (ploughOrderTraversal(root).SequenceEqual(expected))
        {
            Console.WriteLine("pass");
        }
        else
        {
            Console.WriteLine($@"expected: {String.Join(",", expected.ToArray())}, actual: {String.Join(",", ploughOrderTraversal(root).ToArray())}");
        }
    }
}


public class Node
{
    public int value;
    public Node left;
    public Node right;
    public Node(int val)
    {
        value = val;
    }
}


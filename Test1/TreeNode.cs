using System;
using System.Collections;
using System.Collections.Generic;

public class Node
{
    public int Val;
    public List<Node> children;
    public Node()
    {

    }
    public Node(int val)
    {
        this.Val = val;
        this.children = new List<Node>();
    }

}



public class GenericTree

{
    
    public Node NewNode(int val)
    {
        Node temp = new Node();
        temp.Val = val;
        temp.children = new List<Node>();
        return temp;
    }

    public void AddChild(Node parent, Node child)
    {
        parent.children.Add(child);
    }

    public IList<int> MostLeftRightSide(Node root)
    {
        if (root == null) return new List<int>();

        List<int> left = new List<int>();
        List<int> right = new List<int>();

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        int currentLevel = 0;

        while (queue.Count > 0)
        {
            int level = queue.Count;

            for (int i = 0; i < level; i++)
            {
                Node node = queue.Dequeue();

                if (i == 0)
                {
                    left.Add(node.Val);
                }

                if (i == level - 1 && i != 0)
                {
                    right.Add(node.Val);
                }

                if (node.children != null)
                {
                    foreach (Node child in node.children)
                    {
                        queue.Enqueue(child);
                    }
                }
            }

            currentLevel++;

        }

        if ( Math.Abs(left.Count - 1 - right.Count) > 0)
        {
            right.Add(left[currentLevel - 1]);
        }

        left.Reverse();
        left.AddRange(right);

        return left;
    }

}



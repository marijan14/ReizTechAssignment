using System;
using System.Collections.Generic;

namespace _3___Tree_Depth
{
    class Program
    {
        public class Node
        {
            public char key;
            public List<Node> child;
        };

        static Node newNode(int key)
        {
            Node temp = new Node();
            temp.key = (char)key;
            temp.child = new List<Node>();
            return temp;
        }

        static int depthOfTree(Node ptr)
        {
            if (ptr == null)
                return 0;

            int maxdepth = 0;
            foreach (Node it in ptr.child)
                maxdepth = Math.Max(maxdepth, depthOfTree(it));

            return maxdepth + 1;
        }

        static void Main(string[] args)
        {
            Node root = newNode('A');

            (root.child).Add(newNode('B'));
            (root.child).Add(newNode('C'));

            (root.child[0].child).Add(newNode('D'));
            (root.child[1].child).Add(newNode('E'));
            (root.child[1].child).Add(newNode('F'));
            (root.child[1].child).Add(newNode('G'));

            (root.child[1].child[1].child).Add(newNode('H'));
            (root.child[1].child[2].child).Add(newNode('I'));
            (root.child[1].child[2].child).Add(newNode('J'));

            (root.child[1].child[2].child[1].child).Add(newNode('K'));

            Console.WriteLine(depthOfTree(root));
        }
    }
}

using System;

namespace _2___Hierarchical_Structure
{
    class Program
    {
        class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        Node root;

        Program()
        {
            root = null;
        }

        int MinValue(Node root)
        {
            int minValue = root.key;
            while (root.left != null)
            {
                minValue = root.left.key;
                root = root.left;
            }
            return minValue;
        }

        Node DeleteRec(Node root, int key)
        {
            if (root == null)
                return root;

            if (key < root.key)
                root.left = DeleteRec(root.left, key);
            else if (key > root.key)
                root.right = DeleteRec(root.right, key);
            else
            {
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;
                root.key = MinValue(root.right);

                root.right = DeleteRec(root.right, root.key);
            }
            return root;
        }

        void DeleteKey(int key) {
            root = DeleteRec(root, key);
        }

        Node InsertRec(Node root, int key)
        {
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            if (key < root.key)
                root.left = InsertRec(root.left, key);
            else if (key > root.key)
                root.right = InsertRec(root.right, key);

            return root;
        }

        void Insert(int key) {
            root = InsertRec(root, key);
        }

        void InorderRec(Node root)
        {
            if (root != null)
            {
                InorderRec(root.left);
                Console.Write(root.key + " ");
                InorderRec(root.right);
            }
        }

        void Inorder() {
            InorderRec(root);
        }

        public static void Main(string[] args)
        {
            Program tree = new Program();

            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(4);
            tree.Insert(7);
            tree.Insert(6);
            tree.Insert(8);

            tree.Inorder();
        }
    }
}

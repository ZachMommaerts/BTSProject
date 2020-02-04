using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //Member Variables (HAS A)
        public Node root;

        //Constructor
        public BinarySearchTree()
        {

        }

        //Member Methods (CAN DO)
        public void Add(int value)
        {
            Node node = new Node(value);
            Node current = new Node(value);
            if(root == null)
            {
                root = node;
            }
            else
            {
                current = root;
                while (true)
                {
                    if (node.value > current.value)
                    {
                        if (current.rightChild == null)
                        {
                            current.rightChild = node;
                            break;
                        }
                        else
                        {
                            current = current.rightChild;
                        }
                    }
                    if (node.value < current.value)
                    {
                        if (current.leftChild == null)
                        {
                            current.leftChild = node;
                            break;
                        }
                        else
                        {
                            current = current.leftChild;
                        }
                    }
                }
            }
        }
        public bool Search(int value)
        {
            bool found = false;
            Node node = new Node(value);
            Node current = new Node(value);
            if (root == null)
            {
                root = node;
            }
            else
            {
                current = root;
                while (true)
                {
                    if (node.value > current.value)
                    {
                        if (current.rightChild == null)
                        {
                            Console.WriteLine($"{node} not found");
                            break;
                        }
                        if (current.rightChild == node)
                        {
                            Console.WriteLine($"Found {node}");
                            found = true;
                            break;
                        }
                        else
                        {
                            current = current.rightChild;
                        }
                    }
                    if (node.value < current.value)
                    {
                        if (current.leftChild == null)
                        {
                            Console.WriteLine($"{node} not found");
                            break;
                        }
                        if (current.leftChild == node)
                        {
                            Console.WriteLine($"Found {node}");
                            found = true;
                            break;
                        }
                        else
                        {
                            current = current.leftChild;
                        }
                    }
                }
            }
            return found;
        }
    }
}

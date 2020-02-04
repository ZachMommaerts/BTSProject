using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bts = new BinarySearchTree();
            Node node = new Node(100);
            Node node2 = new Node(107);
            Node node3 = new Node(104);
            Node node4 = new Node(78);
            Node node5 = new Node(84);
            Node node6 = new Node(51);
            Node node7 = new Node(121);
            bts.Add(node.value);
            bts.Add(node2.value);
            bts.Add(node3.value);
            bts.Add(node4.value);
            bts.Add(node5.value);
            bts.Add(node6.value);
            bts.Add(node7.value);
            Console.ReadLine();
        }
    }
}

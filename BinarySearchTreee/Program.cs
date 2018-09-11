using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreee
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree myTree = new BinarySearchTree();
            myTree.Add(50);
            myTree.Add(40);
            myTree.Add(700);
            myTree.Add(-10);
            myTree.Add(20);
            myTree.Add(70);
            myTree.Add(49);
            myTree.Add(80);
            myTree.Add(505);
            myTree.Add(124);
            myTree.Add(12);
            myTree.Add(74);
            myTree.Search(12);
            Console.ReadLine();
        }
    }
}

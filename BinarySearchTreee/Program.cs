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
            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(2);
            tree.Add(15);
            tree.Add(5);
            tree.Add(18);
            tree.Add(12);
            tree.Add(8);
            Console.ReadLine();
        }
    }
}

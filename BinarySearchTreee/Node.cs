using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreee
{
    public class Node
    {

        public Node left;
        public Node right;
        public int data;
        
        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
        
    }
}

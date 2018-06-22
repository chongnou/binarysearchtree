using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreee
{
    public class BinaryTree
    {

        public Node root;
        
        public BinaryTree(int data)
        {
            root = null;
            root = new Node(data);
        }

        public void Add(int data)
        {

            if (root == null)
            {
                Node NewNode = new Node(data);
                root = NewNode;
                return;
            }
            Node currentnode = root;
            bool added = false;
            do
            {
                //go left if less
                if (data < currentnode.data)
                {
                    if (currentnode.left == null)
                    {
                        // Add new item
                        Node NewNode = new Node(data);
                        currentnode.left = NewNode;
                        added = true;
                    }
                    else
                    {
                        currentnode = currentnode.left;
                    }
                }
                //go right if greater
                if (data >= currentnode.data)
                {
                    if (currentnode.right == null)
                    {
                        // Add new item
                        Node NewNode = new Node(data);
                        currentnode.right = NewNode;
                        added = true;
                    }
                    else
                    {
                        currentnode = currentnode.right;
                    }
                }
            } while (!added);
        }

        public void Search()
        {

        }
    }
}

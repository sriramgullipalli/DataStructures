using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_traversal
{
   public class node
    {
       public int data;
       public node right,left;
        public node(int item)
        {
            data = item;
            left = right = null;
        }
    }
    public class BinaryTree
    {
        public node root;
        public BinaryTree()
        {
            root = null;
        }
        public void inorder(node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                inorder(node.left);
                Console.Write(node.data + " ");
                inorder(node.right);
            }
        }

        public void preorder(node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                Console.Write(node.data + " ");
                preorder(node.left);
                preorder(node.right);
            }
        }
        public void postorder(node node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                postorder(node.left);
                postorder(node.right);
                Console.Write(node.data + " ");
            }
        }


        void preorder() { preorder(root); }
        void inorder() { inorder(root); }
        void postorder() { postorder(root); }

        public static void Main(String[] args)
        {
            BinaryTree b = new BinaryTree();
            b.root = new node(1);
            b.root.left = new node(2);
            b.root.right = new node(3);
            b.root.left.right = new node(5);
            b.root.left.left = new node(4);
            b.root.right.left = new node(6);
            b.root.right.right = new node(7);
            Console.WriteLine("In order ");
            b.inorder();
            Console.WriteLine(" ");
            Console.WriteLine( "Pre Order ");
            b.preorder();
            Console.WriteLine(" ");
            Console.WriteLine("Post Order ");
            b.postorder();
        }
    }
}


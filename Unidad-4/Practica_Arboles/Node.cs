using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Arboles
{
   public class Node
    {
        private string _strData;
        public Node Left { get; set; }
        public Node Right { get; set; }

        public string StrData
        {
            get => _strData;
            set => _strData = value;
        }

        public Node(string data)
        {
            _strData = data;
            Left = null;
            Right = null;
        }

        // Preorder: root, left, right
        public static void PreOrder(Node root)
        {
            if (root == null) return;
            Console.Write(root._strData + " ");
            PreOrder(root.Left);
            PreOrder(root.Right);
        }

        // Inorder: left, root, right
        public static void InOrder(Node root)
        {
            if (root == null) return;
            InOrder(root.Left);
            Console.Write(root._strData + " ");
            InOrder(root.Right);
        }

        // Postorder: left, right, root
        public static void PostOrder(Node root)
        {
            if (root == null) return;
            PostOrder(root.Left);
            PostOrder(root.Right);
            Console.Write(root._strData + " ");
        }

        // Activity 3: height of the tree (leaf => height 1)
        // Mirrors the Python logic you provided:
        // if node is null => 0; else 1 + max(height(left), height(right))
        public static int Height(Node node)
        {
            if (node == null)
                return 0;
            int leftHeight = Height(node.Left);
            int rightHeight = Height(node.Right);
            return 1 + Math.Max(leftHeight, rightHeight);
        }
    }
}

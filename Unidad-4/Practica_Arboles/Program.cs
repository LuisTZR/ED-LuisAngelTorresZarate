using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Activity 1: Build and print general tree (folders)
            
            Console.WriteLine("Activity 1: General Tree (Folder Structure)");
            TreeNode root = new TreeNode("Root");

            TreeNode documents = new TreeNode("Documents");
            documents.AddChild(new TreeNode("School"));
            documents.AddChild(new TreeNode("Work"));

            TreeNode images = new TreeNode("Images");
            images.AddChild(new TreeNode("Vacations"));
            images.AddChild(new TreeNode("Family"));

            root.AddChild(documents);
            root.AddChild(images);

            root.PrintTree();

            Console.WriteLine(); 

            // Activity 2: Binary tree construction (A-F) and traversals
           
            Console.WriteLine("Activity 2: Binary Tree Traversals");

            Node A = new Node("A");
            Node B = new Node("B");
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E");
            Node F = new Node("F");

            A.Left = B;
            A.Right = C;
            B.Left = D;
            B.Right = E;
            C.Right = F;

            // Print traversals
            Console.Write("PreOrder: ");
            Node.PreOrder(A);
            Console.WriteLine();

            Console.Write("InOrder: ");
            Node.InOrder(A);
            Console.WriteLine();

            Console.Write("PostOrder: ");
            Node.PostOrder(A);
            Console.WriteLine();

            Console.WriteLine(); 

            // Activity 3: Height of the binary tree

            Console.WriteLine("Activity 3: Binary Tree Height ");
            int height = Node.Height(A);
            Console.WriteLine($"Height of the binary tree (root A): {height}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
        }
    }
}

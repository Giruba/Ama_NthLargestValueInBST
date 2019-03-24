using System;

namespace Ama_NthLargestInBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nth Largest value in a BST!");
            Console.WriteLine("---------------------------");

            BinarySearchTree binarySearchTree = ConstructTreeFromInput();
            Console.WriteLine();
            Console.WriteLine("The inorder traversal is as follows");
            binarySearchTree.PrintInorderTraversal(binarySearchTree.GetBinarySearchTreeRoot());
            Console.WriteLine();

            Console.WriteLine("Enter how manyeth largest value that you would" +
                    "like to find");
            try
            {
                int nthValue = int.Parse(Console.ReadLine());
                binarySearchTree.PrintNthLargestValue(binarySearchTree.GetBinarySearchTreeRoot(),
                    nthValue);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }

        private static BinarySearchTree ConstructTreeFromInput() {
            BinarySearchTree binarySearchTree = null;

            Console.WriteLine("Enter the number of elements in BST");
            try
            {
                int noElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                binarySearchTree = new BinarySearchTree();
                BinarySearchTreeNode binarySearchTreeNode = null;
                for (int i = 0; i < noElements; i++)
                {
                    binarySearchTreeNode = binarySearchTree.Insert(binarySearchTreeNode, int.Parse(elements[i]));
                }
                binarySearchTree.SetBinarySearchTreeRoot(binarySearchTreeNode);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return binarySearchTree;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ama_NthLargestInBST
{
    class BinarySearchTree
    {
        BinarySearchTreeNode root;

        public BinarySearchTree() { }

        public BinarySearchTree(BinarySearchTreeNode binarySearchTreeNode) {
            root = binarySearchTreeNode;
        }

        public void SetBinarySearchTreeRoot(BinarySearchTreeNode root) {
            this.root = root;
        }

        public BinarySearchTreeNode GetBinarySearchTreeRoot() {
            return root;
        }

        public BinarySearchTreeNode Insert(BinarySearchTreeNode root, int data) {
            if (root == null) {
                root = new BinarySearchTreeNode(data);
                return root;
            }

            if (data < root.GetBinarySearchNodeData())
            {
                root.SetBinarySearchNodeLeft(Insert(root.GetBinarySearchTreeNodeLeft(), data));
            }
            else {
                root.SetBinarySearchNodeRight(Insert(root.GetBinarySearchTreeNodeRight(), data));
            }

            return root;
        }

        public void PrintInorderTraversal(BinarySearchTreeNode root) {
            if (root == null) {
                return;
            }
            PrintInorderTraversal(root.GetBinarySearchTreeNodeLeft());
            Console.Write(root.GetBinarySearchNodeData()+"->");
            PrintInorderTraversal(root.GetBinarySearchTreeNodeRight());
        }

        public void PrintNthLargestValue(BinarySearchTreeNode root, int NValue) {
            if (root == null) {
                Console.WriteLine("Tree is empty!") ;
            }
            if (NValue == 0) {
                Console.WriteLine("Given N value is zero!");
            }
            _PrintNthLargestValue(root, 0, NValue);
        }

        private void _PrintNthLargestValue(BinarySearchTreeNode root, int temp, int N) {
            if (root == null || (temp > N)) {
                return;
            }
                              
            _PrintNthLargestValue(root.GetBinarySearchTreeNodeRight(), temp,  N );

            temp++;

            if (temp == N) {
                Console.WriteLine("The  "+ N +
                    " rd/(th)largest value is "+root.GetBinarySearchNodeData());
                return;
            }

            
            _PrintNthLargestValue(root.GetBinarySearchTreeNodeLeft(), temp, N);
        }
    }
}

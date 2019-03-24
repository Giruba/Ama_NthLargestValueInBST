using System;
using System.Collections.Generic;
using System.Text;

namespace Ama_NthLargestInBST
{
    class BinarySearchTreeNode
    {
        int data;
        BinarySearchTreeNode left;
        BinarySearchTreeNode right;


        public BinarySearchTreeNode() { }

        public BinarySearchTreeNode(int data) {
            this.data = data;
        }

        public void SetBinarySearchNodeData(int data) {
            this.data = data;
        }

        public void SetBinarySearchNodeLeft(BinarySearchTreeNode left) {
            this.left = left;
        }

        public void SetBinarySearchNodeRight(BinarySearchTreeNode right) {
            this.right = right;
        }

        public int GetBinarySearchNodeData() {
            return data;
        }

        public BinarySearchTreeNode GetBinarySearchTreeNodeLeft() {
            return left;
        }

        public BinarySearchTreeNode GetBinarySearchTreeNodeRight() {
            return right;
        }

    }
}

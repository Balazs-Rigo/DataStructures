using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.FundamentalsPDF
{
    class BinaryTree<T>
    {
        public T Value { get; set; }

        public BinaryTree<T> LeftChild { get; private set; }
        public BinaryTree<T> RightChild { get; private set; }

        public BinaryTree(T value, BinaryTree<T> leftChild, BinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public BinaryTree(T value) : this(value, null, null)
        {
        }

        public void PrintInOrder()
        {
            // 1. Visit the left child
            if (this.LeftChild != null)
            {
                this.LeftChild.PrintInOrder();
            }

            // 2. Visit the root of this sub-tree
            Console.WriteLine(this.Value + " ");

            // 3. Visit the right child
            if (this.RightChild != null)
            {
                this.RightChild.PrintInOrder();
            }
        }
    }
}

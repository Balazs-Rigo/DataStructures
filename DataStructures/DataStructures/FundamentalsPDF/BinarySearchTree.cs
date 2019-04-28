using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.FundamentalsPDF
{/*
    class BinarySearchTree<T> where T: IComparable<T>
    {

        
        #region Binary Search Tree Node Implementation
        /// <summary>
        /// Represents a binary tree node
        /// </summary>
        /// <typeparam name="T">The type of the nodes</typeparam>
        internal class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
        {
            internal T value;

            internal BinaryTreeNode<T> parent;
            internal BinaryTreeNode<T> leftChild;
            internal BinaryTreeNode<T> rightChild;

            public BinaryTreeNode(T value)
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Cannot insert null value!");
                }

                this.value = value;
                this.parent = null;
                this.leftChild = null;
                this.rightChild = null;
            }

            public override string ToString()
            {
                return this.value.ToString();
            }

            public override int GetHashCode()
            {
                return this.value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                BinaryTreeNode<T> other = (BinaryTreeNode<T>)obj;
                return this.CompareTo(other) == 0;
            }
        }
        #endregion
        
        private BinaryTreeNode<T> root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(T value)
        {
            this.root = Insert(value, null, root);
        }

        /// <summary>
        /// Inserts node in the binary search tree by given value
        /// </summary>
        /// <param name="value">the new value</param>
        /// <param name="parentNode">the parent of the new node</param>
        /// <param name="node">current node</param>
        /// <returns>the inserted node</returns>
        private BinaryTreeNode<T> Insert(T value, 
            BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)        
        {
            int compareTo = 0;

            if (node == null)
            {
                node = new BinaryTreeNode<T>(value);
                node.parent = parentNode;
            }
            else
            {
                compareTo = value.CompareTo(node.value);
            }
            if (compareTo < 0)
            {
                node.leftChild =
                Insert(value, node, node.leftChild);
            }
            else if (compareTo > 0)
            {
                node.rightChild =
                Insert(value, node, node.rightChild);
            }
            return node;
        }

        private BinaryTreeNode<T> Find(T value)
        {
            BinaryTreeNode<T> node = this.root;
            while (node != null)
            {
                int compareTo = value.CompareTo(node.value);
                if (compareTo<0)
                {
                    node = node.leftChild;
                }
                else if (compareTo > 0)
                {
                    node = node.rightChild;
                }
                else
                {
                    break;
                }
            }
            return node;
        }

        public bool Contains(T value)
        {
            bool found = this.Find(value) != null;
            return found;
        }

        public void Remove(T value)
        {
            BinaryTreeNode<T> nodeToDelete = Find(value);
            if (nodeToDelete != null)
            {
                Remove(nodeToDelete);
            }
        }

        private void Remove(BinaryTreeNode<T> node)
        {
            // Case 3: If the node has two children.
            // Note that if we get here at the end
            // the node will be with at most one child
            if (node.leftChild != null  && node.rightChild!= null)
            {
                BinaryTreeNode<T> replacement = node.rightChild;
                while (replacement.leftChild != null)
                {
                    replacement = replacement.leftChild;
                }

                node.value = replacement.value;
                node = replacement;
            }

            // Case 1 and 2: If the node has at most one child
            BinaryTreeNode<T> theChild = node.leftChild != null ? 
                node.leftChild : node.rightChild;
        }

    }*/
}

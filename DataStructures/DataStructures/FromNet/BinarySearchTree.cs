using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.FromNet
{
    class BinarySearchTree<T> where T : IComparable
    {
        public BinNode<T> root { get; set; }

        public void Insert(T data, BinNode<T> node)
        {
            if (data.CompareTo(node.data) > 0)
            {
                if (node.right == null)
                {
                    node.right = new BinNode<T>(data);
                    return;
                }
                Insert(data, node.right);
                Console.WriteLine("right");
            }
            else if (data.CompareTo(node.data) < 0)
            {
                if (node.left == null)
                {
                    node.left = new BinNode<T>(data);
                    return;
                }
                Insert(data,node.left);
                Console.WriteLine("left");
            }
        }

        public void Insert(T data)
        {
            if (root == null)
            {
                root = new BinNode<T>(data);
            }
            BinNode<T> current = root;

            while (current != null)
            {
                if (data.CompareTo(current.data) > 0)
                {
                    if (current.right != null)
                    {
                        current = current.right;
                        continue;
                    }
                    current.right = new BinNode<T>(data);
                }

                else if (data.CompareTo(current.data) < 0)
                {
                    if (current.left != null)
                    {
                        current = current.left;
                        continue;
                    }
                    current.left = new BinNode<T>(data);
                }

                else
                {
                    return;
                }
            }
        }
        //insert all elements from an array
        public void InsertFromArray(T[] array)
        {
            foreach (T t in array)
            {
                this.Insert(t);
            }
        }

        //get the last level in the bst instance
        public int GetLevel(BinNode<T> node, int current = 1)
        {
            int right = 0;
            int left = 0;

            if (node.right != null)
            {
                right = GetLevel(node.right, current + 1);
            }

            if (node.left != null)
            {
                left = GetLevel(node.right, current + 1);
            }

            if (right == 0 && left == 0) return current; //this is readable in my opinion but according to best practices (microsoft), only one operation per line is good, so should this be changed or is it okay

            else
            {
                return right > left ? right : left; //is this acceptable?
            }

        }

        //get a queue of all the values in a given level
        public void GetOnLevel(BinNode<T> node, int curLevel, int trgLevel, Queue<T> result)
        {
            if (curLevel == trgLevel)
            {
                result.Enqueue(node.data);
            }
            else
            {
                if (node.left != null)
                {
                    GetOnLevel(node.left, curLevel + 1, trgLevel, result);
                }

                if (node.right != null)
                {
                    GetOnLevel(node.right, curLevel + 1, trgLevel, result);
                }
            }
        }
        //returns the node that holds data equivalent to T data
        public BinNode<T> FindByValue(T data, BinNode<T> node)
        {
            if (node == null) return null;

            if (data.Equals(node.data))
            {
                return node;
            }

            if (data.CompareTo(node.data) > 0)
            {
                return FindByValue(data, node.right);
            }
            else if (data.CompareTo(node.data) < 0)
            {
                return FindByValue(data, node.left);
            }

            else return null;
        }
    }
}



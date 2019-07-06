using DataStructures.FromNet;
using DataStructures.FundamentalsPDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Fundamental Binary Tree
            /*
            BinaryTree<int> binaryTree =
new BinaryTree<int>(14,
new BinaryTree<int>(19,
new BinaryTree<int>(23),
new BinaryTree<int>(6,
new BinaryTree<int>(10),
new BinaryTree<int>(21))),
new BinaryTree<int>(15,
new BinaryTree<int>(3),
null));
            // Traverse and print the tree in in-order manner
            binaryTree.PrintInOrder();
            Console.WriteLine();

            // Console output:
            // 23 19 10 6 21 14 3 15
            */
            #endregion

            #region binary search tree from net
            /*
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
           
            bst.Insert(1);
            bst.Insert(3);
            bst.Insert(5);
            bst.Insert(2);
            bst.Insert(21);
            bst.Insert(4, bst.root);
            System.Console.WriteLine(bst.FindByValue(4, bst.root).data);
            */
            #endregion


        }
    }
}

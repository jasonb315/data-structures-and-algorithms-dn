using BinaryTree.Classes;
using System;


namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<object> tree = new BinaryTree<object>();

            BTNode<object> node1 = new BTNode<object>(10);
            BTNode<object> node2 = new BTNode<object>(2);
            BTNode<object> node3 = new BTNode<object>(3);
            BTNode<object> node4 = new BTNode<object>(4);
            BTNode<object> node5 = new BTNode<object>(5);
            BTNode<object> node6 = new BTNode<object>(6);
            BTNode<object> node7 = new BTNode<object>(15);

            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            Console.WriteLine("Initial tree values in preorder:");
            object[] output = tree.PreOrder();
            foreach (var item in output)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------");

            BinaryTree<object> treeMutated = FizzBuzzTreeFunction(tree);

            Console.WriteLine("Mutated tree values in preorder:");
            object[] postOutput = treeMutated.PreOrder();
            foreach (var item in postOutput)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();


        }

        /// <summary>
        ///     Tree intake, mutation, and return
        /// </summary>
        /// <param name="tree">BinaryTree<object> tree</param>
        /// <returns>FizzBuzzTree</returns>
        public static BinaryTree<object> FizzBuzzTreeFunction(BinaryTree<object> tree)
        {
            FizzBuzzTreeWalk(tree.Root);
            return tree;
        }

        /// <summary>
        ///     Traversal and mutation
        /// </summary>
        /// <param name="node">BTNode<object> node</param>
        public static void FizzBuzzTreeWalk(BTNode<object> node)
        {
            if ((int)node.Data % 15 == 0)
            {
                node.Data = "FizzBuzz";
            }
            else if ((int)node.Data % 5 == 0)
            {
                node.Data = "Fizz";
            }
            else if ((int)node.Data % 3 == 0)
            {
                node.Data = "Buzz";
            }

            if (node.Left != null)
            {
                FizzBuzzTreeWalk(node.Left);
            }
            if (node.Right != null)
            {
                FizzBuzzTreeWalk(node.Right);
            }
        }
    }
}

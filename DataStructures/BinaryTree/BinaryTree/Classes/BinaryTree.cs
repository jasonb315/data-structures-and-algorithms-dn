using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
    public class BinaryTree<T>
    {
        public static BTNode<T> Root { get; set; }

        public static List<T> nodeAccumulator = new List<T>();

        /// <summary>
        ///     PreOrder collection of node data
        /// </summary>
        /// <returns>preordered array</returns>
        public static T[] PreOrder()
        {
            if(nodeAccumulator.Count > 0)
            {
                nodeAccumulator.Clear();
            }

            // recursive
            PreOrderWalk(Root);

            T[] returnArray = new T[nodeAccumulator.Count];

            int i = 0;
            foreach (var item in nodeAccumulator)
            {
                returnArray[i++] = item;
            }

            return returnArray;
        }

        /// <summary>
        ///     recursive walk down tree with operation
        /// </summary>
        /// <param name="node">current node</param>
        public static void PreOrderWalk(BTNode<T> node)
        {
            nodeAccumulator.Add(node.Data);

            if (node.Left != null)
            {
                PreOrderWalk(node.Left);
            }
            if (node.Right != null)
            {
                PreOrderWalk(node.Right);
            }
        }

        /// <summary>
        ///     InOrder collection of node data
        /// </summary>
        /// <returns>preordered array</returns>
        private static T[] InOrder()
        {
            if (nodeAccumulator.Count > 0)
            {
                nodeAccumulator.Clear();
            }

            // recursive
            InOrderWalk(Root);

            T[] returnArray = new T[nodeAccumulator.Count];

            int i = 0;
            foreach (var item in nodeAccumulator)
            {
                returnArray[i++] = item;
            }

            return returnArray;
        }

        /// <summary>
        ///     recursive walk down tree with operation
        /// </summary>
        /// <param name="node">current node</param>
        private static void InOrderWalk(BTNode<T> node)
        {
            if (node.Left != null)
            {
                InOrderWalk(node.Left);
            }
            nodeAccumulator.Add(node.Data);
            if (node.Right != null)
            {
                InOrderWalk(node.Right);
            }
        }

        /// <summary>
        ///     PostOrder collection of node data
        /// </summary>
        /// <returns>preordered array</returns>
        public static T[] PostOrder()
        {
            if (nodeAccumulator.Count > 0)
            {
                nodeAccumulator.Clear();
            }

            // recursive
            PostOrderWalk(Root);

            T[] returnArray = new T[nodeAccumulator.Count];

            int i = 0;
            foreach (var item in nodeAccumulator)
            {
                returnArray[i++] = item;
            }

            return returnArray;
        }

        /// <summary>
        ///     recursive walk down tree with operation
        /// </summary>
        /// <param name="node">current node</param>
        private static void PostOrderWalk(BTNode<T> node)
        {
            if (node.Left != null)
            {
                PostOrderWalk(node.Left);
            }
            if (node.Right != null)
            {
                PostOrderWalk(node.Right);
            }
            nodeAccumulator.Add(node.Data);
        }
    }
}

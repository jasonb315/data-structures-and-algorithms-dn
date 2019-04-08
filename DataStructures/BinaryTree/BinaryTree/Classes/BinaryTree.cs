using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
    public class BinaryTree<T>
    {
        public BTNode<T> Root { get; set; }

        public List<T> nodeAccumulator = new List<T>();

        public BinaryTree()
        {

        }

        public BinaryTree(T root)
        {
            BTNode<T> node = new BTNode<T>(root);
            Root = node;
        }

        /// <summary>
        ///     PreOrder collection of node data
        /// </summary>
        /// <returns>preordered array</returns>
        public T[] PreOrder()
        {
            if (nodeAccumulator.Count > 0)
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
        private void PreOrderWalk(BTNode<T> node)
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
        public T[] InOrder()
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
        private void InOrderWalk(BTNode<T> node)
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
        public T[] PostOrder()
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
        private void PostOrderWalk(BTNode<T> node)
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

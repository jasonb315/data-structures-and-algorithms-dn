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
        /// 
        /// </summary>
        /// <returns></returns>
        public static T[] PreOrder()
        {
            if(nodeAccumulator.Count > 0)
            {
                nodeAccumulator.Clear();
            }

            PreOrderWalk(Root);

            T[] returnArray = new T[nodeAccumulator.Count];

            int i = 0;
            foreach (var item in nodeAccumulator)
            {
                returnArray[i++] = item;
            }

            return returnArray;
        }

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
        /// 
        /// </summary>
        /// <returns></returns>
        private static T[] InOrder()
        {
            if (nodeAccumulator.Count > 0)
            {
                nodeAccumulator.Clear();
            }

            InOrderWalk(Root);

            T[] returnArray = new T[nodeAccumulator.Count];

            int i = 0;
            foreach (var item in nodeAccumulator)
            {
                returnArray[i++] = item;
            }

            return returnArray;
        }

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
        /// 
        /// </summary>
        /// <returns></returns>
        public static T[] PostOrder()
        {
            if (nodeAccumulator.Count > 0)
            {
                nodeAccumulator.Clear();
            }

            PostOrderWalk(Root);

            T[] returnArray = new T[nodeAccumulator.Count];

            int i = 0;
            foreach (var item in nodeAccumulator)
            {
                returnArray[i++] = item;
            }

            return returnArray;
        }

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


    // pre order
    // in order
    // post order

}

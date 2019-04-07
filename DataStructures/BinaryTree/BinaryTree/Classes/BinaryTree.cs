using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
    public class BinaryTree<T>
    {
        public static BTNode<T> Root { get; set; }

        public static List<T> nodeAccumulator = new List<T>();

        public static List<T> PreOrder()
        {

            if(nodeAccumulator.Count > 0)
            {
                nodeAccumulator.Clear();
            }

            PreOrderWalk(Root);

            return nodeAccumulator;

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
        
        private static List<T> InOrder()
        {

            if (nodeAccumulator.Count > 0)
            {
                nodeAccumulator.Clear();
            }

            InOrderWalk(Root);

            return nodeAccumulator;

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

        public static List<T> PostOrder()
        {

            if (nodeAccumulator.Count > 0)
            {
                nodeAccumulator.Clear();
            }

            PostOrderWalk(Root);

            return nodeAccumulator;

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

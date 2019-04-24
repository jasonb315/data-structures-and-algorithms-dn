using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
    public class BinaryTree<T>
    {
        public BTNode<T> Root { get; set; }

        public List<T> nodeAccumulator = new List<T>();

        double maxVal = Double.NegativeInfinity;

        public BinaryTree()
        {

        }

        /// <summary>
        ///     Override instantiation; if a number, keep track of highest
        /// </summary>
        /// <param name="rootVal"></param>
        public BinaryTree(T rootVal)
        {
            BTNode<T> node = new BTNode<T>(rootVal);

            Type T = rootVal.GetType();
            if (T.Equals(typeof(int)) || T.Equals(typeof(double)))
            {
                maxVal = Convert.ToInt32(rootVal);
            }

            Root = node;
        }

        /// <summary>
        ///     Calls recursive check for max Data val given that Data is numeric type
        /// </summary>
        /// <returns>Max Data val</returns>
        public double FindMaxVal()
        {
            FindMaxVal(Root);
            return maxVal;
        }

        /// <summary>
        ///     Recursively checks node Data against maxVal
        /// </summary>
        /// <param name="node">node</param>
        private void FindMaxVal(BTNode<T> node)
        {

            Type T = node.Data.GetType();
            if (T.Equals(typeof(int)) || T.Equals(typeof(double)))
            {
                if (maxVal < Convert.ToDouble(node.Data))
                {
                    maxVal = Convert.ToDouble(node.Data);
                }
            }
            else
            {
                return;
            }

            if (node.Left != null)
            {
                FindMaxVal(node.Left);
            }
            if (node.Right != null)
            {
                FindMaxVal(node.Right);
            }
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

        /// <summary>
        ///     Breadth first traversal using queue
        /// </summary>
        /// <returns>List<T></returns>
        public List<T> BreadthFirst()
        {
            List<T> rList = new List<T>();
            Queue<BTNode<T>> queue = new Queue<BTNode<T>>();

            queue.Enqueue(Root);

            while(queue.Count > 0)
            {
                BTNode<T> popNode = queue.Dequeue();
                if (popNode.Left != null)
                {
                    queue.Enqueue(popNode.Left);
                }
                if (popNode.Right != null)
                {
                    queue.Enqueue(popNode.Right);
                }
                rList.Add(popNode.Data);
            }
            return rList;
        }

        public int treeLevels { get; set; }

        public int levelCount()
        {
            treeLevels = 0;
            _walk(Root, 1);
            return treeLevels;
        }

        private void _walk(BTNode<T> node, int level)
        {
            if (node.Left != null)
            {
                _walk(node.Left, level + 1);
            }
            if (node.Right != null)
            {
                _walk(node.Right, level + 1);
            }
            else if (node.Left == null && node.Right == null)
            {
                if (level > treeLevels)
                {
                    treeLevels = level;
                }
            }
        }

        public int levelCountAlt(BTNode<T> root)
        {
            int leftHeight = 0;
            int rightHeight = 0;

            if (root.Left != null)
            {
                leftHeight = levelCountAlt(root.Left);
            }
            if (root.Right != null)
            {
                rightHeight = levelCountAlt(root.Right);
            }

            int max = Math.Max(leftHeight, rightHeight);

            return max + 1;
        }
    }
}

using System;
using Xunit;
using BinaryTree.Classes;
using System.Collections.Generic;

namespace XUnitTestTree
{
    public class UnitTest1
    {
        [Fact]
        public void BTinstantiation()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            Assert.IsType<BinaryTree<int>>(tree);
        }

        [Fact]
        public void BSTinstantiation()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            Assert.IsType<BinarySearchTree<int>>(tree);
        }

        [Fact]
        public void BTNodeInstantiation()
        {
            //BinaryTree<BTNode<int>> tree = new BinaryTree<BTNode<int>>();
            BTNode<int> node = new BTNode<int>(3);
            //tree.Root = node;
            Assert.Equal(3, node.Data);
        }

        [Fact]
        public void BTNodeRoot()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            BTNode<int> node = new BTNode<int>(3);
            tree.Root = node;
            Assert.Equal(3, tree.Root.Data);
        }

        [Fact]
        public void BSTNodeRoot()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            BTNode<int> node = new BTNode<int>(3);
            tree.Root = node;
            Assert.Equal(3, tree.Root.Data);
        }

        [Fact]
        public void BTAddLeftChild()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            BTNode<int> node1 = new BTNode<int>(3);
            BTNode<int> node2 = new BTNode<int>(5);
            tree.Root = node1;
            node1.Left = node2;
            Assert.Equal(5, tree.Root.Left.Data);
        }

        [Fact]
        public void BTAddRightChild()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            BTNode<int> node1 = new BTNode<int>(3);
            BTNode<int> node2 = new BTNode<int>(5);
            tree.Root = node1;
            node1.Right = node2;
            Assert.Equal(5, tree.Root.Right.Data);
        }

        [Fact]
        public void BSTAddLeftChild()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            BTNode<int> node1 = new BTNode<int>(3);
            node1.ID = 3;
            tree.Root = node1;
            tree.Add(1, 1);
            Assert.Equal(1, tree.Root.Left.ID);
        }

        [Fact]
        public void BSTAddRightChild()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            BTNode<int> node1 = new BTNode<int>(3);
            node1.ID = 3;
            tree.Root = node1;
            tree.Add(5, 5);
            Assert.Equal(5, tree.Root.Right.ID);
        }

        [Fact]
        public void BTPreOrderTraversal()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            BTNode<int> node1 = new BTNode<int>(1);
            BTNode<int> node2 = new BTNode<int>(2);
            BTNode<int> node3 = new BTNode<int>(3);
            BTNode<int> node4 = new BTNode<int>(4);
            BTNode<int> node5 = new BTNode<int>(5);
            BTNode<int> node6 = new BTNode<int>(6);
            BTNode<int> node7 = new BTNode<int>(7);
            
            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            int[] output = tree.PreOrder();
            int[] expected = new int[] { 1, 2, 4, 5, 3, 6, 7 };
            Assert.Equal(expected, output);
        }

        [Fact]
        public void BTInOrderTraversal()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            BTNode<int> node1 = new BTNode<int>(1);
            BTNode<int> node2 = new BTNode<int>(2);
            BTNode<int> node3 = new BTNode<int>(3);
            BTNode<int> node4 = new BTNode<int>(4);
            BTNode<int> node5 = new BTNode<int>(5);
            BTNode<int> node6 = new BTNode<int>(6);
            BTNode<int> node7 = new BTNode<int>(7);


            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            int[] output = tree.InOrder();
            int[] expected = new int[] { 4, 2, 5, 1, 6, 3, 7 };
            Assert.Equal(expected, output);
        }

        [Fact]
        public void BTPostOrderTraversal()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            BTNode<int> node1 = new BTNode<int>(1);
            BTNode<int> node2 = new BTNode<int>(2);
            BTNode<int> node3 = new BTNode<int>(3);
            BTNode<int> node4 = new BTNode<int>(4);
            BTNode<int> node5 = new BTNode<int>(5);
            BTNode<int> node6 = new BTNode<int>(6);
            BTNode<int> node7 = new BTNode<int>(7);

            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            int[] output = tree.PostOrder();
            int[] expected = new int[] { 4, 5, 2, 6, 7, 3, 1 };
            Assert.Equal(expected, output);
        }

        [Fact]
        public void BreadthFirstTraversal()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            BTNode<int> node1 = new BTNode<int>(1);
            BTNode<int> node2 = new BTNode<int>(2);
            BTNode<int> node3 = new BTNode<int>(3);
            BTNode<int> node4 = new BTNode<int>(4);
            BTNode<int> node5 = new BTNode<int>(5);
            BTNode<int> node6 = new BTNode<int>(6);
            BTNode<int> node7 = new BTNode<int>(7);

            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            List<int> output = tree.BreadthFirst();
            int[] expected = new int[] { 1,2,3,4,5,6,7 };
            Assert.Equal(expected, output);
        }

        [Fact]
        public void FindMaxValExpected()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            BTNode<int> node1 = new BTNode<int>(1);
            BTNode<int> node2 = new BTNode<int>(2);
            BTNode<int> node3 = new BTNode<int>(3);
            BTNode<int> node4 = new BTNode<int>(4);
            BTNode<int> node5 = new BTNode<int>(5);
            BTNode<int> node6 = new BTNode<int>(6);
            BTNode<int> node7 = new BTNode<int>(7);

            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            double output = tree.FindMaxVal();
            double expected = 7;
            Assert.Equal(expected, output);
        }

        [Fact]
        public void FindMaxValExpectedRoot()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            BTNode<int> node1 = new BTNode<int>(10);
            BTNode<int> node2 = new BTNode<int>(2);
            BTNode<int> node3 = new BTNode<int>(3);
            BTNode<int> node4 = new BTNode<int>(4);
            BTNode<int> node5 = new BTNode<int>(5);
            BTNode<int> node6 = new BTNode<int>(6);
            BTNode<int> node7 = new BTNode<int>(7);

            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            double output = tree.FindMaxVal();
            double expected = 10;
            Assert.Equal(expected, output);
        }

        /// <summary>
        ///     maxVal defaulted to -inf, stays that way in the event of non-numeric type
        /// </summary>
        [Fact]
        public void FindMaxValExpectedStringVals()
        {
            BinaryTree<string> tree = new BinaryTree<string>();

            BTNode<string> node1 = new BTNode<string>("x");
            BTNode<string> node2 = new BTNode<string>("x");
            BTNode<string> node3 = new BTNode<string>("x");
            BTNode<string> node4 = new BTNode<string>("x");
            BTNode<string> node5 = new BTNode<string>("x");
            BTNode<string> node6 = new BTNode<string>("x");
            BTNode<string> node7 = new BTNode<string>("x");

            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            double output = tree.FindMaxVal();
            double expected = Double.NegativeInfinity;
            Assert.Equal(expected, output);
        }

        [Fact]
        public void levelCountWorks()
        {
            BinaryTree<string> tree = new BinaryTree<string>();

            // level 1
            BTNode<string> node1 = new BTNode<string>("x");
            // level 2
            BTNode<string> node2 = new BTNode<string>("x");
            BTNode<string> node3 = new BTNode<string>("x");
            // level 3
            BTNode<string> node4 = new BTNode<string>("x");
            BTNode<string> node5 = new BTNode<string>("x");
            BTNode<string> node6 = new BTNode<string>("x");
            BTNode<string> node7 = new BTNode<string>("x");

            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            int levels = tree.levelCount();
            Assert.Equal(3, levels);
        }

        [Fact]
        public void levelCountAltWorks()
        {
            BinaryTree<string> tree = new BinaryTree<string>();

            // level 1
            BTNode<string> node1 = new BTNode<string>("x");
            // level 2
            BTNode<string> node2 = new BTNode<string>("x");
            BTNode<string> node3 = new BTNode<string>("x");
            // level 3
            BTNode<string> node4 = new BTNode<string>("x");
            BTNode<string> node5 = new BTNode<string>("x");
            BTNode<string> node6 = new BTNode<string>("x");
            BTNode<string> node7 = new BTNode<string>("x");

            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;
            node3.Left = node6;
            node3.Right = node7;

            int levels = tree.levelCountAlt(tree.Root);
            Assert.Equal(3, levels);
        }
    }
}

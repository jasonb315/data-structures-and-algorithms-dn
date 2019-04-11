using System;
using Xunit;
using BinaryTree.Classes;
using static FizzBuzzTree.Program;

namespace XUnitTestFizzBuzzTree
{
    public class UnitTest1
    {
        [Fact]
        public void TraversalAndMutation()
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

            BinaryTree<object> treeMutated = FizzBuzzTreeFunction(tree);
            object[] postOutput = treeMutated.PreOrder();
            object[] expected = new object[] { "Fizz", 2, 4, "Fizz", "Buzz", "Buzz", "FizzBuzz" };
            Assert.Equal(expected, postOutput);
        }

        [Fact]
        public void ExpectedFailure()
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

            BinaryTree<object> treeMutated = FizzBuzzTreeFunction(tree);
            object[] postOutput = treeMutated.PreOrder();
            object[] expected = new object[] { 10, 2, 4, 5, 3, 6, 15 };
            bool compare = (postOutput == expected) ? true : false;
            Assert.False(compare);
        }
    }
}

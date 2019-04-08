using System;
using Xunit;
using BinaryTree.Classes;

namespace XUnitTestTree
{
    public class UnitTest1
    {
        [Fact]
        public void BTinstantiation()
        {
            BinaryTree<BTNode<int>> tree = new BinaryTree<BTNode<int>>();
            Assert.IsType<BinaryTree<BTNode<int>>>(tree);
        }

        [Fact]
        public void BSTinstantiation()
        {
            BinarySearchTree<BTNode<int>> tree = new BinarySearchTree<BTNode<int>>();
            Assert.IsType<BinarySearchTree<BTNode<int>>>(tree);
        }
    }
}


//Can successfully instantiate a tree with a single root node
//Can successfully add a left child and right child to a single root node
//Can successfully return a collection from a preorder traversal
//Can successfully return a collection from an inorder traversal
//Can successfully return a collection from a postorder traversal
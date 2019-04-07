using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
    public class BinarySearchTree<T>
    {
        public static BTNode<T> Root { get; set; }

        public void Add(int ID, T data)
        {
            BTNode<T> newNode = new BTNode<T>(data);
            newNode.ID = ID;

            // no root? make root
            if(Root == null)
            {
                Root = newNode;
                return;
            }

            // root? start at root
            BTNode<T> currentNode = Root;

            while (true)
            {

                if (newNode.ID > currentNode.ID && currentNode.Right == null)
                {
                    currentNode.Right = newNode;
                    return;
                }

                else if (newNode.ID < currentNode.ID && currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                    return;
                }

                else if (newNode.ID > currentNode.ID && currentNode.Right != null)
                {
                    currentNode = currentNode.Right;
                }

                else if (newNode.ID < currentNode.ID && currentNode.Left != null)
                {
                    currentNode = currentNode.Left;
                }

            }
        }

        // contains
    }


}

using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
    public class BinarySearchTree<T>
    {
        public static BTNode<T> Root { get; set; }

        /// <summary>
        ///     Conditionally places new node in tree based on given ID val
        /// </summary>
        /// <param name="ID">int node.ID</param>
        /// <param name="data">T node.Data</param>
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
            else
            {
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
        }

        /// <summary>
        ///     conditionally walks down tree checking for value match
        /// </summary>
        /// <param name="key">Node ID</param>
        /// <returns>bool for key node.Id match</returns>
        public bool Contains(int key)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                BTNode<T> currentNode = Root;

                while (true)
                {
                    if (currentNode.ID == key)
                    {
                        return true;
                    }
                    if (currentNode.ID > key && currentNode.Left != null)
                    {
                        currentNode = currentNode.Left;
                    }
                    else if (currentNode.ID < key && currentNode.Right != null)
                    {
                        currentNode = currentNode.Left;
                    }
                    else if(currentNode.ID < key && currentNode.Right == null)
                    {
                        return false;
                    }
                    else if(currentNode.ID > key && currentNode.Left == null)
                    {
                        return false;
                    }
                }
            }
        }
    }
}

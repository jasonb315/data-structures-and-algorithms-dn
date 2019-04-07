using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.Classes
{
    public class BTNode<T>
    {
        public T Data { get; set; }
        public BTNode<T> Left { get; set; }
        public BTNode<T> Right { get; set; }
        public BTNode<T> Parent { get; set; }

        public BTNode(T data)
        {
            Data = data;
        }
    }
}

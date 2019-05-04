using System;
using System.Collections.Generic;
using System.Text;

namespace MyGraph.Classes
{
    class MyGraph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
        public int _size = 0;
        public MyGraph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        
    }
}

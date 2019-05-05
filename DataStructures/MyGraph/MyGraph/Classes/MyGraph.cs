using System;
using System.Collections.Generic;
using System.Text;

namespace MyGraph.Classes
{
    public class MyGraph<T>
    {
        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList { get; set; }
        public int _size = 0;
        public MyGraph()
        {
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T>>>();
        }

        public Vertex<T> AddVertex(T data)
        {
            Vertex<T> vertex = new Vertex<T>(data);
            AdjacencyList.Add(vertex, new List<Edge<T>>());
            _size++;
            return vertex;
        }

        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AdjacencyList[a].Add(new Edge<T> { Weight = weight, Vertex = b });
        }

        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);
        }

        public List<Vertex<T>> GetVertices()
        {
            List<Vertex<T>> verts = new List<Vertex<T>>();

            foreach (var vert in AdjacencyList.Keys)
            {
                verts.Add(vert);
            }
            
            return verts;
            // returns all nodes in graph as a list
        }

        public List<Tuple<Vertex<T>, int>> GetNeighbors(Vertex<T> a)
        {
            List<Tuple<Vertex<T>, int>> neighbors = new List<Tuple<Vertex<T>, int>>();

            foreach (var adj in AdjacencyList)
            {
                foreach (var edge in adj.Value)
                {
                    if (edge.Vertex.Data.ToString() == a.Data.ToString())
                    {
                        neighbors.Add(new Tuple<Vertex<T>, int>(adj.Key, edge.Weight));
                    }
                }
            }

            Console.WriteLine($"Neighbors of {a.Data}:");
            foreach (var item in neighbors)
            {
                Console.WriteLine($"Vertex: {item.Item1.Data.ToString()}, Weight: {item.Item2}");
            }
            return neighbors;
            // collection of nodes from a given node. include weight in return
        }

        public int Size()
        {
            return _size;
        }

        public void Print()
        {
            foreach (var vertex in AdjacencyList)
            {
                Console.Write($"Vertex: {vertex.Key.Data} =>");
                foreach (var edge in vertex.Value)
                {
                    Console.Write($"{edge.Vertex.Data}, {edge.Weight} =>");
                }
                Console.WriteLine("null");
            }
        }
    }
}

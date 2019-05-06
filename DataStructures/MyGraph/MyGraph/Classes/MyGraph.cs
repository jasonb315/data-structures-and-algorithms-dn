using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        ///     Adds a Vertex to the graph.
        /// </summary>
        /// <param name="data">The contents of the Vertex</param>
        /// <returns>The vertex added</returns>
        public Vertex<T> AddVertex(T data)
        {
            Vertex<T> vertex = new Vertex<T>(data);
            AdjacencyList.Add(vertex, new List<Edge<T>>());
            _size++;
            return vertex;
        }

        /// <summary>
        ///     Adds a directed edge from the first vertex passed in to the second
        /// </summary>
        /// <param name="a">Vertex</param>
        /// <param name="b">Vertex</param>
        /// <param name="weight">The weight of the edge</param>
        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AdjacencyList[a].Add(new Edge<T> { Weight = weight, Vertex = b });
        }

        /// <summary>
        ///     Adds a mutual connection between two vertices
        /// </summary>
        /// <param name="a">first Vertex</param>
        /// <param name="b">second Vertex</param>
        /// <param name="weight"></param>
        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, int weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);
        }

        /// <summary>
        ///     Collects a list of the vertices in the graph
        /// </summary>
        /// <returns>List of Vertices in graph</returns>
        public List<Vertex<T>> GetVertices()
        {
            List<Vertex<T>> verts = new List<Vertex<T>>();

            foreach (var vert in AdjacencyList.Keys)
            {
                verts.Add(vert);
            }
            return verts;
        }

        /// <summary>
        ///     Reports all the vertices that point to a given vertex.
        /// </summary>
        /// <param name="a">Key Vertex</param>
        /// <returns>In the form of: List<Tuple<Vertex<T></returns>
        public List<Tuple<Vertex<T>, int>> GetNeighborsPointingTo(Vertex<T> a)
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

            Console.WriteLine($"Neighbors pointing to [{a.Data}]:");
            foreach (var item in neighbors)
            {
                Console.WriteLine($"Vertex: {item.Item1.Data.ToString()}, Weight: {item.Item2}");
            }

            return neighbors;
        }

        /// <summary>
        ///     Reports all the vertices that are pointed to from a given vertex.
        /// </summary>
        /// <param name="a">Key Vertex</param>
        /// <returns>In the form of: List<Tuple<Vertex<T></returns>
        public List<Tuple<Vertex<T>, int>> GetNeighborsPointingFrom(Vertex<T> a)
        {
            //Data format: Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList
            List<Tuple<Vertex<T>, int>> neighbors = new List<Tuple<Vertex<T>, int>>();
            foreach (var edge in AdjacencyList[a])
            {
                Tuple<Vertex<T>,int> connection = new Tuple<Vertex<T>,int>(edge.Vertex, edge.Weight);
                neighbors.Add(connection);
            }

            Console.WriteLine($"Neighbors [{a.Data}] point to:");
            foreach (var item in neighbors)
            {
                Console.WriteLine($"Vertex: {item.Item1.Data.ToString()}, Weight: {item.Item2}");
            }

            return neighbors;
        }

        /// <summary>
        ///     Gathers all connections regardless of direction, from a key vertex.
        /// </summary>
        /// <param name="a">Vertex searching for</param>
        /// <returns>List<Tuple<Vertex<T> list of adjacent vertex in key value tuples: vertex, weight</returns>
        public List<Tuple<Vertex<T>, int>> GetNeighbors(Vertex<T> a)
        {
            List<Tuple<Vertex<T>, int>> pointingTo = GetNeighborsPointingTo(a);
            List<Tuple<Vertex<T>, int>> pointedToFrom = GetNeighborsPointingFrom(a);

            // do not mutate collected lists:
            List<Tuple<Vertex<T>, int>> pointing = new List<Tuple<Vertex<T>, int>>();

            foreach (var edge in pointedToFrom)
            {
                pointing.Add(edge);
            }
            foreach (var edge in pointingTo)
            {
                pointing.Add(edge);
            }
            return pointing;
        }

        // ! Inner and outer joins from 'to' and 'from' neighbor algorithym outputs can be used to determine graph type programatically.
        // ! Comparison of output from programatic determination of type vs count can be used to calculate proportions of connection types.

        /// <summary>
        ///     Get the quantity of vertices
        /// </summary>
        /// <returns>quantity of vertices</returns>
        public int Size()
        {
            return _size;
        }

        /// <summary>
        ///     Prints out the AdjacencyList.
        /// </summary>
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

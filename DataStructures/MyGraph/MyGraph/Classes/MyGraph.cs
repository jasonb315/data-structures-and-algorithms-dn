using System;
using System.Collections;
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
        public List<Tuple<Vertex<T>, int>> InDegree(Vertex<T> a)
        {
            Console.WriteLine(" GetNeighborsPointingTo()");
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

            Console.WriteLine($" Neighbors pointing to [{a.Data}]:");
            foreach (var item in neighbors)
            {
                Console.WriteLine($" Vertex: {item.Item1.Data.ToString()}, Weight: {item.Item2}");
            }
            Console.WriteLine();
            return neighbors;
        }

        /// <summary>
        ///     Reports all the vertices that are pointed to from a given vertex.
        /// </summary>
        /// <param name="a">Key Vertex</param>
        /// <returns>In the form of: List<Tuple<Vertex<T></returns>
        public List<Tuple<Vertex<T>, int>> OutDegree(Vertex<T> a)
        {
            Console.WriteLine(" GetNeighborsPointingFrom()");

            //Data format: Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList
            List<Tuple<Vertex<T>, int>> neighbors = new List<Tuple<Vertex<T>, int>>();
            foreach (var edge in AdjacencyList[a])
            {
                Tuple<Vertex<T>,int> connection = new Tuple<Vertex<T>,int>(edge.Vertex, edge.Weight);
                neighbors.Add(connection);
            }

            Console.WriteLine($" Neighbors [{a.Data}] point to:");
            foreach (var item in neighbors)
            {
                Console.WriteLine($" Vertex: {item.Item1.Data.ToString()}, Weight: {item.Item2}");
            }
            Console.WriteLine();
            return neighbors;
        }

        /// <summary>
        ///     Gathers all connections regardless of direction, from a key vertex.
        ///     Not for use with undirected graphs with mutual edges: produces duplicates.
        /// </summary>
        /// <param name="a">Vertex searching for</param>
        /// <returns>List<Tuple<Vertex<T> list of adjacent vertex in key value tuples: vertex, weight</returns>
        public List<Tuple<Vertex<T>, int>> GetNeighbors(Vertex<T> a)
        {
            Console.WriteLine("GetNeighbors()");
            List<Tuple<Vertex<T>, int>> pointingTo = InDegree(a);
            List<Tuple<Vertex<T>, int>> pointedToFrom = OutDegree(a);

            // do not mutate collected lists:
            List<Tuple<Vertex<T>, int>> pointing = new List<Tuple<Vertex<T>, int>>();

            foreach (var edge in pointedToFrom)
            {
                pointing.Add(edge);
            }
            Console.WriteLine();
            foreach (var edge in pointingTo)
            {
                pointing.Add(edge);
            }
            Console.WriteLine();

            return pointing;
        }

        public decimal ClusteringCoefficient(Vertex<T> a)
        {
            

        }

        public int MaxNeighborEdge()
        {
            List<Tuple<Vertex<T>, int>> neighbors = GetNeighbors(a);

            
            int edgeScaleA = 1;
            int edgeScaleB = 3;

            if (neighbors.Count < 3) { return 0; }
            if (neighbors.Count == 3) { return 1; }

            int maxNeighbors = MaxNeighborEdgeCalculation(1, 3, neighbors.Count);
            int actualNeighbors = ActualNeighborEdge();

        }

        private int MaxNeighborEdgeCalculation(int tail, int lead, int i)
        {
            if (i == 3) { return lead; }

            return MaxNeighborEdgeCalculation(lead, (lead-tail+1+lead), i--);
        }

        public int ActualNeighborEdge()
        {
            int actualNeighbors = 0;

        }

        // ! Inner and outer joins from 'to' and 'from' neighbor algorithym outputs can be used to determine graph type programatically.
        // ! Comparison of output from programatic determination of type vs count can be used to calculate proportions of connection types.

        /// <summary>
        ///     Traversal outward from a given Vertex depth first
        /// </summary>
        /// <returns>List<Vertex<T>> list of vertex depth first</returns>
        public List<Vertex<T>> DepthFirst(Vertex<T> a)
        {
            Queue<Vertex<T>> inLine = new Queue<Vertex<T>>();
            List<Vertex<T>> visited = new List<Vertex<T>>();
            inLine.Enqueue(a);

            while (inLine.TryPeek(out a))
            {
                Vertex<T> current = inLine.Dequeue();
                if (!visited.Contains(current))
                {
                    visited.Add(current);
                }
                List<Tuple<Vertex<T>, int>> neighbors = OutDegree(current);
                foreach (var edge in neighbors)
                {
                    if (!visited.Contains(edge.Item1))
                    {
                        inLine.Enqueue(edge.Item1);
                    }
                }
            }

            Console.WriteLine();
            foreach (var item in visited)
            {
                Console.Write($"{item.Data}, ");
            }

            return visited;
        }

        /// <summary>
        ///    Get the quantity of vertices
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
            Console.WriteLine();
        }
    }
}

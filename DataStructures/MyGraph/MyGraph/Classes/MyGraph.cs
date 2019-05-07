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
        /// <returns>In the form of: [(vertex which points to target, weight),...]</returns>
        public List<Tuple<Vertex<T>, int>> InDegree(Vertex<T> a)
        {
            Console.WriteLine(" InDegree()");
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
        /// <returns>In the form of: [(vertex pointed to from target, weight),...]</returns>
        public List<Tuple<Vertex<T>, int>> OutDegree(Vertex<T> a)
        {
            Console.WriteLine(" OutDegree()");

            // Data format: Dictionary<Vertex<T>, List<Edge<T>>> AdjacencyList
            List<Tuple<Vertex<T>, int>> neighbors = new List<Tuple<Vertex<T>, int>>();
            
            // converts adjacency list to same data structure as InDegree return
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
        /// </summary>
        /// <param name="a">Vertex searching for</param>
        /// <returns>List<Tuple<Vertex<T> list of adjacent vertex in key value tuples: vertex, weight</returns>
        public List<Tuple<Vertex<T>, int>> GetNeighborsDirected(Vertex<T> a)
        {
            Console.WriteLine("GetNeighborsDirected()");

            // ! return identical datasets in Undirected graphs. Useful?
            List<Tuple<Vertex<T>, int>> pointingTo = InDegree(a);
            List<Tuple<Vertex<T>, int>> pointedToFrom = OutDegree(a);

            // do not mutate collected lists:
            List<Tuple<Vertex<T>, int>> edgeCollection = new List<Tuple<Vertex<T>, int>>();

            foreach (var edge in pointedToFrom)
            {
                edgeCollection.Add(edge);
            }
            Console.WriteLine();
            foreach (var edge in pointingTo)
            {
                edgeCollection.Add(edge);
            }
            Console.WriteLine();

            return edgeCollection;
        }

        /// <summary>
        ///     The output is the same as OutDegree, except that the meaning of the returned.
        /// </summary>
        /// <param name="a">Target Vertex</param>
        /// <returns>Neighbors sans undirected duplicates</returns>
        public List<Tuple<Vertex<T>, int>> GetNeighborsUndirected(Vertex<T> a)
        {
            // ! The output is the same as OutDegree, except that the meaning of the returned
            //   data has changed, which becomes implicit where this method is called.
            return OutDegree(a);
        }

        /// <summary>
        ///     The degree upon which a vertex's neighbors are connected to eachother:
        ///     Fraction of actual among possible connections among neighbors of a target vertex.
        /// </summary>
        /// <param name="a">target Vertex of Graph</param>
        /// <returns>Value from 0-1, 0 being no cluster interconnection and 1 being completely interconnected</returns>
        public decimal ClusteringCoefficientUndirected(Vertex<T> a)
        {
            int actualNeighbors = NeighborMutualEdgeCount(GetNeighborsUndirected(a))/2;
            int maxNeighbors = MaxNeighborEdge(a);
            return decimal.Divide(actualNeighbors, maxNeighbors);
        }

        /// <summary>
        ///     From a set of vertices that share connection to a vertex, count the connections among them to eachother.
        /// </summary>
        /// <param name="t">List of neighboring nodes</param>
        /// <returns>int count of mutual connections among neighbors only</returns>
        private int NeighborMutualEdgeCount(List<Tuple<Vertex<T>, int>> t)
        {
            // IN: outdegree of ClusteringCoefficientUndirected target
            //  in the form of: [(vertex pointed to from target, weight),...]
            int mutualConnectionCount = 0;
            // outdegree set of target loop
            foreach (var firstOrderOrbit in t)
            {
                List<Vertex<T>> visited = new List<Vertex<T>>();
                List<Tuple<Vertex<T>, int>> currentNeighbors = GetNeighborsUndirected(firstOrderOrbit.Item1);
                foreach (var remoteOrbit in currentNeighbors)
                {
                    foreach (var possibleReciprocal in t)
                    {
                        if (!visited.Contains(possibleReciprocal.Item1))
                        {
                            if (remoteOrbit.Item1 == possibleReciprocal.Item1)
                            {
                                mutualConnectionCount++;
                            }
                        }
                    }
                }
                visited.Add(firstOrderOrbit.Item1);
            }
            return mutualConnectionCount;
        }

        /// <summary>
        ///     Checks conditions and calls for calcultion of max possible connections in a cluster of n Vertices
        /// </summary>
        /// <param name="a">target Vertex</param>
        /// <returns></returns>
        public int MaxNeighborEdge(Vertex<T> a)
        {
            // mutual connections counted by outDegree
            List<Tuple<Vertex<T>, int>> neighbors = GetNeighborsUndirected(a);

            if (neighbors.Count <= 1) { return 0; }
            if (neighbors.Count == 2) { return 1; }

            return MaxNeighborEdgeCalculation(1, 3, neighbors.Count);
        }

        /// <summary>
        ///     Recursive calculation of maximum connections given n Vertices.
        /// </summary>
        /// <param name="tail">trailing scale index</param>
        /// <param name="lead">lleading scale index</param>
        /// <param name="i">scale mapping itteration counter</param>
        /// <returns>int maximum connection count</returns>
        private int MaxNeighborEdgeCalculation(int tail, int lead, int i)
            {
                if (i == 3) { return lead; }

                return MaxNeighborEdgeCalculation(lead, (lead*2-tail+1), i--);
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

// cool junk

// meh..? reusable.
//IQueryable<Tuple<Vertex<T>, int>> innerJoin = t.AsQueryable().Intersect(currentNeighbors);
//mutualConnectionCount += innerJoin.Count();
//visited.Add(tuple.Item1);
//t.Remove(tuple);

//t.Remove(firstOrderOrbit); err: cannot modify list len being enumerated   
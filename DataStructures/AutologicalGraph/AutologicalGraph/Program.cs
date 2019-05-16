using AutoGraph.Classes;
using AutoGraph.Classes.Kernels;
using System;
using System.Collections.Generic;

namespace AutoGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("\n");
            //Graph m = new Graph();
            ////m.AddVertex(1);
            //////Console.WriteLine("315: " + m.size);
            //var A = m.AddVertex();
            //var B = m.AddVertex();
            //var C = m.AddVertex();
            //var D = m.AddVertex();
            ////var v4 = m.AddVertex();
            ////var v5 = m.AddVertex();
            ////var v6 = m.AddVertex();
            ////var v7 = m.AddVertex();
            ////var v8 = m.AddVertex();
            ////var v9 = m.AddVertex();


            //m.UndirectedEdge(A, B, 3);
            //m.UndirectedEdge(A, C, 3);
            //m.UndirectedEdge(A, D, 3);

            //var E = m.AddVertex();
            //m.DirectedEdge(A, E, 3);

            //var F = m.AddVertex();
            //m.DirectedEdge(F, A, 3);

            //var G = m.AddVertex();
            //m.DirectedEdge(G, A, 3);

            //m.UndirectedEdge(B, C, 7);
            //m.UndirectedEdge(C, D, 7);
            //m.UndirectedEdge(D, B, 7);

            ////m.UndirectedEdge(v9, v8, 2);

            //m.PrintMatrix();
            //m.PrintVertices();
            //m.PrintEdges();

            //Console.WriteLine(m.OutDegreeCount(A));
            //Console.WriteLine(m.InDegreeCount(A));

            //List<Vertex> outd = m.OutDegreeVertices(A);
            //foreach (var item in outd)
            //{
            //    Console.WriteLine(item.ID);
            //}

            //Console.WriteLine();

            //List<Vertex> ind = m.InDegreeVertices(A);
            //foreach (var item in ind)
            //{
            //    Console.WriteLine(item.ID);
            //}

            //Console.WriteLine(m.DirectedEdgeCount(A));

            //Console.WriteLine($"neighbor count: {m.NeighborCount(A)}");
            //Console.WriteLine($"Max Connections: {m.MaxConnections(7)}");

            //Console.WriteLine("-----------------------");

            //Graph graph2 = new Graph();
            //var aa = graph2.AddVertex();
            //var bb = graph2.AddVertex();
            //var cc = graph2.AddVertex();
            //var dd = graph2.AddVertex();
            //var ee = graph2.AddVertex();

            //graph2.UndirectedEdge(aa, bb, 5);
            //graph2.UndirectedEdge(aa, cc, 5);
            //graph2.UndirectedEdge(aa, dd, 5);
            //graph2.UndirectedEdge(aa, ee, 5);

            //graph2.UndirectedEdge(bb, cc, 5);
            //graph2.UndirectedEdge(bb, dd, 5);
            //graph2.UndirectedEdge(cc, dd, 5);
            //graph2.UndirectedEdge(cc, ee, 5);
            //graph2.UndirectedEdge(dd, ee, 5);
            //graph2.UndirectedEdge(ee, bb, 5);

            //Console.WriteLine(graph2.NondirectionalClusteringCoefficient(aa));

            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();
            List<Vertex> set = new List<Vertex> { A, B, C, D };
            graph.FullConnectSet(set, 1);
        }
    }
}

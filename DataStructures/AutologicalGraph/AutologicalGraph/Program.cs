using AutoGraph.Classes;
using AutoGraph.Classes.Kernels;
using System;

namespace AutoGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Graph m = new Graph();
            //m.AddVertex(1);
            ////Console.WriteLine("315: " + m.size);
            var A = m.AddVertex();
            var B = m.AddVertex();
            var C = m.AddVertex();
            var D = m.AddVertex();
            var v4 = m.AddVertex();
            var v5 = m.AddVertex();
            var v6 = m.AddVertex();
            var v7 = m.AddVertex();
            var v8 = m.AddVertex();
            var v9 = m.AddVertex();


            m.UndirectedEdge(A, B, 3);
            m.UndirectedEdge(A, C, 3);
            m.UndirectedEdge(A, D, 3);

            m.UndirectedEdge(B, C, 7);
            m.UndirectedEdge(C, D, 7);
            m.UndirectedEdge(D, B, 7);

            //m.UndirectedEdge(v9, v8, 2);

            m.PrintMatrix();
            m.PrintVertices();
            m.PrintEdges();
        }
    }
}

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
            var v1 = m.AddVertex();
            var v2 = m.AddVertex();
            var v3 = m.AddVertex();
            var v4 = m.AddVertex();
            var v5 = m.AddVertex();
            var v6 = m.AddVertex();
            var v7 = m.AddVertex();
            var v8 = m.AddVertex();
            var v9 = m.AddVertex();


            m.DirectedEdge(v1, v3, 7);
            m.DirectedEdge(v2, v4, 7);
            m.DirectedEdge(v3, v5, 7);
            m.UndirectedEdge(v9, v8, 2);

            m.PrintMatrix();
        }
    }
}

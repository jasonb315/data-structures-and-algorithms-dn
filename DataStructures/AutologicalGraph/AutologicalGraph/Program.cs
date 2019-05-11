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
            m.AddVertex(1);
            m.AddVertex(1);
            m.AddVertex(2);
            m.AddVertex(1);
            m.AddVertex(1);
            m.AddVertex(2);
            m.AddVertex(2);
            m.AddVertex(2);
            m.AddVertex(1);
            m.AddVertex(1);
            m.AddVertex(1);
            m.AddVertex(1);
            m.DirectedEdge(m.AllVertices[0], m.AllVertices[1], 8);
            m.UndirectedEdge(m.AllVertices[5], m.AllVertices[7], 2);

            m.PrintMatrix();
        }
    }
}

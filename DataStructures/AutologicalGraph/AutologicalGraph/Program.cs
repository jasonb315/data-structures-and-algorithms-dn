using AutoGraph.Classes;
using AutoGraph.Classes.Kernels;
using AutologicalGraph.Classes.Strands;
using System;
using System.Collections.Generic;

namespace AutoGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Strand s = new Strand();
            Graph graph = new Graph();
            var zero = graph.AddVertex();
            zero.K.Run(s.flower, 0);

            graph.PrintMatrix();
            graph.PrintEdges();
            Console.WriteLine($"SIZE: {graph.size}");
            graph.PrintVertices();

        }
    }
}

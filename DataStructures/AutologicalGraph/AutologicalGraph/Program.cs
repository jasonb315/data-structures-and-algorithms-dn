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
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            // instantiate strand library
            StrandZero s = new StrandZero();
            // instantiate graph
            Graph graph = new Graph();
            // seed graph
            var zero = graph.AddVertex();
            // run seed
            zero.K.Run(s.flower, 0);

            // output
            graph.PrintMatrix();
            graph.PrintEdges();
            Console.WriteLine($"SIZE: {graph.size}");
            graph.PrintVertices();
        }
    }
}

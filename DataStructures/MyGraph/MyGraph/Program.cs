using MyGraph.Classes;
using System;

namespace MyGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGraph<string> graph = new MyGraph<string>();

            var a = graph.AddVertex("a");
            var b = graph.AddVertex("b");
            var c = graph.AddVertex("c");
            var d = graph.AddVertex("d");
            var e = graph.AddVertex("e");
            var f = graph.AddVertex("f");
            var g = graph.AddVertex("g");

            graph.AddUndirectedEdge(a, b, 5);
            graph.AddUndirectedEdge(b, c, 5);
            graph.AddUndirectedEdge(c, d, 5);
            graph.AddUndirectedEdge(d, e, 5);
            graph.AddUndirectedEdge(e, f, 5);
            graph.AddUndirectedEdge(f, g, 5);
            graph.AddUndirectedEdge(g, a, 5);

            graph.Print();

            graph.GetNeighbors(a);

        }
    }
}

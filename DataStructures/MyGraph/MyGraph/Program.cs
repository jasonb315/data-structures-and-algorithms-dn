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

            graph.AddUndirectedEdge(a, b, 5);
            graph.AddUndirectedEdge(b, c, 5);
            graph.AddUndirectedEdge(c, d, 5);
            graph.AddUndirectedEdge(d, a, 5);

            graph.Print();

        }
    }
}

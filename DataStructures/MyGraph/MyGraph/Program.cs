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

            graph.AddDirectedEdge(a, c, 1);
            

            graph.Print();

            //graph.GetNeighborsPointingTo(a);
            //graph.GetNeighborsPointingFrom(a);
            //both run by:
            graph.GetNeighbors(a);


            var j = graph.AddVertex("A");
            var k = graph.AddVertex("B");
            var l = graph.AddVertex("C");
            var m = graph.AddVertex("D");
            var n = graph.AddVertex("E");
            var o = graph.AddVertex("F");

            graph.AddUndirectedEdge(j, k, 5);
            graph.AddUndirectedEdge(k, l, 5);
            graph.AddUndirectedEdge(k, m, 5);
            graph.AddUndirectedEdge(l, n, 5);
            graph.AddUndirectedEdge(l, o, 5);
            graph.AddUndirectedEdge(m, o, 5);

            graph.DepthFirst(j);


        }
    }
}

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
            graph.GetNeighborsDirected(a);

            MyGraph<string> graph1 = new MyGraph<string>();

            var j = graph1.AddVertex("A");
            var k = graph1.AddVertex("B");
            var l = graph1.AddVertex("C");
            var m = graph1.AddVertex("D");
            var n = graph1.AddVertex("E");
            var o = graph1.AddVertex("F");

            graph1.AddUndirectedEdge(j, k, 5);
            graph1.AddUndirectedEdge(k, l, 5);
            graph1.AddUndirectedEdge(k, m, 5);
            graph1.AddUndirectedEdge(l, n, 5);
            graph1.AddUndirectedEdge(l, o, 5);
            graph1.AddUndirectedEdge(m, o, 5);

            graph1.DepthFirst(j);

            MyGraph<string> graph2 = new MyGraph<string>();

            var aa = graph2.AddVertex("aa");
            var bb = graph2.AddVertex("bb");
            var cc = graph2.AddVertex("cc");
            var dd = graph2.AddVertex("dd");

            graph2.AddUndirectedEdge(aa, bb, 5);
            graph2.AddUndirectedEdge(aa, cc, 5);
            graph2.AddUndirectedEdge(aa, dd, 5);

            //graph2.AddUndirectedEdge(bb, cc, 5);
            graph2.AddUndirectedEdge(cc, dd, 5);
            graph2.AddUndirectedEdge(dd, bb, 5);

            Console.WriteLine(graph2.ClusteringCoefficientUndirected(aa));
        }
    }
}

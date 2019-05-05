using MyGraph.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace MyGraphTest
{
    public class UnitTest1
    {
        [Fact]
        public void CreateVert()
        {
            Vertex<string> vert = new Vertex<string>("A");
            Assert.Equal("A", vert.Data);
        }

        [Fact]
        public void CreateEdge()
        {
            Vertex<string> vert = new Vertex<string>("A");
            Edge<string> edge = new Edge<string>();
            edge.Vertex = vert;
            Assert.Equal("A", edge.Vertex.Data.ToString());
        }

        [Fact]
        public void CreateGraph()
        {
            MyGraph<string> graph = new MyGraph<string>();
            Assert.IsType<MyGraph<string>>(graph);
        }

        [Fact]
        public void CreateGraphWithAdjacencyList()
        {
            MyGraph<string> graph = new MyGraph<string>();
            Assert.IsType<Dictionary<Vertex<string>, List<Edge<string>>>>(graph.AdjacencyList);
        }

        [Fact]
        public void GraphCounter()
        {
            MyGraph<string> graph = new MyGraph<string>();
            graph.AddVertex("A");
            Assert.Equal(1, graph._size);
        }

        [Fact]
        public void GraphCounter2()
        {
            MyGraph<string> graph = new MyGraph<string>();
            graph.AddVertex("A");
            graph.AddVertex("A");
            Assert.Equal(2, graph._size);
        }

        [Fact]
        public void AddVert()
        {
            MyGraph<string> graph = new MyGraph<string>();
            graph.AddVertex("123");
            foreach (var pair in graph.AdjacencyList)
            {
                Assert.Equal("123", pair.Key.Data);
            }
        }

        [Fact]
        public void AddDirectedEdge()
        {
            MyGraph<string> graph = new MyGraph<string>();
            Vertex<string> vert1 = new Vertex<string>("A");
            Vertex<string> vert2 = new Vertex<string>("B");
            graph.AdjacencyList.Add(vert1, new List<Edge<string>>());
            graph.AdjacencyList.Add(vert2, new List<Edge<string>>());
            graph.AddDirectedEdge(vert1, vert2, 1);
            Assert.Equal(graph.AdjacencyList[vert1][0].Vertex, vert2);
        }

        [Fact]
        public void AddUndirectedEdge1to2()
        {
            MyGraph<string> graph = new MyGraph<string>();
            Vertex<string> vert1 = new Vertex<string>("A");
            Vertex<string> vert2 = new Vertex<string>("B");
            graph.AdjacencyList.Add(vert1, new List<Edge<string>>());
            graph.AdjacencyList.Add(vert2, new List<Edge<string>>());
            graph.AddUndirectedEdge(vert1, vert2, 1);
            Assert.Equal(graph.AdjacencyList[vert1][0].Vertex, vert2);
        }

        [Fact]
        public void AddUndirectedEdge2to1()
        {
            MyGraph<string> graph = new MyGraph<string>();
            Vertex<string> vert1 = new Vertex<string>("A");
            Vertex<string> vert2 = new Vertex<string>("B");
            graph.AdjacencyList.Add(vert1, new List<Edge<string>>());
            graph.AdjacencyList.Add(vert2, new List<Edge<string>>());
            graph.AddUndirectedEdge(vert1, vert2, 1);
            Assert.Equal(graph.AdjacencyList[vert2][0].Vertex, vert1);
        }

        [Theory]
        [InlineData("A", 0)]
        [InlineData("B", 1)]
        [InlineData("C", 2)]
        public void GetVertices(string a, int b)
        {
            MyGraph<string> graph = new MyGraph<string>();
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            List<Vertex<string>> list = graph.GetVertices();
            Assert.Equal(list[b].Data, a);
        }

        [Fact]
        public void GetNeighbors()
        {
            MyGraph<string> graph = new MyGraph<string>();
            graph.AddVertex("A");
            graph.AddVertex("B");

            Vertex<string> vertRef = null;
            Vertex<string> vertRef2 = null;
            foreach (var pair in graph.AdjacencyList)
            {
                if (pair.Key.Data == "A")
                {
                    vertRef = pair.Key;
                }
                if (pair.Key.Data == "B")
                {
                    vertRef2 = pair.Key;
                }
            }
            graph.AddUndirectedEdge(vertRef, vertRef2, 1);

            foreach (var pair in graph.AdjacencyList)
            {
                if (pair.Key.Data == "A")
                {
                    List<Tuple<Vertex<string>, int>> neighbors = graph.GetNeighbors(pair.Key);
                    Assert.Equal("B", neighbors[0].Item1.Data);
                }
            }
        }
    }
}

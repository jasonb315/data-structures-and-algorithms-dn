using AutoGraph.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace AGTest
{
    public class UnitTest1
    {
        [Fact]
        public void GraphInstantiation()
        {
            Graph graph = new Graph();
            Assert.IsType<Graph>(graph);
        }

        [Fact]
        public void GraphPropAllVertices()
        {
            Graph graph = new Graph();
            Assert.IsType<List<Vertex>>(graph.AllVertices);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(999, 998)]
        public void GraphPropAllVerticesEntry(int a, int b)
        {
            Graph graph = new Graph();
            for (int i = 0; i < a; i++)
            {
                graph.AddVertex();
            }
            Assert.IsType<Vertex>(graph.AllVertices[b]);
        }

        [Fact]
        public void GraphPropMatrix()
        {
            Graph graph = new Graph();
            Assert.IsType<List<List<int>>>(graph.Matrix);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(999, 998)]
        public void GraphPropMatrixEntry(int a, int b)
        {
            Graph graph = new Graph();
            for (int i = 0; i < a; i++)
            {
                graph.AddVertex();
            }
            Assert.Equal(0, graph.Matrix[b][b]);
        }

        [Fact]
        public void GraphPropMatrixKey()
        {
            Graph graph = new Graph();
            Assert.IsType<Dictionary<Guid, int>>(graph.MatrixKey);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(999)]
        public void AddVertexGraphSize(int a)
        {
            Graph graph = new Graph();
            for (int i = 0; i < a; i++)
            {
                graph.AddVertex();
            }
            Assert.Equal(a, graph.size);
        }

        [Fact]
        public void AddVertexGraphKeyEntry()
        {
            Graph graph = new Graph();

            Vertex v = graph.AddVertex();
            
            Assert.Equal(0, graph.MatrixKey[v.ID]);
        }

        [Fact]
        public void AddVertexGraphKeyEntries()
        {
            Graph graph = new Graph();

            Vertex v1 = graph.AddVertex();
            Vertex v2 = graph.AddVertex();

            Assert.Equal(1, graph.MatrixKey[v2.ID]);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 0)]
        public void DirectEdge(int a, int b)
        {
            Graph graph = new Graph();
            Vertex v1 = graph.AddVertex();
            Vertex v2 = graph.AddVertex();
            graph.DirectedEdge(v1, v2, 1);

            Assert.Equal(a, graph.Matrix[a][b]);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 0)]
        public void UndirectEdge(int a, int b)
        {
            Graph graph = new Graph();
            Vertex v1 = graph.AddVertex();
            Vertex v2 = graph.AddVertex();
            graph.UndirectedEdge(v1, v2, 1);

            Assert.Equal(1, graph.Matrix[a][b]);
        }

        [Fact]
        public void OutDegreeCount()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();
            graph.DirectedEdge(A, B, 1);
            graph.DirectedEdge(A, C, 1);
            graph.DirectedEdge(A, D, 1);

            Assert.Equal(3, graph.OutDegreeCount(A));
        }

        [Fact]
        public void OutDegreeCountInvertEdges()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();
            graph.DirectedEdge(B, A, 1);
            graph.DirectedEdge(C, A, 1);
            graph.DirectedEdge(D, A, 1);

            Assert.Equal(0, graph.OutDegreeCount(A));
        }

        [Fact]
        public void OutDegreeVertices()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();
            graph.DirectedEdge(A, B, 1);
            graph.DirectedEdge(A, C, 1);
            graph.DirectedEdge(A, D, 1);

            Assert.Equal(3, graph.OutDegreeVertices(A).Count);
        }

        [Fact]
        public void InDegreeCount()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();
            graph.DirectedEdge(B, A, 1);
            graph.DirectedEdge(C, A, 1);
            graph.DirectedEdge(D, A, 1);

            Assert.Equal(3, graph.InDegreeCount(A));
        }

        [Fact]
        public void InDegreeCountInvertEdges()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();
            graph.DirectedEdge(A, B, 1);
            graph.DirectedEdge(A, C, 1);
            graph.DirectedEdge(A, D, 1);

            Assert.Equal(0, graph.InDegreeCount(A));
        }

        [Fact]
        public void InDegreeVertices()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();
            graph.DirectedEdge(B, A, 1);
            graph.DirectedEdge(C, A, 1);
            graph.DirectedEdge(D, A, 1);

            Assert.Equal(3, graph.InDegreeVertices(A).Count);
        }

        [Fact]
        public void DirectedEdgeCount()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();
            graph.DirectedEdge(B, A, 1);
            graph.DirectedEdge(C, A, 1);
            graph.DirectedEdge(D, A, 1);

            Assert.Equal(3, graph.DirectedEdgeCount(A));
        }

        [Fact]
        public void DirectedEdgeCountOverlap()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();
            graph.UndirectedEdge(B, A, 1);
            graph.UndirectedEdge(C, A, 1);
            graph.UndirectedEdge(D, A, 1);

            Assert.Equal(6, graph.DirectedEdgeCount(A));
        }

        [Fact]
        public void MutualEdgeCount()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();

            graph.DirectedEdge(B, A, 1);
            graph.DirectedEdge(A, C, 1);

            Assert.Equal(0, graph.MutualEdgeCount(A));
        }

        [Fact]
        public void MutualEdgeCountUndirected()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();

            graph.UndirectedEdge(B, A, 1);
            graph.UndirectedEdge(A, C, 1);

            Assert.Equal(2, graph.MutualEdgeCount(A));
        }

        [Fact]
        public void MutualEdgeCountSharedDirected()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();

            graph.DirectedEdge(B, A, 1);
            graph.DirectedEdge(A, B, 2);

            Assert.Equal(1, graph.MutualEdgeCount(A));
        }

        [Theory]
        [InlineData(0, 2)]
        [InlineData(1, 3)]
        public void NeighborCountEdgeVariationA(int a, int b)
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();

            graph.DirectedEdge(B, A, 1);
            graph.DirectedEdge(A, C, 1);
            graph.UndirectedEdge(A, D, a);

            Assert.Equal(b, graph.NeighborCount(A));
        }

        [Theory]
        [InlineData(0, 2)]
        [InlineData(1, 3)]
        public void NeighborCountEdgeVariationB(int a, int b)
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();

            graph.DirectedEdge(B, A, 1);
            graph.DirectedEdge(A, C, a);
            graph.UndirectedEdge(A, D, 1);

            Assert.Equal(b, graph.NeighborCount(A));
        }

        [Theory]
        [InlineData(0, 2)]
        [InlineData(1, 3)]
        public void NeighborCountEdgeVariationC(int a, int b)
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();

            graph.DirectedEdge(B, A, a);
            graph.DirectedEdge(A, C, 1);
            graph.UndirectedEdge(A, D, 1);

            Assert.Equal(b, graph.NeighborCount(A));
        }

        [Fact]
        public void NeighborSet()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();

            graph.DirectedEdge(B, A, 1);
            graph.DirectedEdge(A, C, 1);
            graph.UndirectedEdge(A, D, 1);

            Assert.Equal(3, graph.NeighborSet(A).Count);
        }

        [Fact]
        public void NeighborSetAgainstIsland()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();

            var E = graph.AddVertex();

            graph.DirectedEdge(B, A, 1);
            graph.DirectedEdge(A, C, 1);
            graph.UndirectedEdge(A, D, 1);

            Assert.Equal(3, graph.NeighborSet(A).Count);
        }

        [Theory]
        [InlineData(4, 0, 0, 0, 0)]
        [InlineData(2, 1, 0, 0, 0)]
        [InlineData(1, 1, 1, 0, 0)]
        [InlineData(0, 1, 1, 1, 0)]
        [InlineData(0, 1, 1, 1, 1)]
        public void IslandCount(int a, int b, int c, int d, int e)
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();

            graph.UndirectedEdge(A, B, b);
            graph.UndirectedEdge(B, C, c);
            graph.UndirectedEdge(C, D, d);
            graph.UndirectedEdge(D, A, e);

            Assert.Equal(a, graph.IslandCount());
        }

        [Theory]
        [InlineData(4, 0, 0, 0, 0)]
        [InlineData(2, 1, 0, 0, 0)]
        [InlineData(1, 1, 1, 0, 0)]
        [InlineData(0, 1, 1, 1, 0)]
        [InlineData(0, 1, 1, 1, 1)]
        public void IslandSet(int a, int b, int c, int d, int e)
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();

            graph.UndirectedEdge(A, B, b);
            graph.UndirectedEdge(B, C, c);
            graph.UndirectedEdge(C, D, d);
            graph.UndirectedEdge(D, A, e);

            Assert.Equal(a, graph.IslandSet().Count);
        }

        [Fact]
        public void IslandSetType()
        {
            Graph graph = new Graph();
            Assert.IsType<List<Vertex>>(graph.IslandSet());
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 8)]
        public void NeighborsWithinKChain(int a, int b)
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var A2 = graph.AddVertex();
            var B = graph.AddVertex();
            var B2 = graph.AddVertex();
            var C = graph.AddVertex();
            var C2 = graph.AddVertex();
            var D = graph.AddVertex();
            var D2 = graph.AddVertex();
            var E = graph.AddVertex();
            var E2 = graph.AddVertex();

            graph.UndirectedEdge(A, B, 1);
            graph.UndirectedEdge(B, B2, 1);
            graph.UndirectedEdge(B, C, 1);
            graph.UndirectedEdge(C, C2, 1);
            graph.UndirectedEdge(C, D, 1);
            graph.UndirectedEdge(D, D2, 1);
            graph.UndirectedEdge(D, E, 1);
            graph.UndirectedEdge(E, E2, 1);

            int result = graph.NeighborsWithinK(A, a).Count;

            Assert.Equal(b, result);

        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 4)]
        [InlineData(3, 5)]
        public void NeighborsWithinKChainWithIntermediateCluster(int a, int b)
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();
            var E = graph.AddVertex();
            var F = graph.AddVertex();

            // chain
            graph.UndirectedEdge(A, B, 1);
            graph.UndirectedEdge(B, D, 1);
            graph.UndirectedEdge(D, F, 1);

            // cluster
            graph.UndirectedEdge(B, C, 1);
            graph.UndirectedEdge(B, E, 1);
            graph.UndirectedEdge(C, E, 1);
            graph.UndirectedEdge(D, C, 1);
            graph.UndirectedEdge(D, E, 1);

            int result = graph.NeighborsWithinK(A, a).Count;
            Assert.Equal(b, result);
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(1, 0)]
        [InlineData(4, 6)]
        [InlineData(100, 4950)]
        [InlineData(1000, 499500)]
        public void MaxConnections(int a, int b)
        {
            Graph graph = new Graph();
            int result = graph.MaxConnections(a);
            Assert.Equal(b, result);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 3)]
        [InlineData(4, 6)]
        [InlineData(5, 10)]
        public void FullConnectSet(int a, int b)
        {
            Graph graph = new Graph();
            for (int i = 0; i < a; i++)
            {
                graph.AddVertex();
            }
            int count = graph.FullConnectSet(graph.AllVertices, 1);
            Assert.Equal(b, count);
        }

        [Fact]
        public void MakeSelfRefrences()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            graph.UndirectedEdge(A, A, 1);

            Assert.Equal(1, graph.Matrix[0][0]);
        }

        [Fact]
        public void IsSelfRefrencesTrue()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            graph.UndirectedEdge(A, A, 1);

            Assert.True(graph.IsSelfRefrence(A));
        }

        [Fact]
        public void IsSelfRefrencesFalse()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();

            Assert.False(graph.IsSelfRefrence(A));
        }

        [Fact]
        public void PurgeSelfRefrence()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            graph.UndirectedEdge(A, A, 1);
            graph.PurgeSelfRefrence(A);
            Assert.Equal(0, graph.Matrix[0][0]);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void PurgeSelfRefrencesGlobal(int a)
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            graph.UndirectedEdge(A, A, 1);
            graph.UndirectedEdge(B, B, 1);
            graph.UndirectedEdge(C, C, 1);

            graph.PurgeSelfReferences();

            Assert.Equal(0, graph.Matrix[a][a]);
        }

        [Fact]
        public void ConnectionsBetween()
        {
            Graph graph = new Graph();
            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();
            List<Vertex> set = new List<Vertex> { A, B, C, D };
            graph.FullConnectSet(set, 1);
            int result = graph.ConnectionsBetweenCount(set);
            Assert.Equal(6, result);
        }

        [Fact]
        public void NondirectionalClusteringCoefficientZeroRemoteConnections()
        {
            Graph graph = new Graph();

            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();

            graph.UndirectedEdge(A, B, 1);
            graph.UndirectedEdge(A, C, 1);
            graph.UndirectedEdge(A, D, 1);

            //graph.UndirectedEdge(C, B, 1);
            //graph.UndirectedEdge(B, D, 1);
            //graph.UndirectedEdge(D, C, 1);

            decimal output = graph.NondirectionalClusteringCoefficient(A);
            Assert.Equal(0, Math.Round(output, 2));
        }

        [Fact]
        public void NondirectionalClusteringCoefficientOneRemoteConnections()
        {
            Graph graph = new Graph();

            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();

            graph.UndirectedEdge(A, B, 1);
            graph.UndirectedEdge(A, C, 1);
            graph.UndirectedEdge(A, D, 1);

            graph.UndirectedEdge(C, B, 1);
            //graph.UndirectedEdge(B, D, 1);
            //graph.UndirectedEdge(D, C, 1);

            decimal output = graph.NondirectionalClusteringCoefficient(A);
            Assert.Equal(0.33.ToString(), Math.Round(output, 2).ToString());
        }

        [Fact]
        public void NondirectionalClusteringCoefficientTwoRemoteConnections()
        {
            Graph graph = new Graph();

            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();

            graph.UndirectedEdge(A, B, 1);
            graph.UndirectedEdge(A, C, 1);
            graph.UndirectedEdge(A, D, 1);

            graph.UndirectedEdge(C, B, 1);
            graph.UndirectedEdge(B, D, 1);
            //graph.UndirectedEdge(D, C, 1);

            decimal output = graph.NondirectionalClusteringCoefficient(A);
            Assert.Equal(0.67.ToString(), Math.Round(output, 2).ToString());
        }

        [Fact]
        public void NondirectionalClusteringCoefficientThreeRemoteConnections()
        {
            Graph graph = new Graph();

            var A = graph.AddVertex();
            var B = graph.AddVertex();
            var C = graph.AddVertex();
            var D = graph.AddVertex();

            graph.UndirectedEdge(A, B, 1);
            graph.UndirectedEdge(A, C, 1);
            graph.UndirectedEdge(A, D, 1);

            graph.UndirectedEdge(C, B, 1);
            graph.UndirectedEdge(B, D, 1);
            graph.UndirectedEdge(D, C, 1);

            decimal output = graph.NondirectionalClusteringCoefficient(A);
            Assert.Equal(1.ToString(), Math.Round(output, 2).ToString());
        }
    }
}

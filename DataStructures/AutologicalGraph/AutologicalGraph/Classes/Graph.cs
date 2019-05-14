using AutoGraph.Classes.Kernels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGraph.Classes
{
    public class Graph
    {
        // Informational and action evaluation methods; relationship tracking;
        // sits between Kernal evaluations and vertex behaviors.

        // registry
        public List<Vertex> AllVertices = new List<Vertex>();
        // registry count
        public int size = 0;

        // adjacency matrix
        List<List<int>> Matrix = new List<List<int>>();
        // vertex-guid to matrix position translation
        Dictionary<Guid, int> MatrixKey = new Dictionary<Guid, int>();

        public void PrintMatrix()
        {
            StringBuilder output = new StringBuilder();

            // label
            //output.Append('*', 3).Append(" ADJ MATRIX ").Append('*', 3).Append("\n");
            //output.AppendLine("\n");

            // graph header
            output.Append("XXXXXXXX-GUID-XXXX-XXXX-XXXXXXXXXXXX       ");
            output.Append("[ ");

            // X axis display
            for (int i = 0; i < Matrix.Count; i++)
            {
                output.Append($"{i} ");
                if (i < 10) { output.Append(" "); }
            }
            output.Append("]");
            output.Append("\n");
            output.Append("\n");

            int j = 0; // number for Y axis display

            foreach (var row in Matrix)
            {
                // TODO: add kernal type post row to output for visual association
                output.Append($"{AllVertices[j++].ID}");

                // spacing between vertex index and connection row
                if (j <= 10) { output.Append("  "); }
                else if(j < 100) { output.Append(" "); }
                output.Append($" [{j-1}] ");

                output.Append("[ ");
                foreach (var conn in row)
                {
                    output.Append($"{conn}  ");
                }
                output.Append("]").Append($" -- {AllVertices[j-1].K.GetType()}");
                output.AppendLine("\n");
            }

            Console.WriteLine(output.ToString());
        }

        public void PrintVertices()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < AllVertices.Count; i++)
            {
                output.Append($"V[{i}]:{AllVertices[i].ID} K: {AllVertices[i].K}");
                output.Append("\n");
            }
            Console.WriteLine(output.ToString());
        }

        public void PrintEdges()
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < AllVertices.Count; i++)
            {
                output.Append($"V[{i}]: ");
                for (int j = 0; j < AllVertices.Count; j++)
                {
                    if (Matrix[j][i] != 0)
                    {
                        output.Append($"(V[{j}]:");
                        output.Append($"{Matrix[j][i]}) ");
                    }
                }
                output.Append("\n");
            }
            Console.WriteLine(output.ToString());
        }

        private void RegisterKey(Vertex v)
        {
            MatrixKey.Add(v.ID, size);
        }

        private void MatrixEntry(Vertex v)
        {
            // new row
            List<int> entry = new List<int>();

            // populate row to new matrix width (++prior)
            for (int i=0 ; i<size ; i++) { entry.Add(0); };

            // append entry
            Matrix.Add(entry);

            // new col above new row
            if(size > 1)
            {
                for (int i=0 ; i<Matrix.Count-1 ; i++)
                {
                    Matrix[i].Add(0);
                }
            }
        }

        public int OutDegreeCount(Vertex v)
        {
            int count = 0;
            foreach (var row in Matrix)
            {
                if(row[MatrixKey[v.ID]] != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public List<Vertex> OutDegreeVertices(Vertex v)
        {
            List<Vertex> outVerts = new List<Vertex>();
            int intersection = 0;

            foreach (var row in Matrix)
            {
                if (row[MatrixKey[v.ID]] != 0)
                {
                    outVerts.Add(AllVertices[intersection]);
                }
                intersection++;
            }
            return outVerts;
        }

        public int InDegreeCount(Vertex v)
        {
            int count = 0;
            foreach (var col in Matrix[MatrixKey[v.ID]])
            {
                if(col != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public List<Vertex> InDegreeVertices(Vertex v)
        {
            List<Vertex> inVerts = new List<Vertex>();
            int intersection = 0;

            foreach (var col in Matrix[MatrixKey[v.ID]])
            {
                if (col != 0)
                {
                    inVerts.Add(AllVertices[intersection]);
                }
                intersection++;
            }
            return inVerts;
        }

        public int NeighborEdgeCount(Vertex v)
        {
            return InDegreeCount(v) + OutDegreeCount(v);
        }

        public Vertex AddVertex()
        {
            BaseKernel k = new KernelZero();
            Vertex v = new Vertex(k);
            v.cluster = this;
            k.shell = v;


            // register
            AllVertices.Add(v);
            RegisterKey(v);
            size++;

            // dependent on new size:
            MatrixEntry(v);

            //v.K.Run();

            return v;
        }

        public void DirectedEdge(Vertex pointing, Vertex pointed, int weight)
        {
            // use guid of inputs to grab matrix location
            int p1 = MatrixKey[pointing.ID];
            int p2 = MatrixKey[pointed.ID];
            Matrix[p2][p1] = weight;
        }

        public void UndirectedEdge(Vertex a, Vertex b, int weight)
        {
            DirectedEdge(a, b, weight);
            DirectedEdge(b, a, weight);
        }

        //private int MaxNeighborEdgeCalculation(int tail, int lead, int i)
        //{
        //    if (i == 3) { return lead; }
        //    return MaxNeighborEdgeCalculation(lead, (lead * 2 - tail + 1), i--);
        //}


        // !! Vertex Kernals run Graph methods for Propagation decisions:

        // graph network methods

        // count edges direct
        // count edges mutual symmetrical
        // count edges mutual asymmetrical
        // Assortativity
        // Characteristic path length
        // Effective connectivity
        // Path Length
        // Reachability matrix
        // Dikstras list affinity
        // Prims!! list affinity
        // Floyd
        // Warshall


        // graph vertex methods
        // Centrality
        // Degree
        // Diameter
        // Distance
        // Neighbors
        // Stregnth
        // Clustering coefficient
        // Kernel reassignment
        // Kernel swap?

        // ...
    }
}

// Kernel scripts:
// extend one
// extend two
// extend three
// extend k
// concurrent extension
// extended Kernel type (abstract up?)
// vertex data entry
// fs in out
// 


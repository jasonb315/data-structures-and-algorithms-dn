using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGraph.Classes.Kernels
{
    public class KernelZero : BaseKernel
    {
        public override Vertex shell { get; set; }

        // KERNEL SWITCH
        public override void Run( Dictionary<int, object[]> strand, int step )
        {
            /// record: ~7657 vertices, ~2.5 min: ~51 verts a second.
            // safety = record/2
            if (shell.cluster.AllVertices.Count > 3828) { return; }

            step++;
            // loop termination
            if (!strand.ContainsKey(step)) { return; }


            // extract directive: [0]: Function [{>=1}] Props
            object[] ss = strand[step];

            // select kernel method, pass arguments
            switch (ss[0])
            {
                case "KbranchUndirected":
                    KbranchUndirected(strand, step, Convert.ToInt32(ss[1]), Convert.ToInt32(ss[2]));
                    break;

                case "KcompleteCluster":
                    KcompleteCluster(strand, step, Convert.ToInt32(ss[1]), Convert.ToInt32(ss[2]));
                    break;

                default:
                    break;
            }
        }

        // KERNEL METHODS
        public void KbranchUndirected(Dictionary<int, object[]> strand, int step, int children, int weight)
        {
            for (int i = 0; i < children; i++)
            {
                Vertex v = shell.cluster.AddVertex();
                shell.cluster.UndirectedEdge(shell, v, 1);
                v.K.Run(strand, step);
            }
        }

        public void KcompleteCluster(Dictionary<int, object[]> strand, int step, int children, int weight)
        {
            List<Vertex> batch = new List<Vertex>();
            for (int i = 0; i < children; i++)
            {
                Vertex v = shell.cluster.AddVertex();
                shell.cluster.UndirectedEdge(shell, v, weight);
                batch.Add(v);
                v.K.Run(strand, step);
            }
            shell.cluster.FullConnectSet(batch, weight);
        }
        
    }
}


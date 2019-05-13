using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGraph.Classes.Kernels
{
    public class KernelZero : BaseKernel
    {
        public override Vertex shell { get; set; }

        public override void Run()
        {
            if(shell.cluster.size < 10)
            {
                Vertex newVertex = shell.cluster.AddVertex();
                shell.cluster.UndirectedEdge(newVertex, shell, 5);
            }
        }

        //public override void LifeCycle()
        //{
        //    LifeCycle();
        //}
    }
}

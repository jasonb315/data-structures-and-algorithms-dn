using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGraph.Classes
{
    public class Vertex
    {
        public Guid ID = Guid.NewGuid();
        public BaseKernel K { get; set; }
        public Graph cluster { get; set; }

        public Vertex(BaseKernel k)
        {
            K = k;
        }

        public int GetIndex()
        {
            return cluster.MatrixKey[ID];
        }
    }
}

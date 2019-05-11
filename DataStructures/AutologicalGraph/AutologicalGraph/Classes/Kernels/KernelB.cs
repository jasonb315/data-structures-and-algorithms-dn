using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGraph.Classes.Kernels
{
    public class KernelB : BaseKernel
    {
        public override Vertex Shell { get; set; }

        public override string Propagation()
        {
            return "dataB";
        }
    }
}

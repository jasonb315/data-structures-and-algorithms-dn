using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGraph.Classes.Kernels
{
    public class KernelA : BaseKernel
    {
        public override Vertex shell { get; set; }

        public override void Run()
        {

        }

        public override void LifeCycle()
        {
            LifeCycle();
        }
    }
}

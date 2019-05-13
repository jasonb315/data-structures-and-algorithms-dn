using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGraph.Classes
{
    public class Vertex
    {
        public Guid ID = Guid.NewGuid(); //globally unique identifier
        public BaseKernel K { get; set; }

        // k-way fractal extends uniclass root
        // public object Data { get; set; }

        public Vertex(BaseKernel k)
        {
            K = k;
            K.Run();
        }
    }
}

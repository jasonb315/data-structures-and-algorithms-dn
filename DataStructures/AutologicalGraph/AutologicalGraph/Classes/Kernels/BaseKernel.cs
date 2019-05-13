using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGraph.Classes
{
    // Kernel drives vertex behavior
    abstract public class BaseKernel
    {
        // assigned the Vertex contining this
        public virtual Vertex shell { get; set; }

        // intermediary function for instantiation methods
        public abstract void Run();

        public abstract void LifeCycle();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGraph.Classes
{
    // Kernel drives vertex behavior
    abstract public class BaseKernel
    {
        // assigned the Vertex contining this
        public virtual Vertex Shell { get; set; }

        // expansion methods: conditional to vertex/graph analysis methods

        // the Vertex propagates, the Kernel performs propagation.
        public virtual string Propagation()
        {
            // should 
            return "data";
        }

        public virtual void LifeCycle()
        {
            // relational evaluation of Shell in matrix
                // possibly propagation?
            
            // cessation condition
            LifeCycle();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AutologicalGraph.Classes.Strands
{
    // singleton
    public class Strand
    {
        public Dictionary<int, object[]> flowers = new Dictionary<int, object[]>();

        // FORMAT
        // {strand}.Add(n, new object[] { prop, ... });
        public Strand()
        {
            // flowers
            flowers.Add(1, new object[] { "KbranchUndirected", 1, 1 });
            flowers.Add(2, new object[] { "KbranchUndirected", 1, 1 });
            flowers.Add(3, new object[] { "KbranchUndirected", 1, 1 });
            flowers.Add(4, new object[] { "KbranchUndirected", 1, 1 });
            flowers.Add(5, new object[] { "KcompleteCluster", 5, 7 });
            flowers.Add(6, new object[] { null });
            //flowers.Add(1, new object[] { "KbranchUndirected", 2, 1 });
            //flowers.Add(2, new object[] { "KbranchUndirected", 2, 1 });
            //flowers.Add(3, new object[] { "KbranchUndirected", 2, 1 });
            //flowers.Add(4, new object[] { "KbranchUndirected", 2, 1 });
            //flowers.Add(5, new object[] { "KbranchUndirected", 2, 1 });
            //flowers.Add(6, new object[] { "KbranchUndirected", 1, 1 });
        }
    }
}

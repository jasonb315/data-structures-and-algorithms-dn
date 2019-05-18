using System;
using System.Collections.Generic;
using System.Text;

namespace AutologicalGraph.Classes.Strands
{
    // singleton
    public class StrandZero
    {
        public Dictionary<int, object[]> flower = new Dictionary<int, object[]>();
        //public Dictionary<int, object[]> x = new Dictionary<int, object[]>();

        // FORMAT
        // {strand}.Add(n, new object[] { prop, ... });
        public StrandZero()
        {
            Flower();
        }

        public void Flower()
        {
            int n = 1;
            // flowers
            flower.Add(n, new object[] { "KbranchUndirected", 1, 1 }); n++;
            flower.Add(n, new object[] { "KbranchUndirected", 1, 1 }); n++;
            flower.Add(n, new object[] { "KbranchUndirected", 1, 1 }); n++;
            flower.Add(n, new object[] { "KbranchUndirected", 1, 1 }); n++;
            flower.Add(n, new object[] { "KbranchUndirected", 1, 1 }); n++;
            flower.Add(n, new object[] { "KbranchUndirected", 1, 1 }); n++;
            flower.Add(n, new object[] { "KbranchUndirected", 1, 1 }); n++;
            flower.Add(n, new object[] { "KbranchUndirected", 1, 1 }); n++;
            flower.Add(n, new object[] { "KcompleteCluster", 4, 7 }); n++;
            flower.Add(n, new object[] { null });
        }
    }
}

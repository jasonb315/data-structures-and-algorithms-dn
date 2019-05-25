# Adjacency Matrix

![whiteboard](https://github.com/jasonb315/data-structures-and-algorithms-dn/blob/master/assets/WB00.jpg)

This setup includes an adjacency matrix, in which each Vertex is passed a Kernel that recieves a Strand object to run, which is a Dictionary of actions and peramaters.

```
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
```

The Strand is passed into the Kernel which parses and selects it's method:

```
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
```

The method runs on the Vertex housing the Kernel in terms of the Graph it's inside:

```
public class Vertex
    {
        public Guid ID = Guid.NewGuid();
        public BaseKernel K { get; set; }
        public Graph cluster { get; set; }

        public Vertex(BaseKernel k)
        {
            K = k;
        }
    }
```


Note that each Kernel contains a refrence to it's Vertex shell, and each Vertex contains a refrence to the graph it's inside, so that the process of vertex and edge generation is distributed across Vertices and each Vertex acts based on the entire graph. This qualifies the datastructure as a "holograph", in which each piece contains the whole. So a single seed vertex can generate a shape given the strand:

![seeded run](https://github.com/jasonb315/data-structures-and-algorithms-dn/blob/master/assets/FirstChainRun.JPG)
generated as shown in step five on the lower whiteboard

***

Further itterations of this project are happening in a private repository under [Neuresthetics](https://github.com/Neuresthetics), with corrected and expanded logic for handling patterned cluster generation and stack efficiency.

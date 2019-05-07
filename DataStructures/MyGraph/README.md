------------------------------

# Graph
#### *Author: Jason Burns*

------------------------------

## Description
In mathematics, graph theory is the study of graphs, which are mathematical structures used to model pairwise relations between objects. A graph in this context is made up of vertices -wikipedia

------------------------------

## Methods

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| AddVertex | Adds a Vertex to the graph. | O(1) | O(1) | ```MyGraph.AddVertex("A")``` |
| AddDirectedEdge | Adds a directed edge from the first vertex passed in to the second. | O(1) | O(1) | ```MyGraph.AddDirectedEdge(vert1, vert2, weight)``` |
| AddUndirectedEdge | Adds a mutual connection between two vertices. | O(1) | O(1) | ```MyGraph.AddUndirectedEdge(vert1, vert2, weight)``` |
| GetVertices | Collects a list of the vertices in the graph. | O(n) | O(n) | ```MyGraph.GetVertices()``` |
| InDegree | Reports all the vertices that point to a given vertex. | O(n<sup>2</sup>) | O(n) | ```MyGraph.InDegree(vert1)``` |
| OutDegree | Reports all the vertices that are pointed to from a given vertex. | O(n) | O(n) | ```MyGraph.OutDegree(vert1)``` |
| GetNeighbors | Gathers all connections regardless of direction, from a key vertex. Undirected graphs produce duplicates | O(n) | O(n) | ```MyGraph.GetNeighbors(vert1)``` |
| DepthFirst | Traversal outward from a given Vertex depth first | O(n<sup>2</sup>) | O(n) | ```MyGraph.DepthFirst(vert1)``` |
| Size | Get the quantity of vertices. | O(1) | O(1) | ```MyGraph.Size()``` |
| Print | Prints out the AdjacencyList. | O(n<sup>2</sup>) | O(1) | ```MyGraph.Print()``` |

![Graph](https://github.com/jasonb315/data-structures-and-algorithms-dn/blob/master/assets/GraphNeighbors.JPG) <br>

------------------------------

## Change Log

1.1.0 4MAY2019 Initial publish with base methods

1.1.0 5MAY2019 Neighbor methods added

------------------------------
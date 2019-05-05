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
| AddVertex | Adds a Vertex to the graph. | O(1) | O(1) | MyGraph.AddVertex("A") |
| AddDirectedEdge | Adds a directed edge from the first vertex passed in to the second. | O(1) | O(1) | MyGraph.AddDirectedEdge(vert1, vert2, weight) |
| AddUndirectedEdge | Adds a mutual connection between two vertices. | O(1) | O(1) | MyGraph.AddUndirectedEdge(vert1, vert2, weight) |
| GetVertices | Collects a list of the vertices in the graph. | O(n) | O(n) | MyGraph.GetVertices() |
| GetNeighbors | Reports all the vertices that point to a given vertex. | O(n<sup>2</sup>) | O(n) | MyGraph.GetNeighbors(vert1) |
| Size | Get the quantity of vertices. | O(1) | O(1) | MyGraph.Size() |
| Print | Prints out the AdjacencyList. | O(n<sup>2</sup>) | O(1) | MyGraph.Print()) |

<!-- ![singly_linked_list_0](https://github.com/jasonb315/data-structures-and-algorithms-dn/blob/master/assets/singly_linked_list_0.JPG) <br> -->

------------------------------

## Change Log
1.0.0 25MAR2019 Initial submit

1.1.0 25MAR2019 Node given constructor method

1.1.0 27MAR2019 KthFromEnd

------------------------------


# Binary Tree
#### *Author: Jason Burns*

------------------------------

## About

A binary tree is a tree data structure in which each node has at most two children, which are referred to as the and the. A recursive definition using just set theory notions is that a binary tree is a tuple, where L and R are binary trees or the empty set and S is a singleton set. Some authors allow the binary tree to be the empty set as well.

------------------------------

## Binary Tree

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| PreOrder | PreOrder collection of node data | O(n) | O(n) | tree.PreOrder() |
| InOrder | InOrder collection of node data | O(n) | O(n) | tree.InOrder(oject) |
| PostOrder | PostOrder collection of node data | O(n) | O(n) | tree.PostOrder() |
| BreadthFirst | BreadthFirst list of node data | O(n) | O(n) | tree.BreadthFirst() |
| FindMaxVal | Checks tree for max value given that Data is cast as a numeric type | O(n) | O(1) | tree.FindMaxVal() |

## Binary Search Tree

| Method | Summary | Big O Time | Big O Space | Example | 
| :----------- | :----------- | :-------------: | :-------------: | :----------- |
| Add |  Conditionally places new node in tree based on given ID val | O(log n) | O(1) | tree.Add(x) |
| Contains | conditionally walks down tree checking for value match | O(h) | O(1) | tree.contains(x) |

------------------------------
<!-- ## DEMO -->
<!-- ![singly_linked_list_0](https://github.com/jasonb315/data-structures-and-algorithms-dn/blob/master/assets/singly_linked_list_0.JPG) <br> -->
------------------------------

## Change Log

1.0.0 8APR2019 Initial submit

1.0.1 10APR2019 Readme

1.1.0 11APR2019 FindMaxVal. Fixed merge conflict with previous assignment; regathered to master for next assignment.

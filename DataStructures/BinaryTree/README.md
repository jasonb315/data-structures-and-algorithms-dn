

# Binart Tree
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

1.0.0 10APR2019 Readme
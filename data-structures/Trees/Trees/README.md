# Data Structure Summary
In computer science, a tree is a widely used abstract data type (ADT) that simulates a hierarchical tree structure, with a root value and subtrees of children with a parent node, represented as a set of linked nodes. - Wikipedia

## Data Structure Description
Two classes, Tree and Node classes. The Tree class describes the shape of the tree and includes methods for traversing the data structure. The Node class contains attributes of the individual nodes.

The three methods of traversal contained within are:
- PreOrder: a pre-ordered traversal
- InOrder: an in-ordered traversal
- PostOrder: a post-ordered traversal

## Approach & Efficiency
The approach of each method described are all similar. Each method starts by instantiating a list obejct that the node values will be placed in. Each method then calls upon a separate private helper method by the same name that performs the logic to build out the traversal lists.

The Big O of each method is O(n) because at worst the complexity of each traversal is dictated by the depth of the tree.

## Solution
Version 1.1 - *README added/updated* - 24 Jul 2020
Version 1.0 - *Feature tasks complete, added classes, Tree and Node, made classes generic classes, added methods, PreOrder, InOrder, PostOrder, added UnitTests, UnitTests passing, summary comments added* - 24 Jul 2020
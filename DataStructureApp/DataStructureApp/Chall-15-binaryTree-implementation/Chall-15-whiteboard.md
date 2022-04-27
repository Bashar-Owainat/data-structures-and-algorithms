## problem domain
I have to write an implementation for a binary tree

## Challenge
I was asked to create two classes

1- BinaryTree
2- BinarySearchTree

BinaryTree is a parent of BinarySearchTree

BinaryTree has three methods:

- TraversePreOrder
- TraversePostOrder
- TraverseInOrder 

BinarySearchTree has two methods:

- Add
- Contains

## API

- TraversePreOrder: prints the values in the following order: root => left => right
- TraversePostOrder: prints the values in the following order: left => right => root
- TraverseInOrder: prints the values in the following order: left => root => right

- Add: adds a node to the tree
- Contains: checks if a vlues is in the tree


## Approach & Efficiency

time and space complexity for all Traverse methods is O(n)
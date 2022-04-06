# challenge 7

### Methods for challenge 7

KthFromEnd


### tests for challenge 7

KOutOfRange : it tests what will happen if the user inputs number that is greater than the linked list’s length.(it will throw IndexOutOfRange)

SameNumbers: it tests what will happen if “K” (the user’s input) has the same length as the linked lists.

NegativeNumbers: it tests if K is a negative number.

OneNumber: it tests what will happen if linked list has one number only.

NumberInMiddle: it tests the behavior of the method when K is in the middle of the linked list. 

### Approach & Efficiency for Challenge 7

KthFromEnd = O(n)


### API for Challenge 7

KthFromEnd: a method that takes an integer as a parameter and uses this number to start counting from the end of the linked list to give you the value in that index.

Note:
-	It starts counting from 1 not zero
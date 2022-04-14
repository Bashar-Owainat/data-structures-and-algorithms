# PseudoQueue

## Summary
I did an implementation for a queue using two stacks



## Description

I created three methods:

- Enqueue 
- Dequeue
- Peek

I created three tests:

- TestEnqueue: it tests if the Enqueue method inserts properly 
- TestDequeue: it tests if the Dequeue method removes properly 
- PeekAnEmptyQueue: it tests if the peek method raises an exception if we peek an 
empty queue 

## Approach & Efficiency

Enqueue: time complexity  = O(n),  space complexity = O(n)

Dequeue: time complexity = O(1),  space complexity = O(1)

## API

- Enqueue: in each time we want to enqueue a value to the queue 
it moves all the values from stack one to stack two and then it pushes 
the vlaue in stack one and finally it moves the values back from stack two
to stack one.

- Dequeue: it checks if stack one is empty and if it's not it pop the top value 
which is the first one that has entered.



# Data Structure Summary
The purpose of this data structure is to practice creating Stacks and Queues through a library and running UnitTests to check if the methods are sound. A stack is a data structure that consists of Nodes. Each Node references the next Node in the stack, but does not reference its previous, and follos the concepts of First in Last out. A queue follows the same logic as a stack but follows the concepts of First in First out and Last in Last out.

## Data Structure Description
The following methods are used to test these stack and queue classes:

### Stack:
- Push: takes in any value and adds a new Node with that value to the top of the stack
- Pop: removes the Node from the top of the stack and returns its value
- Peek: returns the value of the node located on top of the stack if it exists
- IsEmpty: returns a boolean indicating whether or not the stack is empty

### Queue:
- Enqueue: takes and value and adds a new node with that value as an argument to the back of the queue
- Dequeue: removes the node from the front of the queue and returns the node's value if it exists
- Peek: returns the value of the node located in the front of the queue if it exists
- IsEmpty: returns a boolean indicating whether or not the queue is empty


## Approach & Efficiency
The approach was to define all of the classes and methods within and then run unit tests over the Library to make sure the logic was sound.

- Push: O(1) efficiency because no matter what the same basic actions will repeat
- Pop: O(1) efficiency because no matter what the same basic actions will repeat
- Peek: O(1) efficiency because no matter what the same basic actions will repeat
- IsEmpty: O(1) efficiency because no matter what the same basic actions will repeat
- Enqueue: O(1) efficiency because no matter what the same basic actions will repeat
- Dequeue: O(1) efficiency because no matter what the same basic actions will repeat

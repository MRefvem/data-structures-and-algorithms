# Graphs
In computer science, a graph is an abstract data type that is meant to implement the undirected graph and directed graph concepts from the field of graph theory within mathematics.
A graph data structure consists of a finite (and possibly mutable) set of vertices (also called nodes or points), together with a set of unordered pairs of these vertices for an undirected graph or a set of ordered pairs for a directed graph. These pairs are known as edges (also called links or lines), and for a directed graph are also known as arrows. The vertices may be part of the graph structure, or may be external entities represented by integer indices or references.
A graph data structure may also associate to each edge some edge value, such as a symbolic label or a numeric attribute (cost, capacity, length, etc.).
In computer science, graph traversal (also known as graph search) refers to the process of visiting (checking and/or updating) each vertex in a graph. Such traversals are classified by the order in which the vertices are visited. Tree traversal is a special case of graph traversal.

## Challenge
Implement your own Graph. The graph should be represented as an adjacency list, and should include he following methods:
1. AddVertex()
2. AddEdge()
3. GetVertices()
4. GetNeighbors()
5. Size()

## Structure and Testing
1. Vertex can be successfully added to the graph
2. An edge can be successfully added to the graph
3. A collection of all nodes can be properly retrieved from the graph
4. All appropriate neighbors can be retrieved from the graph
5. Neighbors are returned with the weight between nodes included
6. The proper size is returned, representing the number of nodes in the graph
7. A graph with only one vertex and edge can be properly returned
8. An empty graph returns null

## API
There are five internal public methods in this Data Structure:
1. AddVertex()
- Adds a new vertex to the graph
- Takes in the value of that node
- Returns the added node
2. AddEdge()
- Adds a new edge between to nodes in the graph
- Include the ability to have a "weight"
- Takes in the two nodes to be connected by the edge
- Both nodes should already be in the Graph
3. GetVertices()
- Returns all of the vertices in the graph as a collection (set, list, or similar)
4. GetNeighbors()
- Returns a collection of edges connected to the given vertex
- Takes in a given vertex
- Include the weight of the connection in the returned collection
5. Size()
- Returns the total number of vertices in the graph

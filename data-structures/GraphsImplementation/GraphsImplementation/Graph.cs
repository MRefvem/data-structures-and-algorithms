using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GraphsImplementation
{
    public class Graph<T, W>
    {
        // Adjacency List
        public Dictionary<Vertex<T>,List<Edge<T, W>>> AdjacencyList { get; set; }
        private int _size = 0;

        public Graph()
        {
            // We have to allocate memory on the heap for the collection
            // Null reference if we don't
            AdjacencyList = new Dictionary<Vertex<T>, List<Edge<T, W>>>();
        }

        // Add vertex/node
        public Vertex<T> AddVertex(T value)
        {
            Vertex<T> vertex = new Vertex<T>(value);
            AdjacencyList.Add(vertex, new List<Edge<T, W>>());
            _size++;

            return vertex;
        }

        // Add directed edge
        public void AddDirectedEdge(Vertex<T> a, Vertex<T> b, W weight)
        {
            // add this 
            Edge<T, W> edge = new Edge<T, W>
            {
                Vertex = b,
                Weight = weight
            };

            AdjacencyList[a].Add(edge);
        }

        public void AddUndirectedEdge(Vertex<T> a, Vertex<T> b, W weight)
        {
            AddDirectedEdge(a, b, weight);
            AddDirectedEdge(b, a, weight);
        }

        public List<Edge<T, W>> GetNeighbors(Vertex<T> vertex)
        {
            return AdjacencyList[vertex];
        }

        // get a single vertex
        public Vertex<T> GetVertex(T value)
        {
            // traverse over our adjacency list and see if the value exists
            // make the return type a list if looking for multiple values

            foreach (var vertex in AdjacencyList)
            {
                if (vertex.Key.Value.Equals(value))
                {
                    return vertex.Key;
                }
            }

            return null;
        }

        public List<Vertex<T>> GetAllVertices()
        {
            List<Vertex<T>> vertices = new List<Vertex<T>>();
            foreach (var vertex in AdjacencyList)
            {
                vertices.Add(vertex.Key);

            }
            return vertices;
        }

        public int Size()
        {
            return _size;
        }

        public void Print()
        {
            foreach (var item in AdjacencyList)
            {
                Console.WriteLine($"Vertex {item.Key.Value} ->");
                foreach (var edge in item.Value)
                {
                    Console.WriteLine($"{edge.Vertex.Value}, {edge.Weight}");
                }

            }
        }
    }
}

using LinkedListImplementation;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Hashtable
{
    public class HashTable<T>
    {

        public LinkedList<LinkedListNode<Node<T>>>[] Map { get; set; }

        public HashTable(int size)
        {
            Map = new LinkedList<LinkedListNode<Node<T>>>[size];
        }

        /// <summary>
        /// GetHash - Computes a hash integer from a given key value
        /// </summary>
        /// Node: Normally this method is private but it is set to public for the purposes of being able to run tests
        /// <param name="key">the given key to hash</param>
        /// <returns>index of the array placement</returns>
        public int GetHash(string key)
        {
            // Determine our algorithm for our hash
            // a string is a list of char
            // a char is a numeric value (ASCII)

            int total = 0;
            for (int i = 0; i < key.Length; i++)
            {
                total += key[i];
            }

            int primeValue = total * 599;

            int index = primeValue % Map.Length;

            return index;
        }

        /// <summary>
        /// Add - takes in both the key and value. This method hashes the key and then adds the key and value pair to the table, handling collisions as needed
        /// </summary>
        /// <param name="key">the given key to hash</param>
        /// <param name="value">the value of the pair</param>
        public void Add(string key, T value)
        {
            int index = GetHash(key);
            Node<T> htNode = new Node<T>(key, value);
            LinkedListNode<Node<T>> node = new LinkedListNode<Node<T>>(htNode);
            
            if (Map[index] is null)
            {
                // instantiates a new linked list
                Map[index] = new LinkedList<LinkedListNode<Node<T>>>();
                Map[index].AddFirst(node);
            }
            Map[index].AddLast(node);
        }

        /// <summary>
        /// Get - takes in the key and returns the value from the table
        /// </summary>
        /// <param name="key">the key of the value we want to locate</param>
        /// <returns>the value of the key passed in</returns>
        public T Get(string key)
        {
            int index = GetHash(key);
            if (!(Map[index] is null))
            {
                if (Map[index].Count == 1)
                {
                    var first = Map[index].First;
                    // {LinkedListNode} {HashTableNode Value} {Property}
                    return first.Value.Value.Value;
                }
                else
                {
                    var current = Map[index].First;
                    while (current != null)
                    {
                        if (current.Value.Value.Key == key)
                        {
                            return current.Value.Value.Value;
                        }
                        current = current.Next;
                    }
                }
            }
            return default;
        }

        /// <summary>
        /// Contains - takes in the key and returns a boolean, indicating if the key exists in the table already
        /// </summary>
        /// <param name="key">the key of the value we want to see is contained</param>
        /// <returns>a boolean representing true for the presence of the object search or false for the opposite</returns>
        public bool Contains(string key)
        {
            int index = GetHash(key);

            var location = Map[index];

            if (!(location is null))
            {
                var current = Map[index].First;
                while (current != null)
                {
                    if (current.Value.Value.Key == key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
      
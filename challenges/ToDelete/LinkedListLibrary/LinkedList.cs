using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Transactions;

namespace LinkedListLibrary
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public Node Current { get; set; }

        public LinkedList()
        {
            Head = null;
            Current = Head;
        }

        /// <summary>
        /// Inserts a new node with an 0(1) operation into linkedlist
        /// </summary>
        /// <param name="value">value to be stored in the node</param>
        public void Insert(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Finds a specific value in the linked list
        /// O(n) time efficiency
        /// </summary>
        /// <param name="value">searchable value</param>
        /// <returns>response if it exists</returns>
        public bool Includes(int value)
        {
            Current = Head;
            // While loop
            // traverse the linked list and do the comparison
            while (Current != null)
            {
                // check if its equal to the given value
                if (Current.Value == value)
                {
                    return true;
                }

                // move to the next one
                Current = Current.Next;

            }

            return false;
        }

        /// <summary>
        /// Overriding current behavior of to string method to output all values in the linked list as a string
        /// </summary>
        /// <returns>a string containing all the values of the linked list</returns>
        public override string ToString()
        {
            Current = Head;
            // Use StringBuilder class
            // why would you use StringBuilder over concatination

            StringBuilder sb = new StringBuilder();

            // start constructing sb
            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;
            }

            sb.Append("NULL");

            return sb.ToString();
        }
    }
}

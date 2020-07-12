using System;
using System.Text;

namespace LinkedListImplementation
{
    public class LinkedLists
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LinkedLists()
        {
            Head = null;
            Current = Head;
        }

        /// <summary>
        /// Inserts a new node with an O(1) operation into linkedlist
        /// </summary>
        /// <param name="value">value to be stored in the node</param>
        public void Insert(int value)
        {
            Current = Head;
            // create the new node that needs to be added
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
                // check if it's equal to the given value
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
        /// Overriding current behavior of tostring method to output all values in the linked list as a string
        /// </summary>
        /// <returns>a string containing all the values of the linked list</returns>
        public override string ToString()
        {
            Current = Head;
            // StringBuilder class/
            // why would you use Stringbuilder over string concatination?
            // because it allocates less memory!!

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

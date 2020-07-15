using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        /// <summary>
        /// Takes in a value and appends it as the final node of the list
        /// </summary>
        /// <param name="value">the int we want to append to the end</param>
        public void AppendNewNode(int value)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current.Next == null)
                {
                    Current.Next = new Node(value);
                    break;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Method assesses the value of a node, locates its position and inserts a new value BEFORE that position
        /// </summary>
        /// <param name="value">Value of the node we're looking for in the list</param>
        /// <param name="newVal">Value of the node we're creating to insert before</param>
        public void InsertBefore(int value, int newVal)
        {
            Current = Head;
            // add an edge case exception
            if (Current.Value == value)
            {
                // insert before
                Node temp = Current;
                Current = new Node(newVal);
                Current.Next = temp;
                Head = Current;
                return;
            }
            // The way you traverse linkedlist is by using while loops
            while (Current.Next != null)
            {
                if (Current.Next.Value == value)
                {
                    // insert before
                    Node temp = Current;
                    Current = new Node(newVal);
                    Current.Next = temp.Next;
                    temp.Next = Current;
                    break;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Method assesses the value of a node, locates its position and inserts a new value AFTER that position
        /// </summary>
        /// </summary>
        /// <param name="value">Value of the node we are locating in the list</param>
        /// <param name="newVal">Value of the node we're creating to insert after the previous value</param>
        public void InsertAfter(int value, int newVal)
        {
            Current = Head;
            while (Current != null)
            {
                if (Current.Value == value)
                {
                    // insert after
                    Node newNode = new Node(newVal);
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    break;
                }
                Current = Current.Next;
            }
        }

        public int FindKthFromTheEnd(int key)
        {
            if (key < 0)
            {
                throw new Exception("K is invalid");
            }
            
            // Create 2 references
            Node walker = Head;
            Node runner = Head;

            // runner to iterate k number of positions within linked list
            int k = key;
            while (k > 0)
            {
                if (runner.Next != null)
                {
                    k--;
                    runner = runner.Next;
                }
                else
                {
                    throw new Exception("K is invalid");
                }
            }

            while (runner.Next != null)
            {
                walker = walker.Next;
                runner = runner.Next;
            }

            return walker.Value;

        }
    }
}

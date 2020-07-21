using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Push Method - takes in a string as an argument and adds a new node with that value to the top of the stack with an O(1) Time performance
        /// </summary>
        /// <param name="value">the string value you want to insert into the stack</param>
        public void Push(string value)
        {
            // Create a new node
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Pop Method - removes the node from the top of the stack and returns the node's value. Raises and exception when called on an empty stack
        /// </summary>
        /// <returns>value of the node that was removed from the stack</returns>
        public string Pop()
        {
            if (Top != null)
            {
                Node temp = Top;
                Top = Top.Next;
                temp.Next = null;
                return temp.Value;
            }
            else
            {
                throw new Exception("Top is null");
            }
        }

        /// <summary>
        /// Peek Method - returns the value of the node located on top of the stack, without removing it from the stack
        /// </summary>
        /// <returns>the value of the node at the top of the stack if it exists</returns>
        public string Peek()
        {
            if (Top != null)
            {
                return Top.Value;
            }
            else
            {
                throw new Exception("Top is null");
            }
        }

        /// <summary>
        /// IsEmpty Method - returns a boolean indicating whether or not the stack is empty
        /// </summary>
        /// <returns> a boolean</returns>
        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

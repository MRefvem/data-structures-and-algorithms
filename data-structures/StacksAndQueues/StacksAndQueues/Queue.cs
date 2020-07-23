using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues
{
    public class Queue<T>
    {
        private Node<T> Front { get; set; }
        private Node<T> Rear { get; set; }

        public Queue()
        {
            Rear = Front;
        }

        /// <summary>
        /// Enqueue Method - takes in a string as an argument and adds a new node with that value to the front of the queue with an O(1) Time performance
        /// </summary>
        /// <param name="value">the string value you want to insert into the queue</param>
        public void Enqueue(T value)
        {
            // Create a new node
            Node<T> node = new Node<T>(value);

            if (Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }
        }

        /// <summary>
        /// Dequeue Method - removes the node from the front of the queue and returns the node's value. Raises and exception when called on an empty queue
        /// </summary>
        /// <returns>value of the node that was removed from the queue/returns>
        public T Dequeue()
        {
            if (Front != null)
            {
                Node<T> temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp.Value;
            }
            else
            {
                throw new Exception("Front is null");
            }
        }

        /// <summary>
        /// Peek Method - returns the value of the node located on front of the queue, without removing it from the queue
        /// </summary>
        /// <returns>the value of the node at the front of the queue if it exists</returns>
        public T Peek()
        {
            if (Front != null)
            {
                return Front.Value;
            }
            else
            {
                throw new Exception("Front is null");
            }
        }

        /// <summary>
        /// IsEmpty Method - returns a boolean indicating whether or not the queue is empty
        /// </summary>
        /// <returns> a boolean</returns>
        public bool IsEmpty()
        {
            if (Front == null)
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

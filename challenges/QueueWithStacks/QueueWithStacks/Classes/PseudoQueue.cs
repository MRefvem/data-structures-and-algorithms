using System;
using System.Threading;
using StacksAndQueues;

namespace QueueWithStacks
{
    public class PseudoQueue
    {
        private Stack StackOne { get; set; }
        private Stack StackTwo { get; set; }
        private int Count { get; set; }

        public PseudoQueue()
        {
            StackOne = new Stack();
            StackTwo = new Stack();
            Count = 0;
        }

        /// <summary>
        /// Enqueue method
        /// </summary>
        /// <param name="value">The value of which we are trying to "enqueue"</param>
        public void Enqueue(string value)
        {
            AlternateNodes();

            if (Count % 2 != 0)
            {
                StackOne.Push(value);
            }
            else
            {
                StackTwo.Push(value);
            }
            Count++;

        }

        /// <summary>
        /// Helper method
        /// </summary>
        private void AlternateNodes()
        {
            int depth = Count;
            bool even = Count % 2 == 0;
            Stack tempStack = new Stack();
            for (int i = 0; i < depth; i++)
            {
                if (even)
                {
                    tempStack.Push(StackTwo.Pop());
                }
                else
                {
                    tempStack.Push(StackOne.Pop());
                }
            }
            for (int j = 0; j < depth; j++)
            {
                if (even)
                {
                    StackOne.Push(tempStack.Pop());
                }
                else
                {
                    StackTwo.Push(tempStack.Pop());
                }
            }
        }

        /// <summary>
        /// Dequeue method
        /// </summary>
        /// <returns>string of returned node</returns>
        public string Dequeue()
        {
            try
            {
                if (Count % 2 == 0)
                {
                    return StackOne.Pop();
                }
                else
                {
                    return StackTwo.Pop();
                }
            }
            catch (NullReferenceException e)
            {
                throw new Exception("");
            }

        }

    }
}

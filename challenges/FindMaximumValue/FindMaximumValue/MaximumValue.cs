using System;
using Trees;

namespace FindMaximumValue
{
    public class MaximumValue
    {
        public Node<int> Root { get; set; }

        public MaximumValue()
        {

        }

        public MaximumValue(int value)
        {
            Node<int> root = new Node<int>(value);
            Root = root;
        }

        public int MaxValueOfTree(Node<int> root)
        {
            Node<int> maxValue = new Node<int>(0);

            // call the PreOrder method from Trees dll to traverse this list and reassign the value of maxValue to the value of the biggest Node using an if statement


            return maxValue.Value;

        }

    }
}

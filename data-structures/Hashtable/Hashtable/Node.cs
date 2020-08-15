using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable
{
    public class Node<T>
    {
        public string Key { get; set; }
        public T Value { get; set; }

        public Node(string key, T value)
        {
            Key = key;
            Value = value;
        }
    }
}

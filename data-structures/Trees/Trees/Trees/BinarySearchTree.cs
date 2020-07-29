using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class BinarySearchTree<T>
    {
        public Node<int> Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public BinarySearchTree(int value)
        {
            Node<int> root = new Node<int>(value);
            Root = root;
        }

        public void Add(int value)
        {
            Node<int> root = Root;
            Node<int> temp = Root;
            Node<int> newNode = new Node<int>(value);

            if (root == null)
            {
                Root = newNode;
            }
            else
            {
                // need a way to travel down the binary tree and move the position of temp
                while (temp != null)
                {
              
                    if (newNode.Value <= temp.Value)
                    {
                        if (temp.LeftChild == null)
                        {
                            temp.LeftChild = newNode;
                            break;
                        }
                        else
                        {
                            temp = temp.LeftChild;
                        }
                    }
                    else if (newNode.Value > temp.Value)
                    {
                        if (temp.RightChild == null)
                        {
                            temp.RightChild = newNode;
                            break;
                        }
                        else
                        {
                            temp = temp.RightChild;
                        }
                    }
                }
            }

            
        }

        public bool Contains(int value)
        {
            Node<int> root = Root;
            Node<int> temp = Root;
            Node<int> newNode = new Node<int>(value);

            if (root == null)
            {
                throw new Exception("Node does not exist");
            }

            // need a way to travel down the binary tree and check if value is in tree
            while (temp != null)
            {
                if (newNode.Value == temp.Value)
                {
                    return true;
                }
                else
                {
                    if (newNode.Value < temp.Value)
                    {
                        temp = temp.LeftChild;
                    }
                    else if (newNode.Value > temp.Value)
                    {
                        temp = temp.RightChild;
                    }
                }
            }

            return false;

        }
    }
}

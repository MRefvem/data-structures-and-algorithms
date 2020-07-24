using System;
using System.Collections.Generic;

namespace Trees
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree()
        {

        }

        public Tree(T value)
        {
            Node<T> root = new Node<T>(value);
            Root = root;
        }

        /// <summary>
        /// Public PreOrder - Returns the pre-ordered values of each node in a list
        /// </summary>
        /// <param name="root">The root of the tree passed in</param>
        /// <returns>The list of traversed pre-ordered values</returns>
        public List<T> PreOrder(Node<T> root)
        {
            // Conduct a preorder traversal
            // Capture each of the values in a list
            // Return that list

            List<T> traversal = new List<T>();
            PreOrder(traversal, root);
            return traversal;
        }

        /// <summary>
        /// Private PreOrder - Traverses a binary tree and performs the pre-order logic that decides when to insert into the traversal list
        /// </summary>
        /// <param name="traversal">The list we want to add pre-ordered values to</param>
        /// <param name="root">The root value of the tree</param>
        private void PreOrder(List<T> traversal, Node<T> root)
        {
            traversal.Add(root.Value);

            if (root.LeftChild != null)
            {
                PreOrder(traversal, root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PreOrder(traversal, root.RightChild);
            }
        }

        /// <summary>
        /// Public InOrder - Returns the in-ordered values of each node in a list
        /// </summary>
        /// <param name="root">The root of the tree passed in</param>
        /// <returns>The list of traversed in-ordered values</returns>
        public List<T> InOrder(Node<T> root)
        {
            // Conduct an inorder traversal
            // Capture each of the values in a list
            // Return that list

            List<T> traversal = new List<T>();
            InOrder(traversal, root);
            return traversal;
        }

        /// <summary>
        /// Private InOrder - Traverses a binary tree and performs the in-order logic that decides when to insert into the traversal list
        /// </summary>
        /// <param name="traversal">The list we want to add in-ordered values to</param>
        /// <param name="root">The root value of the tree</param>
        private void InOrder(List<T> traversal, Node<T> root)
        {
            if (root.LeftChild != null)
            {
                InOrder(traversal, root.LeftChild);
            }

            traversal.Add(root.Value);
            
            if (root.RightChild != null)
            {
                InOrder(traversal, root.RightChild);
            }
        }

        /// <summary>
        /// Public PostOrder - Returns the post-ordered values of each node in a list
        /// </summary>
        /// <param name="root">The root of the tree passed in</param>
        /// <returns>The list of traversed post-ordered values</returns>
        public List<T> PostOrder(Node<T> root)
        {
            // Conduct a postorder traversal
            // Capture each of the values in a list
            // Return that list

            List<T> traversal = new List<T>();
            PostOrder(traversal, root);
            return traversal;
        }

        /// <summary>
        /// Private PostOrder - Traverses a binary tree and performs the post-order logic that decides when to insert into the traversal list
        /// </summary>
        /// <param name="traversal">The list we want to add post-ordered values to</param>
        /// <param name="root">The root value of the tree</param>
        private void PostOrder(List<T> traversal, Node<T> root)
        {
            if (root.LeftChild != null)
            {
                PostOrder(traversal, root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PostOrder(traversal, root.RightChild);
            }

            traversal.Add(root.Value);
        }
    }
}

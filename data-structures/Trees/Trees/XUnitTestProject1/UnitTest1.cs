using System;
using System.Collections.Generic;
using Trees;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateAnEmptyTree()
        {
            // Arrange & Act
            Tree<string> tree = new Tree<string>();

            // Assert
            Assert.Null(tree.Root);
        }

        [Fact]
        public void CanInstantiateTreeWithSingleRoot()
        {
            // Arrange & Act
            Tree<string> stump = new Tree<string>("Mai Tai");

            // Assert
            Assert.NotNull(stump.Root);
            Assert.Equal("Mai Tai", stump.Root.Value);
            Assert.IsType<Node<string>>(stump.Root);
        }

        [Fact]
        public void CanAddLeftAndRightToRoot()
        {
            // Arrange
            Tree<char> tree = new Tree<char>('a');

            Node<char> leftChild = new Node<char>('b');
            Node<char> rightChild = new Node<char>('c');

            // Act
            tree.Root.LeftChild = leftChild;
            tree.Root.RightChild = rightChild;

            // Assert
            Assert.NotNull(tree.Root.LeftChild);
            Assert.NotNull(tree.Root.RightChild);
            Assert.Equal('b', tree.Root.LeftChild.Value);
            Assert.Equal('c', tree.Root.RightChild.Value);
        }

        [Fact]
        public void CanReturnPreOrderTraversal()
        {
            // Arrange
            Tree<char> tree = new Tree<char>();

            Node<char> root = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            List<char> order = new List<char>()
            {
                'a', 'b', 'd', 'e', 'c', 'f', 'g'
            };

            // Act
            List<char> preOrder = tree.PreOrder(tree.Root);

            // Assert
            Assert.Equal(order, preOrder);
        }

        [Fact]
        public void CanReturnInOrderTraversal()
        {
            // Arrange
            Tree<char> tree = new Tree<char>();

            Node<char> root = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            List<char> order = new List<char>()
            {
                'd', 'b', 'e', 'a', 'f', 'c', 'g'
            };

            // Act
            List<char> inOrder = tree.InOrder(tree.Root);

            // Assert
            Assert.Equal(order, inOrder);

        }

        [Fact]
        public void CanReturnPostOrderTraversal()
        {
            // Arrange
            Tree<char> tree = new Tree<char>();

            Node<char> root = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            List<char> order = new List<char>()
            {
                'd', 'e', 'b', 'f', 'g', 'c', 'a'
            };

            // Act
            List<char> postOrder = tree.PostOrder(tree.Root);

            // Assert
            Assert.Equal(order, postOrder);

        }
    }
}

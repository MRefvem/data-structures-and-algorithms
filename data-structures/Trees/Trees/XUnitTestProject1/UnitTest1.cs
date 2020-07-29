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

        [Fact]
        public void CanAddToBinarySearchTree()
        {
            // Arrange

            BinarySearchTree<int> binaryTree = new BinarySearchTree<int>();

            Node<int> root = new Node<int>(100);
            Node<int> b = new Node<int>(50);
            Node<int> c = new Node<int>(150);
            Node<int> d = new Node<int>(25);
            Node<int> e = new Node<int>(75);
            Node<int> f = new Node<int>(125);
            Node<int> g = new Node<int>(175);

            binaryTree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            // Act

            binaryTree.Add(110);
            binaryTree.Add(45);

            // Assert

            Assert.Equal(110, f.LeftChild.Value);
            Assert.Equal(45, d.RightChild.Value);

        }

        [Fact]
        public void CanSeeIfValueIsContained()
        {
            // Arrange

            BinarySearchTree<int> binaryTree = new BinarySearchTree<int>();

            binaryTree.Add(100);
            binaryTree.Add(50);
            binaryTree.Add(150);
            binaryTree.Add(25);
            binaryTree.Add(75);
            binaryTree.Add(125);
            binaryTree.Add(175);

            // Act

            var result = binaryTree.Contains(125);
            var result2 = binaryTree.Contains(25);
            var result3 = binaryTree.Contains(30);
            var result4 = binaryTree.Contains(0);
            var result5 = binaryTree.Contains(100);

            // Assert

            Assert.True(result);
            Assert.True(result2);
            Assert.False(result3);
            Assert.False(result4);
            Assert.True(result5);

        }

        [Fact]
        public void CanFindMaximumValueOfTree()
        {
            // Arrange
            Tree<int> tree = new Tree<int>();

            Node<int> root = new Node<int>(2);
            Node<int> b = new Node<int>(7);
            Node<int> c = new Node<int>(5);
            Node<int> d = new Node<int>(2);
            Node<int> e = new Node<int>(6);
            Node<int> f = new Node<int>(9);
            Node<int> g = new Node<int>(5);
            Node<int> h = new Node<int>(11);
            Node<int> i = new Node<int>(4);

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.RightChild = f;

            e.LeftChild = g;
            e.RightChild = h;

            f.LeftChild = i;

            // Act

            int maxValue = tree.MaxValueOfTree(tree.Root);

            // Assert

            Assert.NotEqual(2, maxValue);
            Assert.NotEqual(4, maxValue);
            Assert.NotEqual(5, maxValue);
            Assert.NotEqual(6, maxValue);
            Assert.NotEqual(7, maxValue);
            Assert.NotEqual(9, maxValue);
            Assert.Equal(11, maxValue);

        }

        [Fact]
        public void CanFindMaximumValueOfTree2()
        {
            // Arrange
            Tree<int> tree = new Tree<int>();

            Node<int> root = new Node<int>(23);
            Node<int> b = new Node<int>(79);
            Node<int> c = new Node<int>(53);
            Node<int> d = new Node<int>(25);
            Node<int> e = new Node<int>(61);
            Node<int> f = new Node<int>(90);
            Node<int> g = new Node<int>(5);
            Node<int> h = new Node<int>(11);
            Node<int> i = new Node<int>(44);

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.RightChild = f;

            e.LeftChild = g;
            e.RightChild = h;

            f.LeftChild = i;

            // Act

            int maxValue = tree.MaxValueOfTree(tree.Root);

            // Assert

            Assert.NotEqual(23, maxValue);
            Assert.NotEqual(79, maxValue);
            Assert.NotEqual(53, maxValue);
            Assert.NotEqual(25, maxValue);
            Assert.NotEqual(61, maxValue);
            Assert.Equal(90, maxValue);
            Assert.NotEqual(5, maxValue);
            Assert.NotEqual(11, maxValue);
            Assert.NotEqual(44, maxValue);

        }
    }
}

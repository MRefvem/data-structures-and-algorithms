using System;
using Xunit;
using LinkedListLibrary;
using System.Collections.Generic;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkedList list = new LinkedList();
            Assert.Null(list.head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            // insert means add to the front
            //  Arrange
            LinkedList list = new LinkedList()
            Node node = new Node();



        }

        [Fact]
        public void CanInsertMultipleNodesIntoLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            Assert.Equal(42, list.Head.Value);
        }

        [Fact]
        public void CanFindValueIntList()
        {
            // Arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            int searchForValue = 15;
            bool exists = list.Includes(searchForValue);

            // Assert
            Assert.True(exists);
        }

        [Fact]
        public void CannotFindValueIntList()
        {
            // Arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            int searchForValue = 100;
            bool exists = list.Includes(searchForValue);

            // Assert
            Assert.False(exists);
        }

        [Fact]
        public void CanReturnAllValuesInLinkedList()
        {
            // Arrange
            LinkedList list = new LinkedList();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            // Act
            string value = list.ToString();

            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> NULL";

            // Assert
            Assert.Equal(expected, value);

        }
    }
}

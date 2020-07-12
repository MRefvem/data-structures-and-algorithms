using System;
using System.Collections.Generic;
using Xunit;
using LinkedListImplementation;

namespace LinkedListsTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkedLists list = new LinkedLists();
            Assert.Null(list.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            // insert means add to the front
            // Arrange
            LinkedLists list = new LinkedLists();
            list.Insert(4);
            Assert.Equal(4, list.Head.Value);
        }

        [Fact]
        public void CanInsertMultipleNodesInLinkedList()
        {
            LinkedLists list = new LinkedLists();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);

            Assert.Equal(42, list.Head.Value);
        }

        [Fact]
        public void CanFindValueInList()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

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
        public void CannotFindValueInLinkedList()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

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
            LinkedLists list = new LinkedLists();

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

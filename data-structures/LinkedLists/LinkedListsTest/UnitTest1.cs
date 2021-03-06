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

        [Fact]
        public void CanSuccessfullyAddNoteToEndOfList()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            list.AppendNewNode(5);

            // Act
            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> 5 -> NULL";


            // Assert
            Assert.Equal(expected, list.ToString());
        }

        [Fact]
        public void CanSuccessfullyAddMultipleNodesToEnd()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            list.AppendNewNode(5);
            list.AppendNewNode(6);
            list.AppendNewNode(7);

            // Act
            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> 5 -> 6 -> 7 -> NULL";


            // Assert
            Assert.Equal(expected, list.ToString());

        }

        [Fact]
        public void CanSuccessfullyInsertACodeBeforeMiddle()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            list.InsertBefore(15, 5);

            // Act
            string expected = "42 -> 23 -> 16 -> 5 -> 15 -> 8 -> 4 -> NULL";


            // Assert
            Assert.Equal(expected, list.ToString());

        }

        [Fact]
        public void CanSuccessfullyInsertANodeBeforeTheFirstNode()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            list.InsertBefore(42, 5);

            // Act
            string expected = "5 -> 42 -> 23 -> 16 -> 15 -> 8 -> 4 -> NULL";


            // Assert
            Assert.Equal(expected, list.ToString());

        }

        [Fact]
        public void CanSuccessfullyInsertAfterANodeInMiddle()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            list.InsertAfter(16, 5);

            // Act
            string expected = "42 -> 23 -> 16 -> 5 -> 15 -> 8 -> 4 -> NULL";


            // Assert
            Assert.Equal(expected, list.ToString());

        }

        [Fact]
        public void CanSuccessfullyInsertANodeAfterTheLast()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(16);
            list.Insert(23);
            list.Insert(42);
            list.InsertAfter(4, 5);

            // Act
            string expected = "42 -> 23 -> 16 -> 15 -> 8 -> 4 -> 5 -> NULL";


            // Assert
            Assert.Equal(expected, list.ToString());

        }

        [Fact]
        public void CanReturnKthFromEndHappyPath()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

            list.Insert(10);
            list.Insert(20);
            list.Insert(30);
            list.Insert(40);
            list.Insert(50);

            // Act

            int value = list.FindKthFromTheEnd(1);

            // Assert
            Assert.Equal(20, value);

        }

        [Fact]
        public void CanReturnExceptionForEqualLength()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

            list.Insert(10);
            list.Insert(20);
            list.Insert(30);
            list.Insert(40);
            list.Insert(50);

            // Act
            var ex = Assert.Throws<Exception>(() => list.FindKthFromTheEnd(5));

            // Assert
            Assert.Equal("K is invalid", ex.Message);
        }

        [Fact]
        public void WhereKIsGreaterThanLengthOfList()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

            list.Insert(10);
            list.Insert(20);
            list.Insert(30);
            list.Insert(40);
            list.Insert(50);

            // Act
            var kTooBig = Assert.Throws<Exception>(() => list.FindKthFromTheEnd(7));

            // Assert
            Assert.Equal("K is invalid", kTooBig.Message);

        }

        [Fact]
        public void WhereKIsntAPositiveInt()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

            list.Insert(10);
            list.Insert(20);
            list.Insert(30);
            list.Insert(40);
            list.Insert(50);

            // Act
            var kNegative = Assert.Throws<Exception>(() => list.FindKthFromTheEnd(-7));

            // Assert
            Assert.Equal("K is invalid", kNegative.Message);
        }

        [Fact]
        public void WhereLinkedListIsSizeOfOne()
        {
            // Arrange
            LinkedLists list = new LinkedLists();

            list.Insert(10);

            // Act
            var k = Assert.Throws<Exception>(() => list.FindKthFromTheEnd(1));

            // Assert
            Assert.Equal("K is invalid", k.Message);
        }
    }
}

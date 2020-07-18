using System;
using Xunit;
using StacksAndQueues;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushOnStack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push("candy cane");
            var peek = stack.Peek();

            // Assert
            Assert.Equal("candy cane", peek);
            Assert.NotNull(peek);

        }

        [Fact]
        public void CanPushMultiple()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push("candy cane");
            stack.Push("krispy kreme");
            stack.Push("lollipop");
            var pop = stack.Pop();
            var peek = stack.Peek();

            // Assert
            Assert.NotEqual("candy cane", peek);
            Assert.Equal("krispy kreme", peek);
            Assert.Equal("lollipop", pop);

        }

        [Fact]
        public void CanPopOffStack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push("candy cane");
            stack.Push("krispy kreme");
            stack.Push("lollipop");
            stack.Pop();
            var peek = stack.Peek();

            // Assert
            Assert.Equal("krispy kreme", peek);

        }

        [Fact]
        public void CanEmptyStack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            stack.Push("candy cane");
            stack.Push("krispy kreme");
            stack.Push("lollipop");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Exception e = Assert.Throws<Exception>(() => stack.Peek());

            // Assert
            Assert.Equal("Top is null", e.Message);

        }

        [Fact]
        public void CanPeekNextItem()
        {
            // Arrange
            Stack stack = new Stack();


            // Act
            stack.Push("candy cane");
            stack.Push("krispy kreme");
            stack.Push("lollipop");
            var peek = stack.Peek();

            // Assert
            Assert.Equal("lollipop", peek);

        }

        [Fact]
        public void InstantiateEmptyStack()
        {
            // Arrange
            Stack stack = new Stack();

            // Act & Assert
            Assert.True(stack.IsEmpty());

        }

        [Fact]
        public void CallingOnEmptyRaisesException()
        {
            // Arrange
            Stack stack = new Stack();

            // Act
            Exception e = Assert.Throws<Exception>(() => stack.Pop());
            Exception f = Assert.Throws<Exception>(() => stack.Peek());

            // Assert
            Assert.Equal("Top is null", e.Message);
            Assert.Equal("Top is null", f.Message);

        }
    }
}

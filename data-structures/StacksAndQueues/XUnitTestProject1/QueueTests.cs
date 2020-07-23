using System;
using System.Text;
using Xunit;
using StacksAndQueues;
using System.Linq.Expressions;

namespace XUnitTestProject1
{
    public class QueueTests
    {
        [Fact]
        public void CanEnqueueIntoQueue()
        {
            // Arrange
            Queue<string> queue = new Queue<string>();

            // Act
            queue.Enqueue("Josie Cat");
            queue.Enqueue("Belle Kitty");
            var peek = queue.Peek();

            // Assert
            Assert.Equal("Josie Cat", peek);
            Assert.NotNull(peek);

        }

        [Fact]
        public void CanEnqueueMultiple()
        {
            // Arrange
            Queue<string> queue = new Queue<string>();

            // Act
            queue.Enqueue("Josie Cat");
            queue.Enqueue("Belle Kitty");
            queue.Enqueue("Mai Tai");
            var peek = queue.Peek();
            queue.Dequeue();
            var peek2 = queue.Peek();
            queue.Dequeue();
            var peek3 = queue.Peek();

            // Assert
            Assert.Equal("Josie Cat", peek);
            Assert.Equal("Belle Kitty", peek2);
            Assert.Equal("Mai Tai", peek3);

        }

        [Fact]
        public void CanSuccessfullyDequeue()
        {
            // Arrange
            Queue<string> queue = new Queue<string>();

            // Act
            queue.Enqueue("Josie Cat");
            queue.Enqueue("Belle Kitty");
            queue.Enqueue("Mai Tai");
            queue.Enqueue("Misu");
            queue.Enqueue("Tony");
            var dequeue = queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            var dequeue2 = queue.Dequeue();

            // Assert
            Assert.Equal("Josie Cat", dequeue);
            Assert.Equal("Tony", dequeue2);

        }

        [Fact]
        public void CanPeekIntoQueue()
        {
            // Arrange
            Queue<string> queue = new Queue<string>();

            // Act
            queue.Enqueue("Josie Cat");
            queue.Enqueue("Belle Kitty");
            queue.Enqueue("Mai Tai");
            queue.Enqueue("Misu");
            queue.Enqueue("Tony");
            var peek = queue.Peek();

            // Assert
            Assert.Equal("Josie Cat", peek);

        }

        [Fact]
        public void CanSuccessfullyEmpty()
        {
            // Arrange
            Queue<string> queue = new Queue<string>();

            // Act
            queue.Enqueue("Josie Cat");
            queue.Enqueue("Belle Kitty");
            queue.Enqueue("Mai Tai");
            queue.Enqueue("Misu");
            queue.Enqueue("Tony");
            var dequeue = queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            var peek = queue.Peek();
            var dequeue2 = queue.Dequeue();
            Exception e = Assert.Throws<Exception>(() => queue.Peek());

            // Assert
            Assert.Equal("Josie Cat", dequeue);
            Assert.Equal("Tony", dequeue2);
            Assert.NotNull(peek);
            Assert.Equal("Front is null", e.Message);

        }

        [Fact]
        public void CanInstantiateEmpty()
        {
            // Arrange
            Queue<string> queue = new Queue<string>();

            // Act & Assert
            Assert.True(queue.IsEmpty());

        }

        [Fact]
        public void CallingOnEmptyRaisesException()
        {
            // Arrange
            Queue<string> queue = new Queue<string>();

            // Act
            Exception e = Assert.Throws<Exception>(() => queue.Dequeue());
            Exception f = Assert.Throws<Exception>(() => queue.Peek());

            // Assert
            Assert.Equal("Front is null", e.Message);
            Assert.Equal("Front is null", f.Message);

        }
    }
}

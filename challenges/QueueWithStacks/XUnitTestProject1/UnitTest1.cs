using System;
using Xunit;
using QueueWithStacks;

namespace QueuesWithStacksTesting
{
    public class QueuesWithStacksTests
    {
        [Fact]
        public void EnqueueOddNumberOfValues()
        {
            // Arrange
            PseudoQueue testQueue = new PseudoQueue();
            string value1 = "1";
            string value2 = "2";
            string value3 = "3";
            string value4 = "4";
            string value5 = "5";

            // Act
            testQueue.Enqueue(value1);
            testQueue.Enqueue(value2);
            testQueue.Enqueue(value3);
            testQueue.Enqueue(value4);
            testQueue.Enqueue(value5);

            // Assert
            Assert.Equal();

        }

        [Fact]
        public void DequeueThrowsNullReferenceException()
        {
            // Assert
            PseudoQueue testQueue = new PseudoQueue();
            string value1 = "1";
            string value2 = "2";
            string value3 = "3";
            string value4 = "4";
            string value5 = "5";

            // Act
            testQueue.Enqueue(value1);
            testQueue.Enqueue(value2);
            testQueue.Enqueue(value3);
            testQueue.Enqueue(value4);
            testQueue.Enqueue(value5);

            // Assert
            Assert.Throws<NullReferenceException>((e) => testQueue.Dequeue());
        }
    }
}

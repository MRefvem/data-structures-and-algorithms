using System;
using Xunit;
using static ArrayShift.Program;

namespace ATMTest
{
    public class UnitTest1
    {
        [Fact]
        public void ExpectedOutcome()
        {

            // Arrange
            int[] arrayValue = new int[] { 2, 4, 6, 8 };
            int value = 5;

            // Act
            int[] expected = { 2, 4, 5, 6, 8 };
            int[] result = InsertShiftArray(arrayValue, value);

            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void ExpectedOutcome2()
        {

            // Arrange
            int[] arrayValue = new int[] { 4, 8, 15, 23, 42 };
            int value = 16;

            // Act
            int[] expected = { 4, 8, 15, 16, 23, 42 };
            int[] result = InsertShiftArray(arrayValue, value);

            // Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void NotInsertingAtWrongPlace()
        {

            // Arrange
            int[] arrayValue = new int[] { 4, 8, 15, 23, 42 };
            int value = 16;
            int[] notExpected = new int[] { 4, 8, 16, 15, 23, 42 };

            // Act
            int[] result = InsertShiftArray(arrayValue, value);

            // Assert
            Assert.NotEqual(notExpected, result);

        }
    }
}

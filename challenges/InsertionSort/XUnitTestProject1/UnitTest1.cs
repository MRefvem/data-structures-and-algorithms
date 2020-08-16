using System;
using Xunit;
using static InsertionSort.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanInsertionSortTheArray()
        {
            int[] arr = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] sortedArr = new int[] { 4, 8, 15, 16, 23, 42 };

            int[] result = Insertion_Sort(arr);

            Assert.Equal(sortedArr, result);
        }
    }
}

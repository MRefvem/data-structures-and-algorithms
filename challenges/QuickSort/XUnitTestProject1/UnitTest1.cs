using System;
using Xunit;
using static QuickSort.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanQuickSortTheArray()
        {
            int[] arr = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] sortedArr = new int[] { 4, 8, 15, 16, 23, 42 };

            int[] result = Quick_Sort(arr, 0, arr.Length - 1);

            Assert.Equal(sortedArr, result);
        }

        [Fact]
        public void CanQuickSortTheReversedArray()
        {
            int[] arr = new int[] { 20, 18, 12, 8, 5, -2 };
            int[] sortedArr = new int[] { -2, 5, 8, 12, 18, 20 };

            int[] result = Quick_Sort(arr, 0, arr.Length - 1);

            Assert.Equal(sortedArr, result);
        }

        [Fact]
        public void CanQuickSortNearlySorted()
        {
            int[] arr = new int[] { 2, 3, 5, 7, 13, 11 };
            int[] sortedArr = new int[] { 2, 3, 5, 7, 11, 13 };

            int[] result = Quick_Sort(arr, 0, arr.Length - 1);

            Assert.Equal(sortedArr, result);
        }
    }
}

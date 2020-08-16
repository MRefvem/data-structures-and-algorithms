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
    }
}

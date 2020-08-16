using System;
using System.Globalization;

namespace MergeSort
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            Console.WriteLine("Original Array:");
            PrintArray(arr);

            arr = Merge_Sort(arr);
            Console.WriteLine("Sorted Array:");
            PrintArray(arr);
        }

        /// <summary>
        /// Merge_Sort - Method sorts an array by merging the values
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        /// <returns>The sorted array</returns>
        public static int[] Merge_Sort(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right;

                if (arr.Length % 2 == 0)
                {
                    right = new int[mid];
                }
                else
                {
                    right = new int[mid + 1];
                }

                for (int i = 0; i < mid; i++)
                {
                    left[i] = arr[i];
                }
                for (int j = 0; j < right.Length; j++)
                {
                    right[j] = arr[mid + j];
                }

                int[] result = new int[arr.Length];
                left = Merge_Sort(left);
                right = Merge_Sort(right);

                result = Merge(left, right);
                return result;
            }

            return arr;
        }

        /// <summary>
        /// Merge - Method that performs the logic needed to merge
        /// </summary>
        /// <param name="left">The left value to compare</param>
        /// <param name="right">The right value to compare</param>
        /// <returns>The values, either returned in the same order or reversed</returns>
        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];

            int leftPointer = 0;
            int rightPointer = 0;
            int resultsPointer = 0;

            while (leftPointer < left.Length || rightPointer < right.Length)
            {
                if (leftPointer < left.Length && rightPointer < right.Length)
                {
                    if (left[leftPointer] < right[rightPointer])
                    {
                        result[resultsPointer] = left[leftPointer];
                        leftPointer++;
                        resultsPointer++;
                    }
                    else
                    {
                        result[resultsPointer] = right[rightPointer];
                        rightPointer++;
                        resultsPointer++;
                    }

                }
                else if (leftPointer < left.Length)
                {
                    result[resultsPointer] = left[leftPointer];
                    leftPointer++;
                    resultsPointer++;
                }
                else if (rightPointer < right.Length)
                {
                    result[resultsPointer] = right[rightPointer];
                    resultsPointer++;
                    rightPointer++;
                }
            }
            return result;
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.WriteLine($"{num}, ");
            }
        }
    }
}

using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8, 4, 23, 42, 16, 15 };

            Console.WriteLine("Original array: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Quick_Sort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array: ");

            foreach (var item in arr)
            {
                Console.WriteLine(" " + item);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Quick_Sort - Method that uses the quick sort algorithm to sort an array
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        /// <param name="left">The left value</param>
        /// <param name="right">The right value</param>
        /// <returns>The array that has been sorted</returns>
        public static int[] Quick_Sort(int[] arr, int left, int right)
        {
            if ( left < right )
            {
                // Partition the array by setting the position of the pivot value
                // DEFINE position<-- Partition(arr, left, right)
                int pivot = Partition(arr, left, right);

                // Sort the left
                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }

                // Sort the right
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

            return arr;

        }

        /// <summary>
        /// Partition - Method used to split the array into two halves
        /// </summary>
        /// <param name="arr">The array to be split</param>
        /// <param name="left">The left value to compare</param>
        /// <param name="right">The right value to compare</param>
        /// <returns>The array split into two halves</returns>
        private static int Partition(int[] arr, int left, int right)
        {
            // Set a pivot value as a point of reference
            int pivot = arr[left];

            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;
                    // all numbers smaller than the pivot are on the left, larger on the right. 

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}

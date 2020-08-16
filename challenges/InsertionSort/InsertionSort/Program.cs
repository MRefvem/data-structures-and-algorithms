using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = [8, 4, 23, 42, 16, 15];
            //Insertion_Sort(arr);
        }

        /// <summary>
        /// Insertion_Sort - Method uses the insertion algorithm to sort an array in place
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        public static int[] Insertion_Sort(int[] arr)
        {
            // for loop to iterate over the length of the array
            for (int i = 1; i < arr.Length; i++)
            {
                // j is equal to the index position [i] but minus 1
                int j = i - 1;
                // temp is equal to the value of the index position
                int temp = arr[i];

                // while j is greater than zero and temp is less than the value of array at index position j (which is i minus 1)
                while (j >= 0 && temp < arr[j])
                {
                    // then do this:
                    // the value of array at j + 1 now equals array at index position J
                    arr[j + 1] = arr[j];
                    // and J is now equal to J minus 1
                    j = j - 1;
                    // they appear to have switched positions

                    // temp now equals the value of array at index position J plus 1 to stay consistent with arr[j]
                }
                arr[j + 1] = temp;
            }
        return arr;
        }
    }
}

﻿using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] unsortedArray = { 289, 3, 34, 57, 4, 26, 346, 74, 34, 0, 19 };
            MergeSort(unsortedArray);
        }

        static void MergeSort(int[] myArray)
        {
            if (myArray.Length > 1)
            {
                //divide array in half
                int leftSize = myArray.Length / 2;
                int rightSize = myArray.Length - leftSize;

                // put the left half in array
                int[] left = new int[leftSize];
                Array.Copy(myArray, 0, left, 0, leftSize);

                // put the right half in separate array
                int[] right = new int[rightSize];
                Array.Copy(myArray, myArray.Length / 2, right, 0, rightSize);

                //call merge sort for each half of array
                MergeSort(left);
                MergeSort(right);

                //merge both sorted arrays into one array
                Merge(left, right, myArray);
            }
            Console.WriteLine(string.Join(",", myArray));
        }

        static int[] Merge(int[] left, int[] right, int[] arr)
        {
            // left pointer
            int i = 0;
            // right pointer
            int j = 0;
            // end array pointer
            int k = 0;

            // confirm that each array being compared still has pointers
            while (i < left.Length && j < right.Length)
            {
                // if the value of left array is less than the value of the right array
                if (left[i] <= right[j])
                {
                    // populate the main array with lower value
                    arr[k] = left[i];
                    // immediately increment i.
                    i++;
                }
                else
                {
                    // put the value of the right array into the main array
                    arr[k] = right[j];
                    // increment the pointer of the right
                    j++;
                }
                // increment the pointer in the main array
                k++;
            }


            if (i == left.Length)
            {
                // copy right array into main array
                Array.Copy(right, j, arr, k, right.Length - j);
            }
            else
            {
                Array.Copy(left, i, arr, k, left.Length - i);
            }

            return arr;

        }
    }
}

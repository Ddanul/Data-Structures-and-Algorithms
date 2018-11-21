using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] unsortedArray = { 17, 3, 45, 43, 0, 67, 23, 56, 4, 2, 1, 79, 100 };
            Console.WriteLine();
            Console.WriteLine("Unsorted Array: ");
            Print(unsortedArray);

            Console.WriteLine();
            InsertionSort(unsortedArray);
            Console.WriteLine("Sorted Array: ");
            Print(unsortedArray);

        }

        static void InsertionSort(int[] myArray)
        {
            for (int i = 1; i < myArray.Length; i++)
            {
                int temp = myArray[i];
                int j = i - 1;

                while (j >= 0 && temp < myArray[j])
                {
                    myArray[j + 1] = myArray[j];
                    j--;
                }

                myArray[j + 1] = temp;
            }
        }

        static void Print(int[] arr)
        {
            Console.WriteLine();
            Console.Write("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write(" ");
            Console.WriteLine();
        }
    }
}

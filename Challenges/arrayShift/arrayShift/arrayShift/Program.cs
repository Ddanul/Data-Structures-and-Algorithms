using System;

namespace arrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 6, 8 };
            int value = 5;
            int[] newArray = ArrayShift(array, value);

            //trying to see the array
            for(int i=0; i<newArray.Length; i++)
            {
                Console.Write(newArray[i]);
            }
        }

        static int[] ArrayShift(int[] array, int value)
        {
            int[] newArray = new int[array.Length+1];
            int halfwayPoint = array.Length - (array.Length / 2);
            for(int i=0; i<newArray.Length; i++)
            {
                if (i < halfwayPoint)
                {
                    newArray[i] = array[i];
                }
                else if(i == halfwayPoint)
                {
                    newArray[i] = value;
                }
                else
                {
                    newArray[i] = array[i - 1];
                }
            }
            return newArray;

        }
    }
}

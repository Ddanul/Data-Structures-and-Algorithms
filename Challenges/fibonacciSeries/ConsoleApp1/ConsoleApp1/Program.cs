using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($" The Fib number value for 3 is {FindFibNumber(3)}");
            Console.WriteLine($" The Fib number value for 7 is {FindFibNumber(7)}");
            Console.WriteLine($" The Fib number value for 10 is {FindFibNumber(10)}");

        }

        static int FindFibNumber(int searchIdx)
        {
            int num1 = 0, num2 = 1, currentNum = 0;

            for(int i=0; i<searchIdx-1; i++)
            {
                currentNum = num1 + num2;
                num1 = num2;
                num2 = currentNum;
            }

            return currentNum;
        }
    }
}

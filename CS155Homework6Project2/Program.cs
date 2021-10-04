using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155Homework6Project2
{
    class Program
    {
        public const int SIZE = 10;
        public const int RND_MIN = 0;
        public const int RND_MAX = 1000;

        static void Reverse(int[] Nums)
        {
            int temp;

            for (int i=0; i < SIZE/2; i++)   //loop only until half the array size for swapping..
            {
                temp = Nums[i];
                Nums[i] = Nums[SIZE - i - 1];
                Nums[SIZE - i - 1] = temp;
            }

        }

        static int[] GenerateNumbers()
        {
            int[] pArr = new int[SIZE];  // return the array

            Random rndA = new Random();
            for (int i = 0; i < SIZE; i++)
                pArr[i] = rndA.Next(RND_MIN, RND_MAX);

            return pArr;
        }

        static void PrintNumbers(int[] Nums, int[] NumsOrig)
        {
            //now print
            //
            Console.WriteLine("       -Array (Original)-");
            Console.WriteLine("Index   Value  ");
            for (int i = 0; i < SIZE; i++)
                Console.WriteLine("   " + i.ToString() + "      " + NumsOrig[i]);

            Console.WriteLine();

            Console.WriteLine("       -Array (Reversed)-");
            Console.WriteLine("Index   Value  ");
            for (int i = 0; i < SIZE; i++)
                Console.WriteLine("   " + i.ToString() + "      " + Nums[i]);

            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Homework 6 - Project 2; Reversing an array");
            Console.WriteLine("-------------------------------------------------");

            int[] numbersOriginal = GenerateNumbers();
            int[] numbers = GenerateNumbers();  // we need to initialize the array, but we don't need the new numbers

            //Copy the original numbers to numbers before reversing them
            for (int i = 0; i < SIZE; i++)
                numbers[i] = numbersOriginal[i];

            Reverse(numbers);
            PrintNumbers(numbers, numbersOriginal);
        }
    }
}

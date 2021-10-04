using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS155Homework6Project1
{
    class Program
    {
        public const int SIZE = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("hello! homework 6! Part 1");
            Console.WriteLine("-------------------------");

            //char[,] myArray1 = new char[SIZE, SIZE]
            //    {
            //    };

            string[] myArray1 = new string[SIZE];

            myArray1[0] = "Mira Costa";
            myArray1[1] = "Palomar";
            myArray1[2] = "SD Mesa";
            myArray1[3] = "Miramar";
            myArray1[4] = "CSU-San Marcos";
            myArray1[5] = "San Diego State";
            myArray1[6] = "UCSD San Diego";
            myArray1[7] = "UC Irvine";
            myArray1[8] = "UC Los Angeles";
            myArray1[9] = "UC Berkeley";

            Console.WriteLine(myArray1.Length.ToString());
            string[] myArray2 = new string[myArray1.Length];

            //return;

            for (int i = 0; i < SIZE; i++)
                myArray2[i] = myArray1[i];  // String.Copy(myArray1[i]);  //copy array1 to array2

            //now print
            //
            Console.WriteLine("       -Array1-");
            Console.WriteLine("  Index       Value  ");
            for (int i = 0; i < SIZE; i++)
                Console.WriteLine("   " + i.ToString() + "      " + myArray1[i]);

            Console.WriteLine();

            Console.WriteLine("       -Array2 (copied)-");
            Console.WriteLine("  Index       Value  ");
            for (int i = 0; i < SIZE; i++)
                Console.WriteLine("   " + i.ToString() + "      " + myArray2[i]);
            
            Console.ReadLine();

        }
    }
}

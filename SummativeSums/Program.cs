using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummativeSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new int[] { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] Array2 = new int[] { 999, -60, -77, 14, 160, 301 };
            int[] Array3 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };

            Console.WriteLine("Sum of Array 1 is {0}", Program.SumArray(Array1));
            Console.WriteLine("Sum of Array 2 is {0}", Program.SumArray(Array2));
            Console.WriteLine("Sum of Array 3 is {0}", Program.SumArray(Array3));
            Console.ReadKey();
        }

        public static long SumArray(int[] TheArray)
        {
            long Sum = 0;
            int Count;
            for (Count = 0; Count < TheArray.Length; Count++) Sum += TheArray[Count];
            return Sum;
        }
    }
}

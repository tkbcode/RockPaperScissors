using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age, MaxRate, TargetRateMin, TargetRateMax;

            Console.Write("Enter your age:  ");
            Age = Int32.Parse(Console.ReadLine());
            MaxRate = 220 - Age;
            TargetRateMin = (int)((Single)MaxRate * (Single).5);
            TargetRateMax = (int)((Single)MaxRate * (Single).85);
            Console.WriteLine("The maximum healthy heart rate for age {0} is {1} bpm.", Age, MaxRate);
            Console.WriteLine("The target heart rate is between {0} and {1} bpm.", TargetRateMin, TargetRateMax);
            Console.WriteLine("Hit a key to continue.");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {
            string DogName;
            string[] DogBreed = new string[5] { "Great Dane", "Doberman Pinscher", "Laborador Retriever", "Chihuahua", "Poodle" };
            Decimal[] BreedPercent = new Decimal[5];
            byte Counter;
            double Gene = (double)1;
            double Percent;
            Random random = new Random();

            Console.Write("What is the name of your dog?  ");
            DogName = Console.ReadLine();

            for(Counter=0; Counter <4; Counter++)
            {
                Percent = random.NextDouble() * Gene;
                Gene -= Percent;
                BreedPercent[Counter] = (decimal)Percent;
            }
            BreedPercent[4] = (decimal)Gene;

            Console.WriteLine("Well, then, I have this highly reliable report");
            Console.WriteLine("on {0}'s prestigious background:", DogName);
            Console.WriteLine("");
            Console.WriteLine("{0} is:\n", DogName);
            for (Counter = 0; Counter < 5; Counter++)
            {
                Console.WriteLine("{0}% {1}", Math.Round(BreedPercent[Counter]*100), DogBreed[Counter]);
            }

            Console.WriteLine("\nHit any key to exit program.");
            Console.ReadKey();
        }
    }
}

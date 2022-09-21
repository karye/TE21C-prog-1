using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Slumpa fram ett tal
            Random generator = new Random();
            int slumptal = generator.Next(1, 101);

            // En oändlig loop
            while (true)
            {
                // Fråga användaren om en gissning
                Console.Write("Gissa ett tal 1-100: ");
                string gissningString = Console.ReadLine();
                
                // Omvandla till ett tal
                int gissning = int.Parse(gissningString);

                // Är gissningen större än slumptalet?
                if (gissning > slumptal)
                {
                    Console.WriteLine("För högt!");
                }
                else if (gissning < slumptal)
                {
                    Console.WriteLine("För lågt!");
                }
                else
                {
                    Console.WriteLine("Rätt!");
                    break;
                }
            }

            // Slut!
        }
    }
}

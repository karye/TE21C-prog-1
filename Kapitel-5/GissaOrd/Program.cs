using System;

namespace GissaOrd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ordet!");

            // Skapa en array på 10 djur
            string[] djuren = {"Sardin", "Hare", "Katt", "Mås", "Häst", "Val", "Orm", "Hund", "Örn", "Lax"};    // index = 0, 1, 2, .. 8, 9

            // Slumpa ett tal 0-9
            Random generator = new Random();
            int slumptal = generator.Next(0, 10);
            //Console.WriteLine(slumptal);

            // Skriv ut djuret mha slumptal som index
            //Console.WriteLine(djuren[slumptal]);

            // Gissa 5 ggr max
            for (int i = 0; i < 5; i++)
            {
                // Fråga användaren att gissa ett djur
                Console.Write("Gissa ett djur: ");
                string gissning = Console.ReadLine();
                
                // Kolla om gissning är rätt
                if (gissning.ToLower() == djuren[slumptal].ToLower())
                {
                    Console.WriteLine("Bra gissat!");
                    break;
                }
                else
                {
                    Console.WriteLine("Fel! Försök igen!");
                }
            }
        }
    }
}

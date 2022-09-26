using System;

namespace Menyer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ett menyprogram!");

            // Slumpgeneratorn
            Random generator = new Random();

            // Programloopen
            while (true)
            {
                // Visa en meny
                Console.WriteLine("1. Slumpa fram ett tal 1-6");
                Console.WriteLine("2. Slumpa fram ett tal 1-100");
                Console.WriteLine("3. Avsluta");
                Console.Write("Välj ett alternativ: ");
                string val = Console.ReadLine();

                // Utför det användaren valt
                if (val == "1")
                {
                    int slumptal = generator.Next(1, 7);
                    Console.WriteLine($"Slumptalet är {slumptal}");
                }
                else if (val == "2")
                {
                    int slumptal = generator.Next(1, 101);
                    Console.WriteLine($"Slumptalet är {slumptal}");
                }
                else if (val == "3")
                {
                    // Avslutar loopen
                    Console.WriteLine("Hejdå!");
                }
                else
                {
                    Console.WriteLine("Ogiltigt alternativ, välj 1-3");
                }
            }

        }
    }
}

/* 
Slumpa fram nya tal tills användaren skriver "j" för att avsluta
Ställ frågan "Vill du avsluta? j/n"
 */

using System;

namespace UppgiftSlumpa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Starta slumpgeneratorn
            Random generator = new Random();

            // Loopen
            while (true)
            {
                // Skriv ut ett slumptal
                int slumptal = generator.Next(1, 1000);
                Console.WriteLine($"Slumptalet är {slumptal}");

                // Fråga användaren
                Console.WriteLine("Vill du avsluta? j/n");
                string svar = Console.ReadLine();

                // Avbryt om "j"
                if (svar == "j")
                {
                    break;
                }
            }
        }
    }
}

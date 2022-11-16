using System;

namespace GissaHeltal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett heltal!");

            // Slumpa fram ett tal 1-20
            Random generator = new Random();
            int slumptal = generator.Next(1, 21);

            // Be användaren mata in antalGissningar
            Console.Write("Hur många gånger vill du gissa? ");

            // Säker inmatning
            string svar = Console.ReadLine();
            int varv;
            
            // Inmatningsloop
            while (!int.TryParse(svar, out varv))
            {
                Console.Write("Du mattade inte in ett heltal, Vg försök igen: ");
                svar = Console.ReadLine();
            }

            // Loopa "antalGissningar"
            for (int i = 0; i < varv; i++)
            {
                // Be användaren gissa ett tal
                Console.Write("Gissa ett tal (1-20): ");
                int gissning = int.Parse(Console.ReadLine());

                // Kolla om gissning är rätt
                if (gissning == slumptal)
                {
                    Console.WriteLine("Du gissade rätt!");
                    break;
                }
                else
                {
                    Console.WriteLine("Försök igen!");
                }
            }
        }
    }
}

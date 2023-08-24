using System;

namespace Inmatning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att räkna ut åldern!");

            // Programloop
            while (true)
            {
                // Räkna ut ålder
                Console.Write("Vilket år är du född? ");
                string år = Console.ReadLine();

                // Vi ska använda int.TryParse()
                bool kundeParsa = int.TryParse(år, out int årtal);
                Console.WriteLine($"Resultat TryParse: {kundeParsa} och {årtal}");

                if (kundeParsa == true)
                {
                    // Räkna ut ålder: året idag - året man är född
                    int ålder = DateTime.Now.Year - årtal;
                    Console.WriteLine($"Du är {ålder} år");
                }
                else
                {
                    Console.WriteLine("Fel inmatning! Vg mata in ett årtal!");
                }

                // Vill du köra igen?
                Console.Write("Vill du köra igen? (j/n) ");
                string svar = Console.ReadLine();
                if (svar == "n")
                {
                    break;
                }
            }
        }
    }
}

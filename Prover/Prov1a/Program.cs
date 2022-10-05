using System;

namespace Prov1a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Program för att räkna ut lön efter skatt");

            // Be användaren mata in sitt namn
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();

            // Programloopen
            while (true)
            {
                // Mata in bruttolön & skattesats
                // Kontrollera
                // Räkna ut nettolön
                // Skriv ut svaret
                // 1. Bruttolön
                int bruttolön = 0;
                while (true)
                {
                    Console.Write("Ange din bruttolön (10000-45000): ");
                    bruttolön = int.Parse(Console.ReadLine());

                    if (bruttolön < 10000 || bruttolön > 45000)
                    {
                        // Fel
                        Console.WriteLine("Fel inmatning! Vg mata 10000-45000");
                    }
                    else
                    {
                        // Rätt
                        break;
                    }
                }

                // 2. Skattesats
                int skattesats = 0;
                while (true)
                {
                    Console.Write("Ange din bruttolön (10%-45%): ");
                    skattesats = int.Parse(Console.ReadLine());

                    if (skattesats < 10 || skattesats > 45)
                    {
                        // Fel
                        Console.WriteLine("Fel inmatning! Vg mata 10-45");
                    }
                    else
                    {
                        // Rätt
                        break;
                    }
                }

                // Efter all inmatning
                int nettolön = bruttolön * (100 - skattesats) / 100;

                // Skriv ut svaret
                Console.WriteLine($"{namn} din lön efter skatt är {nettolön}");
                //Console.WriteLine(namn + " din lön efter skatt är " + nettolön);
                Console.WriteLine($"Baserat på bruttolön {bruttolön} och skattesats {skattesats}");


                // Fråga användaren om hen vill köra en gång till
                Console.Write("Vill köra en gång till? (j/n) ");
                string svar = Console.ReadLine().ToLower();
                if (svar == "n")
                {
                    break;
                }
            }
        }
    }
}
/* using System;

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
                // Be användaren mata in bruttolön
                Console.Write("Ange din bruttolön (10000-45000): ");
                int bruttolön = int.Parse(Console.ReadLine());

                // Kontrollera att inmattat är korrekt
                if (bruttolön < 10000 || bruttolön > 45000)
                {
                    // Fel
                    Console.WriteLine("Fel inmatning! Vg mata 10000-45000");
                }
                else
                {
                    // Rätt
                    // Be användaren mata in skattesats
                    Console.Write("Ange din bruttolön (10%-45%): ");
                    int skattesats = int.Parse(Console.ReadLine());

                    // Kontrollera att inmattat är korrekt
                    if (skattesats < 10 || skattesats > 45)
                    {
                        // Fel
                        Console.WriteLine("Fel inmatning! Vg mata 10-45");
                    }
                    else
                    {
                        // Rätt
                        // Räkna ut nettolön
                        int nettolön = bruttolön * (100 - skattesats) / 100;

                        // Skriv ut svaret
                        Console.WriteLine($"{namn} din lön efter skatt är {nettolön}");
                        //Console.WriteLine(namn + " din lön efter skatt är " + nettolön);
                        Console.WriteLine($"Baserat på bruttolön {bruttolön} och skattesats {skattesats}");
                    }
                }

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
 */
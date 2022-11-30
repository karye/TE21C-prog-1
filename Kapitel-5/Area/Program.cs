/* 
    Läs in längden (int)
    Läs in bredden (int)
    Skriv ut arean = längden * bredden
 */
using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ut arean!");

            // Läs in längden (int)
            Console.Write("Ange längden (heltal): ");
            string längdenString = Console.ReadLine();
            Console.Write("Ange bredden (heltal): ");
            string breddenString = Console.ReadLine();

            // Konvertera från string -> int mha int.Tryparse()
            /*             bool kundeParsaLängden = int.TryParse(längdenString, out int längden);
                        bool kundeParsaBredden = int.TryParse(breddenString, out int bredden);

                        // Räkna om true
                        if (kundeParsaLängden && kundeParsaBredden)
                        {
                            // Vi har två int
                            Console.WriteLine($"arean = {längden * bredden}");
                        }
                        else
                        {
                            Console.WriteLine("Fel inmatning!");
                        } */

            while (!int.TryParse(längdenString, out int längden))
            {
                Console.Write("Ange längden (heltal): ");
                string längdenString = Console.ReadLine();
            }

            while (!int.TryParse(breddenString, out int bredden))
            {
                Console.Write("Ange bredden (heltal): ");
                string breddenString = Console.ReadLine();
            }
        }
    }
}

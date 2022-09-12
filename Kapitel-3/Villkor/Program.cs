using System;

namespace Villkor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
/*             Console.Write("Vg ange ditt lösenord: ");
            string svar = Console.ReadLine();
            
            // Kontrollera att lösenordet är rätt
            if (svar == "abc123")
            {
                Console.WriteLine("Bra nu kan du jobba vidare");
                Console.WriteLine("blbla");
            }
            else if (svar == "def456")
            {
                Console.WriteLine("Ja, rätt lösenord");
            }
            else
            {
                Console.WriteLine("Fel lösenord");
            } */

            Console.Write("Är lampan inkopplad? (ja/nej)");
            string svar = Console.ReadLine();
            if (svar == "nej")
            {
                Console.WriteLine("Koppla in lampan");
            }
            else
            {
                Console.Write("Är glödlampan utbränd? ");
                svar = Console.ReadLine();
                if (svar == "ja")
                {
                    Console.WriteLine("Ersäatt lampan");
                }
                else
                {
                    Console.WriteLine("Köp ny lampa");
                }
            }
        }
    }
}

using System;

namespace Duplantis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program får att räkna ut hut mycket mer Duplantis hoppar
            Console.Clear();
            Console.WriteLine("Program får att räkna ut hut mycket mer Duplantis hoppar");

            // Läs in höjden
            Console.Write("Hur högt hoppar du? ");
            string höjdString = Console.ReadLine();
            
            // Översätt från text till tal
            double höjd = double.Parse(höjdString);

            // Räkna ut skillnaden
            double skillnad = 6.25 - höjd;

            // Skriv ut svaret
            Console.WriteLine("Duplantis hoppar " + skillnad + " meter mer än dig");
        }
    }
}

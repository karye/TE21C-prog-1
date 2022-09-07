using System;

namespace Datatyper
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program för att räkna ut ålder vid examen
            Console.Clear();
            Console.WriteLine("Program för att räkna ut ålder vid examen");

            // Läs in namnet
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();
            
            // Läs in ålder
            Console.Write("Hur gammal är du? ");
            string ålderString = Console.ReadLine();    // "17"
            
            // Skriv ut ett svar
            Console.WriteLine("Hej, " + namn + " du är " +  ålderString + " år.");

            // Konvertera från text till heltal
            int ålder = int.Parse(ålderString);         // 17

            // Beräkningen
            int ålderExamen = ålder + 1;

            // Skriv ut resultat
            Console.WriteLine("Din ålder vid examen är " + ålderExamen);
        }
    }
}

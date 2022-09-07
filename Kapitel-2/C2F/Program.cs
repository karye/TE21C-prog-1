using System;

namespace C2F
{
    class Program
    {
        static void Main(string[] args)
        {
            // Översätt temperaturen från Celsius till Farenheit
            // med formeln F = C * 1.8 + 32
            Console.Clear();
            Console.WriteLine("Program som översätter temperaturen från Celsius till Farenheit");

            // Läs in temperaturen
            Console.Write("Ange temperaturen i Celsius ");
            string celsiusString = Console.ReadLine();

            // Konvertera till flyttal
            double celsius = double.Parse(celsiusString);

            // Översätt från Celsius till Farenheit
            double farenheit = celsius * 1.8 + 32;

            // Skriv ut resultatet
            Console.WriteLine(celsius + "° Celsius är " + farenheit + "° Farenheit");
        }
    }
}

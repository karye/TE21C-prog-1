using System;

namespace LuckText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Töm terminalen (konsolen)
            Console.Clear();

            // Ändra bakgrundsfärg
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Skriv ut en liten text
            Console.WriteLine("Idag är det måndag 5/9 2022");
            Console.WriteLine("Vi skall träna på konsolen");

            // Vi läser in ett namn
            Console.Write("Skriv ditt namn: ");
            string namn = Console.ReadLine();

            // Skriv ut en personlig hälsning
            //Console.WriteLine("Hej " + namn);

            // Läser in lunchförslag
            //Console.Write("Vad vill du äta till lunch? ");
            //string lunch = Console.ReadLine();
            
            // Skriv ut ett svar
            //Console.WriteLine(namn + ", det låter gott med " + lunch);

            // Läs in en vätska
            Console.Write("Ange namnet på en vätska ");
            string vätska = Console.ReadLine();
            
            // Läs in en kroppsdel
            Console.Write("Ange namnet på en kroppsdel ");
            string kroppsdel = Console.ReadLine();

            // Läs in en sak
            Console.Write("Ange namnet på en sak ");
            string sak = Console.ReadLine();

            // Skriv ut en rolig mening som innehåller: namn, vätska, kroppsdel, sak
            Console.WriteLine("Hej " + namn + ", du måste handla " + vätska + " på systemet för att du har ont i " + kroppsdel + " och svälja " + sak);
            Console.ReadKey();
        }
    }
}

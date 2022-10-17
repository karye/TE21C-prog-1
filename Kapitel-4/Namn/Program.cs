using System;

namespace Namn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Byta ordningen på förnamn och efternamn");

            // Läs in "förnamn efternamn" och skriv ut "efternamn förnamn"
            Console.Write("Ange förnamn efternamn: ");
            string namn = Console.ReadLine();
            
            // Använd .IndexOf() och .SubString()
            // Leta efter " "
            int index = namn.IndexOf(" ");

            string förnamn = namn.Substring(0, index);
            string efternamn = namn.Substring(index + 1);

            // Skriv ut omvänt
            Console.WriteLine(efternamn + " " + förnamn);
        }
    }
}

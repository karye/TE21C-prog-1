using System;

namespace EpostKoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Kolla om epost är i korrekt format!");

            // Tex karim@bredband.net
            // Namndelen = karim
            // Domändelen = bredband
            // Landdelen = se

            // Mata in epostadress
            Console.Write("Mata in epostadress: ");
            string epost = Console.ReadLine();
            
            // Skriv ut längden
            //Console.WriteLine($"Antal inmattade tecken är {epost.Length}");

            // Rensa bort mellanslagen
            epost = epost.Trim();

            // Skriv ut längden igen
            //Console.WriteLine($"Antal inmattade tecken är {epost.Length} efter trimning");

            // Kolla att inmattad epost är i korrekt format, innehållet @-tecknet
            if (epost.Contains("@") && epost.Contains("."))
            {
                Console.WriteLine("Ser ut som en epostadress");

                // Plockat ut delarna i epostadressen
                // Hitta @-tecknet
                int index = epost.IndexOf("@");
                Console.WriteLine("@ finns på position " + index);

                // Plocka ut alla tecken före @-tecknet
                Console.WriteLine(epost.Substring(0, index));

                // Skriv ut allt efter @-tecknet
                string delBakom = epost.Substring(index + 1);
                Console.WriteLine(delBakom);

                // Dela upp i domändel och landdel
                // Steg 1: hitta "."
                index = delBakom.IndexOf(".");

                // Skriv ut det som är före "."
                Console.WriteLine(delBakom.Substring(0, index));

                // Skriv ut det som är bakom "."
                Console.WriteLine(delBakom.Substring(index + 1));
            }
            else
            {
                Console.WriteLine("Vad är det här för något?");
            }

        }
    }
}

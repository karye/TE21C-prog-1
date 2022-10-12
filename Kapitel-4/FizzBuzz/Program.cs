using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");

            // 1. Skapa ett program som skriver ut talen 1 till 100 på var sin rad. 
            for (int i = 1; i <= 100; i++)
            {
                // 2. Men talen som är delbara med 3 ska inte skrivas ut, istället ska ordet Fizz skrivas. 
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

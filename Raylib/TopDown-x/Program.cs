/* 
@TODO
+ Variera storlek på flingorna
+ Byta ut fyrkanter mot "riktiga" flingor
+ Snön samlas på marken
 */

using System;
using Raylib_cs;

namespace TopDown_x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snöstorm!");
            Random generator = new Random();

            Raylib.InitWindow(512, 480, "Raylib");
            Raylib.SetTargetFPS(60);

            // Skapar objekten
            // En lite fyrkant 20x20

            // Skapa en samling för flingor
            Rectangle[] flingor = new Rectangle[100];
            int[] hastigheter = new int[100];

            // Upprepa 100 ggr 
            for (int i = 0; i < 100; i++)
            {
                // Skapa en snöflinga
                Rectangle flinga = new Rectangle(generator.Next(0, 512), generator.Next(-500, 0), 20, 20);
                flingor[i] = flinga;

                // Skapa snöflingans fallhastighet
                hastigheter[i] = generator.Next(1, 4);
            }

            while (!Raylib.WindowShouldClose())
            {
                // Updatera objekten
                for (int i = 0; i < 100; i++)
                {
                    flingor[i].y += hastigheter[i];

                    // Om flingas y-värde större än höjden på fönstret, börja om
                    if (flingor[i].y >= 480)
                    {
                        flingor[i].y = generator.Next(-500, 0);
                        flingor[i].x = generator.Next(0, 512);
                    }
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita ut objekten
                for (int i = 0; i < 100; i++)
                {
                    Raylib.DrawRectangleRec(flingor[i], Color.WHITE);
                }

                Raylib.EndDrawing();
            }
        }
    }
}

using System;
using Raylib_cs;

namespace Shmup_1
{
    class Program
    {
        // Skapa alla variabler (globala)
        static Texture2D skeppTextur;
        static Rectangle skeppRektangel;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello SHMUP!");
            Raylib.InitWindow(800, 600, "SHMUP");
            Raylib.SetTargetFPS(60);

            // Skapa skeppet
            skeppTextur = Raylib.LoadTexture(@"resurser/space-invaders.png");
            skeppRektangel = new Rectangle(400, 500, skeppTextur.width, skeppTextur.height);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                RitaSpel();
            }
        }

        static void RitaSpel()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            // Rita ut skeppet
            Raylib.DrawTexture(skeppTextur, (int)skeppRektangel.x, (int)skeppRektangel.y, Color.WHITE);

            Raylib.EndDrawing();
        }
    }
}

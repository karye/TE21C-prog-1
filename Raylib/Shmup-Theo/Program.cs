using System;
using Raylib_cs;

namespace Shmup_Theo
{
    class Program
    {
        static Texture2D skeppTextur;
        static Rectangle skeppRektangel;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SHMUP!");
            Raylib.InitWindow(800, 600, "SHMUP");
            Raylib.SetTargetFPS(60);

            // Skapa skeppet 
            skeppTextur = Raylib.LoadTexture(@"Images/silly.png");
            skeppRektangel = new Rectangle(400, 500, skeppTextur.width, skeppTextur.height);
            Console.WriteLine(skeppTextur.width + " "+ skeppTextur.height);

            while (!Raylib.WindowShouldClose())
            {
                RitaSpel();
            }
        }

        static void RitaSpel()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            // Rita ut skeppet
            Raylib.DrawTexture(skeppTextur, (int)skeppRektangel.x, (int)skeppRektangel.y, Color.WHITE);

            Raylib.EndDrawing();
        }
    }
}
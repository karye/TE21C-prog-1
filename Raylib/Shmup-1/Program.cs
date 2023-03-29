using System;
using Raylib_cs;

namespace Shmup_1
{
    class Program
    {
        // Skapa alla variabler (globala)
        static Texture2D skeppTextur;
        static Rectangle skeppRektangel;
        static bool skjuter = false;

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
                Input();
                UppdateraSkepp();
                RitaSpel();
            }
        }

        // Ritar ut spelet i fönstret
        static void RitaSpel()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            // Rita ut skeppet
            Raylib.DrawTexture(skeppTextur, (int)skeppRektangel.x, (int)skeppRektangel.y, Color.WHITE);

            // Rita ut skottet när spelare skjuter
            if (skjuter)
            {
                Raylib.DrawRectangle((int)skeppRektangel.x + 30, (int)skeppRektangel.y - 55, 3, 50, Color.YELLOW);
            }

            Raylib.EndDrawing();
        }

        // Lyssnar på tangentbordets knappar (func)
        static void Input()
        {
            // Lyssna på vänsterpil
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                skeppRektangel.x -= 5;
            }

            // Lyssna på högerpil
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                skeppRektangel.x += 5;
            }

            // Lyssna på vänsterpil
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                skeppRektangel.y -= 5;
            }

            // Lyssna på högerpil
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                skeppRektangel.y += 5;
            }

            // Lyssna på mellanslag (för att skjuta)
            skjuter = false;
            if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
            {
                skjuter = true;
            }
        }

        // Uppdatera skeppets position
        static void UppdateraSkepp()
        {
            // Se till att skeppet inte lämnar fönstret
            skeppRektangel.x = Math.Clamp(skeppRektangel.x, 0, 800 - skeppRektangel.width);
            skeppRektangel.y = Math.Clamp(skeppRektangel.y, 0, 600 - skeppRektangel.height);
        }

        // Få skottet att flyga iväg
        static void UppdateraSkott()
        {
            
        }
    }
}

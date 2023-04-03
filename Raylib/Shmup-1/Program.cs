using System;
using Raylib_cs;

namespace Shmup_1
{
    class Program
    {
        /*  Skapa alla variabler (globala) */
        // Skeppets variabler
        static Texture2D skeppTextur;
        static Rectangle skeppRektangel;
        static bool skjuter = false;

        // Skottets variabler
        static Texture2D texturSkott;
        static Rectangle skottRektangel;
        static Sound skottLjud;
        static bool synligt = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello SHMUP!");
            Raylib.InitWindow(800, 600, "SHMUP");
            Raylib.InitAudioDevice();
            Raylib.SetTargetFPS(60);

            // Skapa skeppet
            skeppTextur = Raylib.LoadTexture(@"./resurser/space-invaders.png");
            skeppRektangel = new Rectangle(400, 500, skeppTextur.width, skeppTextur.height);

            // Skapa skott
            skottLjud = Raylib.LoadSound(@"./resurser/laser.wav");

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                Input();
                UppdateraSkepp();    
                UppdateraSkott();
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
            Raylib.DrawRectangle((int)skottRektangel.x + 30, (int)skottRektangel.y - 55, 3, 50, Color.YELLOW);

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
            if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) && !synligt)
            {
                skjuter = true;
                skottRektangel.x = skeppRektangel.x;
                skottRektangel.y = skeppRektangel.y;

                // Spela upp ljudet
                Raylib.PlaySound(skottLjud);
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
            skottRektangel.y -= 20;

            // Syns skottet på fönstret?
            if (skottRektangel.y > 0)
            {
                synligt = true;
            }
            else
            {
                synligt = false;
            }
        }
    }
}

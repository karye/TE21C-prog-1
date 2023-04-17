using System;
using Raylib_cs;

namespace Shmup_2
{
    class Program
    {
        // Skapa alla globala variabler
        // Skeppets variabler
        static Texture2D skeppTextur;
        static Texture2D hjärtaTextur;
        static Texture2D hjärtaTomTextur;
        static Rectangle skeppRektangel;
        static bool skjuter = false;

        // Skottets variabler
        static Texture2D texturSkott;
        static Rectangle skottRektangel;
        static Sound skottLjud;
        static bool synligt = false;

        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "SHMUP");
            Raylib.SetTargetFPS(60);
            Raylib.InitAudioDevice();

            // Ladda in grafiken
            // Skapa skeppet
            skeppTextur = Raylib.LoadTexture(@"./resurser/space-invaders.png");
            skeppRektangel = new Rectangle(400, 500, skeppTextur.width, skeppTextur.height);
            hjärtaTextur = Raylib.LoadTexture(@"./resurser/like.png");
            hjärtaTomTextur = Raylib.LoadTexture(@"./resurser/like-tom.png");

            // Ladda in ljud
            // Skapa skott
            skottLjud = Raylib.LoadSound(@"./resurser/laser.wav");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Input();
                UppdateraSkepp();
                UppdateraSkott();
                RitaPanel();
                RitaSpel();

                Raylib.EndDrawing();
            }
        }

        /// <summary>
        /// Läser tryck på piltangenter
        /// </summary>
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

        /// <summary>
        /// Rita ut spelets figurer
        /// </summary>
        static void RitaSpel()
        {
            // Rita ut skeppet
            Raylib.DrawTexture(skeppTextur, (int)skeppRektangel.x, (int)skeppRektangel.y, Color.WHITE);

            // Rita ut skottet när spelare skjuter
            Raylib.DrawRectangle((int)skottRektangel.x + 30, (int)skottRektangel.y - 55, 3, 50, Color.YELLOW);

            // När vi skjuter rita en "muzzle-flash"
            if (skjuter)
            {
                Raylib.DrawCircle((int)skeppRektangel.x + 32, (int)skeppRektangel.y - 10, 15, Color.YELLOW);
            }
        }

        /// <summary>
        /// Rita ut panel med antal liv och poängen
        /// </summary>
        static void RitaPanel()
        {
            // Rita ut antal liv
            Raylib.DrawTexture(hjärtaTextur, 20, 20, Color.WHITE);
            Raylib.DrawTexture(hjärtaTextur, 60, 20, Color.WHITE);
            Raylib.DrawTexture(hjärtaTomTextur, 100, 20, Color.WHITE);
            Raylib.DrawTexture(hjärtaTomTextur, 140, 20, Color.WHITE);
            
            // Skriv ut antal poäng
            Raylib.DrawText("Score: 10000", 500, 20, 32, Color.BLUE);
        }

        /// <summary>
        /// Ser till att skeppet flyttar på sig
        /// </summary>
        static void UppdateraSkepp()
        {
            // Se till att skeppet inte lämnar fönstret
            skeppRektangel.x = Math.Clamp(skeppRektangel.x, 0, 800 - skeppRektangel.width);
            skeppRektangel.y = Math.Clamp(skeppRektangel.y, 0, 600 - skeppRektangel.height);
        }

        /// <summary>
        /// Ser till att skott rör på sig
        /// </summary>
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

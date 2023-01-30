/* 
@TODO
* Gravitation måste funka, dvs falla snabbare och snabbare
* Landa mjukt annars kraschar och förlorar spelet
* Landa på ett speciellt ställe
* Lägga till, 1 min på sig att landa annars Game Over
* Plocka bränsle som ligger slumpmässigt på scenen
 */

using System;
using Raylib_cs;

namespace TopDown_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(512, 480, "Raylib");
            Raylib.SetTargetFPS(60);

            // Skapa en figur
            Texture2D texturLander = Raylib.LoadTexture(@"./resurser/lander.png");
            // Skapa en hitbox till figuren
            Rectangle hitboxLander = new Rectangle(0, 0, texturLander.width, texturLander.height);

            // Figurens bränsle
            int bränsle = 100;

            // Figurens hastighet
            float hastighet = 0;

            // Gravitation
            float gravitation = 0.01f;

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLUE);

                // Rita ut figuren
                Raylib.DrawTexture(texturLander, (int)hitboxLander.x, (int)hitboxLander.y, Color.WHITE);
                // Rita ut koordinaterna
                Raylib.DrawText("x=" + hitboxLander.x, 450, 20, 18, Color.WHITE);
                Raylib.DrawText("y=" + hitboxLander.y, 450, 40, 18, Color.WHITE);

                // Rita ut bränslemängd
                if (bränsle > 10)
                {
                    Raylib.DrawRectangle(450, 60, bränsle, 10, Color.WHITE);
                }
                else
                {
                    Raylib.DrawRectangle(450, 60, bränsle, 10, Color.RED);
                }

                // Styra figuren med piltangenterna
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    hitboxLander.x += 2;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    hitboxLander.x -= 2;
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    hitboxLander.y += 2;
                }

                // Gasa uppåt
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    if (bränsle == 0)
                    {
                        // Game Over!
                    }
                    else
                    {
                        hastighet -= 0.05f;
                        bränsle -= 1;
                        Raylib.DrawRectangle((int)hitboxLander.x + 30, (int)hitboxLander.y + 50, 6, 60, Color.YELLOW);
                        Raylib.DrawRectangle((int)hitboxLander.x + 29, (int)hitboxLander.y + 50, 8, 30, Color.ORANGE);
                        Raylib.DrawRectangle((int)hitboxLander.x + 28, (int)hitboxLander.y + 50, 10, 10, Color.RED);
                    }
                }

                // Se till figuren inte lämna scenen
                // Om figurens x kommer ned till 0, stanna!
                if (hitboxLander.x <= 0)
                {
                    hitboxLander.x = 0;
                }
                // Om figurens x kommer upp till 512, stanna!
                if (hitboxLander.x >= 512 - texturLander.width)
                {
                    hitboxLander.x = 512 - texturLander.width;
                }
                // Figuren stannar på y = 0
                if (hitboxLander.y <= 0)
                {
                    hitboxLander.y = 0;
                }
                // Om figurens y kommer upp till 480, stanna!
                if (hitboxLander.y >= 480 - texturLander.height)
                {
                    hitboxLander.y = 480 - texturLander.height;

                    // Har landaren kraschat?
                    if (hastighet > 0.01f)
                    {
                        Raylib.DrawRectangle(0, 0, 512, 480, Color.RED);
                        Raylib.DrawText("Game Over", 100, 100, 50, Color.WHITE);
                    }
                }

                // När jobbar gravitationen?
                if (hitboxLander.y < 480 - texturLander.height)
                {
                    // Gravitation
                    hastighet += gravitation;   // 0.01
                    hitboxLander.y += hastighet;
                }

                // Skriv ut hastigheten
                Raylib.DrawText("v=" + hastighet, 450, 80, 18, Color.WHITE);

                Raylib.EndDrawing();
            }
        }
    }
}

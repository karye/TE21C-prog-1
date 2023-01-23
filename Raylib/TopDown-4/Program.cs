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
                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    if (bränsle == 0)
                    {
                        // Game Over!
                    }
                    else
                    {
                        hitboxLander.y -= 2;
                        bränsle -= 1;
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
                }

                // Gravitation
                hitboxLander.y += 1;

                Raylib.EndDrawing();
            }
        }
    }
}

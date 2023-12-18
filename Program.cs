using System.Numerics;
using MouvementRaylib;
using Raylib_cs;
using static Raylib_cs.Raylib;

InitWindow(1000, 1000, "Hello World");

GameObject player = new GameObject();
GameObject grid = new GameObject();
Scene main = new Scene("Laby");
Mouvement _mouv = new Mouvement();
Raylib.SetTargetFPS(60);
while (!WindowShouldClose())
{
    BeginDrawing();
    
    main.Render();

    EndDrawing();
}

CloseWindow();
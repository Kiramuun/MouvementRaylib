using System.Numerics;
using MouvementRaylib;
using Raylib_cs;

Raylib.InitWindow(1000, 1000, "Hello World");

GameObject player = new GameObject();
GameObject grid = new GameObject();
Scene main = new Scene("Laby");
Mouvement _mouv = new Mouvement();

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    
    main.Render();

    Raylib.EndDrawing();
}

Raylib.CloseWindow();
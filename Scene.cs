using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace MouvementRaylib
{
    internal class Scene
    {
        private List<GameObject> GameObjects;

        public string name;

        public Scene(string name) 
        {
            GameObjects = new List<GameObject>();
            this.name = name;
            Player player1 = new Player();
            GameObjects.Add(player1);
        }

        public void Add(GameObject _gObject) 
        {
            GameObjects.Add(_gObject);
        }

        public void Update()
        {
            foreach (GameObject _gObject in GameObjects)
            {

            }
        }

        public void Render()
        {
            Raylib.ClearBackground(Color.BLACK);

            for (int i = 100; i <= 900; i += 50) { Raylib.DrawLine(i, 100, i, 900, Color.RAYWHITE); }
            for (int i = 100; i <= 900; i += 50) { Raylib.DrawLine(100, i, 900, i, Color.RAYWHITE); }

            foreach (GameObject _gObject in GameObjects)
            {
                _gObject.Render();
            }
        }
    }
}

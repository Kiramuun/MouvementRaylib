using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using static Raylib_cs.Raylib;

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
            ClearBackground(Color.RAYWHITE);

            for (int i = 100; i <= 900; i += 50) { DrawLine(i, 100, i, 900, Color.RED); }
            for (int i = 100; i <= 900; i += 50) { DrawLine(100, i, 900, i, Color.RED); }

            foreach (GameObject _gObject in GameObjects)
            {
                _gObject.Render();
            }
        }
    }
}

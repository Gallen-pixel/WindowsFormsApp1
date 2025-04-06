using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.GameObject
{
    [Serializable]
    public class GameObject
    {
        int x;
        int y;
        int objectID;
        public readonly Bitmap[] sprite;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int ObjectID { get { return objectID; } set { objectID = value; } }
        public GameObject(Bitmap[] sprites)
        {
            sprite = sprites;
        }
        public GameObject(Bitmap[] sprites, int ID)
        {
            sprite = sprites;
            objectID = ID;
        }
    }
}

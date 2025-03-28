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
        public readonly Bitmap[] sprite;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public GameObject(Bitmap[] sprites)
        {
            sprite = sprites;
        }
    }
}

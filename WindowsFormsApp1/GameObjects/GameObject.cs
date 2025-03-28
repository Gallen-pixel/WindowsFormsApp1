using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.GameObject
{
    public class GameObject 
    {
        int x;
        int y;
        public readonly Bitmap[] sprite;

        public GameObject(Bitmap[] sprites)
        {
            sprite = sprites;
        }
    }
}

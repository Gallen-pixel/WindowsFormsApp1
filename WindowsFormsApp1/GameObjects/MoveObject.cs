using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.GameObject
{
    [Serializable]
    public class MoveObject : GameObject
    {
        int Power = 0;
        public int dX { get; private set; }
        public int dY { get; private set; }
        public void ChangeDirection(int directionX,int directionY)
        {
            dX = directionX;
            dY = directionY;
        }
        public void Move()
        {
            X += dX;
            Y += dY;
        }
        public MoveObject(Bitmap[] sprites, int ID) : base(sprites, ID) { }
        public MoveObject(Bitmap[] sprites) : base(sprites) { }
    }
}

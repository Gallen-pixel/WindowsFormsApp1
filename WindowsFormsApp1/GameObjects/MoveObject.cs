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
        int dX=0, dY=0;
        int Power = 0;

        public void Move()
        {

        }
        public MoveObject(Bitmap[] sprites) : base(sprites) { }
    }
}

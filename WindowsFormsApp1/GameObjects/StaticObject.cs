using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.GameObject
{
    public class StaticObject : GameObject
    {
        bool IsEatable = false;

        public StaticObject(Bitmap[] sprites): base(sprites) { }
    }
}

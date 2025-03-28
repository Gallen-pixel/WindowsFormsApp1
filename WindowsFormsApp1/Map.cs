using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GameObject;

namespace WindowsFormsApp1
{
    public partial class Map : Form
    {
        GameObject.StaticObject AAA;
        public Map()
        {
            InitializeComponent();
            Bitmap[] bitmaps = { Properties.Resources.WallHorizontal, Properties.Resources.WallVertical };
            AAA = new GameObject.StaticObject(bitmaps);
            Test();
        }

        void Test()
        {
            for (int x = 0; x < Levels.Level[0].GetLength(0); x++)
            {
                for (int y = 0; y < Levels.Level[0].GetLength(1); y++)
                {
                    MapGrid.Controls.Add(new ObjectControl(AAA), y, x);
                }
            }
        }
    }

}

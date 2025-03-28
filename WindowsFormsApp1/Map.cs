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
using WindowsFormsApp1.GameObjects;

namespace WindowsFormsApp1
{
    public partial class Map : Form
    {
        int[,] Level = new int[20, 30]
            {
                {30, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 33},
                {11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11},
                {11,  0, 30, 10, 10, 33,  0, 30, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 33,  0, 30, 10, 10, 33,  0, 11},
                {11,  0, 11,  0,  0, 11,  0, 11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11,  0, 11,  0,  0, 11,  0, 11},
                {11,  0, 31, 10, 10, 42,  0, 43, 10, 10, 10, 10, 10, 33,  0, 30, 10, 10, 10, 10, 10, 10, 42,  0, 43, 10, 10, 31,  0, 11},
                {11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11,  0, 11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11},
                {11,  0, 30, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 41,  0, 41, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 33,  0, 11},
                {11,  0, 11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11,  0, 11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11,  0, 11},
                {11,  0, 43, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 42,  0, 42, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 31,  0, 11},
                {11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11},
                {11,  0, 30, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 33,  0, 11},
                {11,  0, 11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11,  0, 11},
                {11,  0, 31, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 31,  0, 11},
                {11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11},
                {33, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 31},
                {11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11},
                {11,  0, 30, 10, 10, 33,  0, 30, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 33,  0, 30, 10, 10, 33,  0, 11},
                {11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11},
                {11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11},
                {11,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0, 11}
};
    
        GameObject.StaticObject AAA;
        public Map()
        {
            InitializeComponent();
            Bitmap[] bitmaps = { Properties.Resources.WallVertical };
            AAA = new GameObject.StaticObject(bitmaps);
            InitializeGrid();
        }

        void InitializeGrid()
        {
            for (int x = 0; x < Level.GetLength(0); x++)
            {

                for (int y = 0; y < Level.GetLength(1); y++)
                {
                    ObjectControl objectControl = null;
                    switch (Level[x, y])
                    {

                        case 10:
                            objectControl = new ObjectControl(ObjectPool.DeepClone(ObjectPool.HorizontalWall));
                            break;
                        case 11:
                            objectControl = new ObjectControl(ObjectPool.DeepClone(ObjectPool.VerticalWall));
                            break;
                        case 20:

                            break;
                        case 30:

                            break;
                        case 31:

                            break;
                        case 32:

                            break;
                        case 33:

                            break;
                        case 0:

                        default:

                            break;
                    }
                    if (objectControl != null)
                    {
                        MapGrid.Controls.Add(objectControl, y, x);
                    }


                }
            }

        }
    }

}

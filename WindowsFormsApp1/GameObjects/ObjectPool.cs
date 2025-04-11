using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.GameObject;

namespace WindowsFormsApp1.GameObjects
{

    public static class ObjectPool
    {
        public static StaticObject LB = new StaticObject(new Bitmap[,,] { { { Properties.Resources.LB } } });
        public static StaticObject LR = new StaticObject(new Bitmap[,,] { { { Properties.Resources.LR } } });
        public static StaticObject LRB = new StaticObject(new Bitmap[,,] { { { Properties.Resources.LRB } } });
        public static StaticObject LRT = new StaticObject(new Bitmap[,,] { { { Properties.Resources.LRT } } });
        public static StaticObject LT = new StaticObject(new Bitmap[,,] { { { Properties.Resources.LT } } });
        public static StaticObject LTB = new StaticObject(new Bitmap[,,] { { { Properties.Resources.LTB } } });
        public static StaticObject RB = new StaticObject(new Bitmap[,,] { { { Properties.Resources.RB } } });
        public static StaticObject RT = new StaticObject(new Bitmap[,,] { { { Properties.Resources.RT } } });
        public static StaticObject RTB = new StaticObject(new Bitmap[,,] { { { Properties.Resources.RTB } } });
        public static StaticObject TB = new StaticObject(new Bitmap[,,] { { { Properties.Resources.TB } } });
        public static StaticObject X = new StaticObject(new Bitmap[,,] { { { Properties.Resources.X } } });

        static Bitmap[,,] pacmanFrames = new Bitmap[,,]
        {
            {
                { Properties.Resources.pacman0, Properties.Resources.pacman1D, Properties.Resources.pacman2D, Properties.Resources.pacman1D},
                { Properties.Resources.pacman0, Properties.Resources.pacman1R, Properties.Resources.pacman2R, Properties.Resources.pacman1R},
                { Properties.Resources.pacman0, Properties.Resources.pacman1U, Properties.Resources.pacman2U, Properties.Resources.pacman1U},
                { Properties.Resources.pacman0, Properties.Resources.pacman1L, Properties.Resources.pacman2L, Properties.Resources.pacman1L},

            }
        };

        static Bitmap[,,] blueGhostFrames = new Bitmap[,,]
        {
            {
                { Properties.Resources.ghost_207},
                { Properties.Resources.ghost_207},
                { Properties.Resources.ghost_207},
                { Properties.Resources.ghost_207},
            }
        };

        public static MoveObject Pacman = new MoveObject(pacmanFrames, 50, 0, 3);
        public static MoveObject Ghost1 = new MoveObject(blueGhostFrames, 51, 1, int.MaxValue);
        public static MoveObject Ghost2 = new MoveObject(blueGhostFrames, 52, 1, int.MaxValue);
        public static MoveObject Ghost3 = new MoveObject(blueGhostFrames, 53, 1, int.MaxValue);
        public static MoveObject Ghost4 = new MoveObject(blueGhostFrames, 54, 1, int.MaxValue);





        public static T DeepClone<T>(this T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }

}

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
                { Properties.Resources.ghost_blueDown,Properties.Resources.ghost_blueDown,Properties.Resources.ghost_blueDown,Properties.Resources.ghost_blueDown},//вниз
                { Properties.Resources.ghost_blueRight,Properties.Resources.ghost_blueRight,Properties.Resources.ghost_blueRight,Properties.Resources.ghost_blueRight},//право
                { Properties.Resources.ghost_blueUp,Properties.Resources.ghost_blueUp,Properties.Resources.ghost_blueUp,Properties.Resources.ghost_blueUp},//вверх
                { Properties.Resources.ghost_blueLeft,Properties.Resources.ghost_blueLeft,Properties.Resources.ghost_blueLeft,Properties.Resources.ghost_blueLeft},//влево
            },
            {
                { Properties.Resources.ghost_blueUnder1,Properties.Resources.ghost_blueUnder2, Properties.Resources.ghost_blueUnder3,Properties.Resources.ghost_blueUnder4},//вниз
                { Properties.Resources.ghost_blueUnder1,Properties.Resources.ghost_blueUnder2, Properties.Resources.ghost_blueUnder3,Properties.Resources.ghost_blueUnder4},//право
                { Properties.Resources.ghost_blueUnder1,Properties.Resources.ghost_blueUnder2, Properties.Resources.ghost_blueUnder3,Properties.Resources.ghost_blueUnder4},//вверх
                { Properties.Resources.ghost_blueUnder1,Properties.Resources.ghost_blueUnder2, Properties.Resources.ghost_blueUnder3,Properties.Resources.ghost_blueUnder4},//влево
            },
            {
                { Properties.Resources.ghost_blueFrozen1,Properties.Resources.ghost_blueFrozen2, Properties.Resources.ghost_blueFrozen3,Properties.Resources.ghost_blueFrozen4},//вниз
                { Properties.Resources.ghost_blueFrozen1,Properties.Resources.ghost_blueFrozen2, Properties.Resources.ghost_blueFrozen3,Properties.Resources.ghost_blueFrozen4},//право
                { Properties.Resources.ghost_blueFrozen1,Properties.Resources.ghost_blueFrozen2, Properties.Resources.ghost_blueFrozen3,Properties.Resources.ghost_blueFrozen4},//вверх
                { Properties.Resources.ghost_blueFrozen1,Properties.Resources.ghost_blueFrozen2, Properties.Resources.ghost_blueFrozen3,Properties.Resources.ghost_blueFrozen4},//влево
            },
            {
                { Properties.Resources.ghost_blueFast1,Properties.Resources.ghost_blueFast2, Properties.Resources.ghost_blueFast3,Properties.Resources.ghost_blueFast4},//вниз
                { Properties.Resources.ghost_blueFast1,Properties.Resources.ghost_blueFast2, Properties.Resources.ghost_blueFast3,Properties.Resources.ghost_blueFast4},//право
                { Properties.Resources.ghost_blueFast1,Properties.Resources.ghost_blueFast2, Properties.Resources.ghost_blueFast3,Properties.Resources.ghost_blueFast4},//вверх
                { Properties.Resources.ghost_blueFast1,Properties.Resources.ghost_blueFast2, Properties.Resources.ghost_blueFast3,Properties.Resources.ghost_blueFast4},//влево
            }
        };
        static Bitmap[,,] redGhostFrames = new Bitmap[,,]
        {
            {
                { Properties.Resources.ghost_redDown,Properties.Resources.ghost_redDown,Properties.Resources.ghost_redDown,Properties.Resources.ghost_redDown},//вниз
                { Properties.Resources.ghost_redRight,Properties.Resources.ghost_redRight,Properties.Resources.ghost_redRight,Properties.Resources.ghost_redRight},//право
                { Properties.Resources.ghost_redUp,Properties.Resources.ghost_redUp,Properties.Resources.ghost_redUp,Properties.Resources.ghost_redUp},//вверх
                { Properties.Resources.ghost_redLeft,Properties.Resources.ghost_redLeft,Properties.Resources.ghost_redLeft,Properties.Resources.ghost_redLeft},//влево
            },
            {
                { Properties.Resources.ghost_redUnder1,Properties.Resources.ghost_redUnder2, Properties.Resources.ghost_redUnder3,Properties.Resources.ghost_redUnder4},//вниз
                { Properties.Resources.ghost_redUnder1,Properties.Resources.ghost_redUnder2, Properties.Resources.ghost_redUnder3,Properties.Resources.ghost_redUnder4},//право
                { Properties.Resources.ghost_redUnder1,Properties.Resources.ghost_redUnder2, Properties.Resources.ghost_redUnder3,Properties.Resources.ghost_redUnder4},//вверх
                { Properties.Resources.ghost_redUnder1,Properties.Resources.ghost_redUnder2, Properties.Resources.ghost_redUnder3,Properties.Resources.ghost_redUnder4},//влево
            },
            {
                { Properties.Resources.ghost_redFrozen1,Properties.Resources.ghost_redFrozen2, Properties.Resources.ghost_redFrozen3,Properties.Resources.ghost_redFrozen4},//вниз
                { Properties.Resources.ghost_redFrozen1,Properties.Resources.ghost_redFrozen2, Properties.Resources.ghost_redFrozen3,Properties.Resources.ghost_redFrozen4},//право
                { Properties.Resources.ghost_redFrozen1,Properties.Resources.ghost_redFrozen2, Properties.Resources.ghost_redFrozen3,Properties.Resources.ghost_redFrozen4},//вверх
                { Properties.Resources.ghost_redFrozen1,Properties.Resources.ghost_redFrozen2, Properties.Resources.ghost_redFrozen3,Properties.Resources.ghost_redFrozen4},//влево
            },
            {
                { Properties.Resources.ghost_redFast1,Properties.Resources.ghost_redFast2, Properties.Resources.ghost_redFas3,Properties.Resources.ghost_redFast4},//вниз
                { Properties.Resources.ghost_redFast1,Properties.Resources.ghost_redFast2, Properties.Resources.ghost_redFas3,Properties.Resources.ghost_redFast4},//право
                { Properties.Resources.ghost_redFast1,Properties.Resources.ghost_redFast2, Properties.Resources.ghost_redFas3,Properties.Resources.ghost_redFast4},//вверх
                { Properties.Resources.ghost_redFast1,Properties.Resources.ghost_redFast2, Properties.Resources.ghost_redFas3,Properties.Resources.ghost_redFast4},//влево
            }
        };
        static Bitmap[,,] orangeGhostFrames = new Bitmap[,,]
        {
            {
                { Properties.Resources.ghost_orangeDown,Properties.Resources.ghost_orangeDown,Properties.Resources.ghost_orangeDown,Properties.Resources.ghost_orangeDown},//вниз
                { Properties.Resources.ghost_orangeRight,Properties.Resources.ghost_orangeRight,Properties.Resources.ghost_orangeRight,Properties.Resources.ghost_orangeRight},//право
                { Properties.Resources.ghost_orangeUp,Properties.Resources.ghost_orangeUp,Properties.Resources.ghost_orangeUp,Properties.Resources.ghost_orangeUp},//вверх
                { Properties.Resources.ghost_orengeLeft,Properties.Resources.ghost_orengeLeft,Properties.Resources.ghost_orengeLeft,Properties.Resources.ghost_orengeLeft},//влево
            },
            {
                { Properties.Resources.ghost_orangeUnder1,Properties.Resources.ghost_orangeUnder2, Properties.Resources.ghost_orangeUnder3,Properties.Resources.ghost_orangeUnder4},//вниз
                { Properties.Resources.ghost_orangeUnder1,Properties.Resources.ghost_orangeUnder2, Properties.Resources.ghost_orangeUnder3,Properties.Resources.ghost_orangeUnder4},//право
                { Properties.Resources.ghost_orangeUnder1,Properties.Resources.ghost_orangeUnder2, Properties.Resources.ghost_orangeUnder3,Properties.Resources.ghost_orangeUnder4},//вверх
                { Properties.Resources.ghost_orangeUnder1,Properties.Resources.ghost_orangeUnder2, Properties.Resources.ghost_orangeUnder3,Properties.Resources.ghost_orangeUnder4},//влево
            },
            {
                { Properties.Resources.ghost_orangeFrozen1,Properties.Resources.ghost_orangeFrozen2, Properties.Resources.ghost_orangeFrozen3,Properties.Resources.ghost_orangeFrozen4},//вниз
                { Properties.Resources.ghost_orangeFrozen1,Properties.Resources.ghost_orangeFrozen2, Properties.Resources.ghost_orangeFrozen3,Properties.Resources.ghost_orangeFrozen4},//право
                { Properties.Resources.ghost_orangeFrozen1,Properties.Resources.ghost_orangeFrozen2, Properties.Resources.ghost_orangeFrozen3,Properties.Resources.ghost_orangeFrozen4},//вверх
                { Properties.Resources.ghost_orangeFrozen1,Properties.Resources.ghost_orangeFrozen2, Properties.Resources.ghost_orangeFrozen3,Properties.Resources.ghost_orangeFrozen4},//влево
            },
            {
                { Properties.Resources.ghost_orangeFast1,Properties.Resources.ghost_orangeFast2, Properties.Resources.ghost_orangeFast3,Properties.Resources.ghost_orangeFast4},//вниз
                { Properties.Resources.ghost_orangeFast1,Properties.Resources.ghost_orangeFast2, Properties.Resources.ghost_orangeFast3,Properties.Resources.ghost_orangeFast4},//право
                { Properties.Resources.ghost_orangeFast1,Properties.Resources.ghost_orangeFast2, Properties.Resources.ghost_orangeFast3,Properties.Resources.ghost_orangeFast4},//вверх
                { Properties.Resources.ghost_orangeFast1,Properties.Resources.ghost_orangeFast2, Properties.Resources.ghost_orangeFast3,Properties.Resources.ghost_orangeFast4},//влево
            }
        };
        static Bitmap[,,] pinkGhostFrames = new Bitmap[,,]
        {
            {
                { Properties.Resources.ghost_pinkDown,Properties.Resources.ghost_pinkDown,Properties.Resources.ghost_pinkDown,Properties.Resources.ghost_pinkDown},//вниз
                { Properties.Resources.ghost_pinkRight,Properties.Resources.ghost_pinkRight,Properties.Resources.ghost_pinkRight,Properties.Resources.ghost_pinkRight},//право
                { Properties.Resources.ghost_pinkUp,Properties.Resources.ghost_pinkUp,Properties.Resources.ghost_pinkUp,Properties.Resources.ghost_pinkUp},//вверх
                { Properties.Resources.ghost_pinkLeft,Properties.Resources.ghost_pinkLeft,Properties.Resources.ghost_pinkLeft,Properties.Resources.ghost_pinkLeft},//влево
            },
            {
                { Properties.Resources.ghost_pinkUnder1,Properties.Resources.ghost_pinkUnder2, Properties.Resources.ghost_pinkUnder3,Properties.Resources.ghost_pinkUnder4},//вниз
                { Properties.Resources.ghost_pinkUnder1,Properties.Resources.ghost_pinkUnder2, Properties.Resources.ghost_pinkUnder3,Properties.Resources.ghost_pinkUnder4},//право
                { Properties.Resources.ghost_pinkUnder1,Properties.Resources.ghost_pinkUnder2, Properties.Resources.ghost_pinkUnder3,Properties.Resources.ghost_pinkUnder4},//вверх
                { Properties.Resources.ghost_pinkUnder1,Properties.Resources.ghost_pinkUnder2, Properties.Resources.ghost_pinkUnder3,Properties.Resources.ghost_pinkUnder4},//влево
            },
            {
                { Properties.Resources.ghost_pinkFrozen1,Properties.Resources.ghost_pinkFrozen2, Properties.Resources.ghost_pinkFrozen3,Properties.Resources.ghost_pinkFrozen4},//вниз
                { Properties.Resources.ghost_pinkFrozen1,Properties.Resources.ghost_pinkFrozen2, Properties.Resources.ghost_pinkFrozen3,Properties.Resources.ghost_pinkFrozen4},//право
                { Properties.Resources.ghost_pinkFrozen1,Properties.Resources.ghost_pinkFrozen2, Properties.Resources.ghost_pinkFrozen3,Properties.Resources.ghost_pinkFrozen4},//вверх
                { Properties.Resources.ghost_pinkFrozen1,Properties.Resources.ghost_pinkFrozen2, Properties.Resources.ghost_pinkFrozen3,Properties.Resources.ghost_pinkFrozen4},//влево
            },
            {
                { Properties.Resources.ghost_pinkFast1,Properties.Resources.ghost_pinkFast2, Properties.Resources.ghost_pinkFast3,Properties.Resources.ghost_pinkFast4},//вниз
                { Properties.Resources.ghost_pinkFast1,Properties.Resources.ghost_pinkFast2, Properties.Resources.ghost_pinkFast3,Properties.Resources.ghost_pinkFast4},//право
                { Properties.Resources.ghost_pinkFast1,Properties.Resources.ghost_pinkFast2, Properties.Resources.ghost_pinkFast3,Properties.Resources.ghost_pinkFast4},//вверх
                { Properties.Resources.ghost_pinkFast1,Properties.Resources.ghost_pinkFast2, Properties.Resources.ghost_pinkFast3,Properties.Resources.ghost_pinkFast4},//влево
            }
        };
        public static MoveObject Pacman = new MoveObject(pacmanFrames, 50, 0, 3);
        public static MoveObject Ghost1 = new MoveObject(blueGhostFrames, 51, 1, int.MaxValue);
        public static MoveObject Ghost2 = new MoveObject(redGhostFrames, 52, 1, int.MaxValue);
        public static MoveObject Ghost3 = new MoveObject(orangeGhostFrames, 53, 1, int.MaxValue);
        public static MoveObject Ghost4 = new MoveObject(pinkGhostFrames, 54, 1, int.MaxValue);





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

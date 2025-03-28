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

    public static class  ObjectPool
    {
        public static StaticObject LB = new StaticObject(new Bitmap[] { Properties.Resources.LB });
        public static StaticObject LR = new StaticObject(new Bitmap[] { Properties.Resources.LR});
        public static StaticObject LRB = new StaticObject(new Bitmap[] { Properties.Resources.LRB });
        public static StaticObject LRT = new StaticObject(new Bitmap[] { Properties.Resources.LRT });
        public static StaticObject LT = new StaticObject(new Bitmap[] { Properties.Resources.LT });
        public static StaticObject LTB = new StaticObject(new Bitmap[] { Properties.Resources.LTB });
        public static StaticObject RB = new StaticObject(new Bitmap[] { Properties.Resources.RB });
        public static StaticObject RT = new StaticObject(new Bitmap[] { Properties.Resources.RT });
        public static StaticObject RTB = new StaticObject(new Bitmap[] { Properties.Resources.RTB });
        public static StaticObject TB = new StaticObject(new Bitmap[] { Properties.Resources.TB });
        public static StaticObject X = new StaticObject(new Bitmap[] { Properties.Resources.X });
        





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

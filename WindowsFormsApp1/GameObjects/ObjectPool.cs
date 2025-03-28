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
        public static StaticObject HorizontalWall = new StaticObject(new Bitmap[] { Properties.Resources.WallHorizontal});
        public static StaticObject VerticalWall = new StaticObject(new Bitmap[] { Properties.Resources.WallVertical});
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

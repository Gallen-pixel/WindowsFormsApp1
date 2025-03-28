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
    public partial class ObjectControl : UserControl
    {
        GameObject.GameObject gameObject;
        Timer gameTimer = new Timer();
        int CurrentAnimationIndex = 0;
        public ObjectControl(GameObject.GameObject gameObject)
        {
            InitializeComponent();
            this.gameObject = gameObject;
            Start();
        }

        void Start()
        {
            gameTimer.Interval = 100; // Интервал обновления (100 мс)
            gameTimer.Tick += new EventHandler(Animation);
            gameTimer.Start();
        }

        void Animation(object sender, EventArgs e)
        {
            if (CurrentAnimationIndex == gameObject.sprite.Length)
            {
                CurrentAnimationIndex = 0;
            }
            this.Sprite.Image = gameObject.sprite[CurrentAnimationIndex++];
        }
    }
}

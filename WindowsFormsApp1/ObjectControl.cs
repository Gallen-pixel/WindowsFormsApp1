using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public GameObject.GameObject GetClass { get { return gameObject; } }

        GameObject.GameObject gameObject;
        Timer gameTimer = new Timer();
        int CurrentAnimationIndex = 0;
        public ObjectControl(GameObject.GameObject gameObject)
        {
            InitializeComponent();
            this.gameObject = gameObject;
            Start();
        }
        public ObjectControl()
        {
            InitializeComponent();
            
            Start();
        }

        void Start()
        {
            if (gameObject !=null && gameObject.sprite.Length == 0 )
            {
                this.BackColor = Color.Transparent;
            }
            else if (gameObject != null && gameObject.sprite.Length == 1)
            {
                this.Sprite.Image = gameObject.sprite[0];
            }
            else
            {
                gameTimer.Interval = 100; // Интервал обновления (100 мс)
                gameTimer.Tick += new EventHandler(Animation);
                gameTimer.Start();
            }
        }



        void Animation(object sender, EventArgs e)
        {
            if (gameObject.sprite.Length == 0)
            {
                this.BackColor = Color.Green;
            }
            if (CurrentAnimationIndex == gameObject.sprite.Length)
            {
                CurrentAnimationIndex = 0;
            }
            this.Sprite.Image = gameObject.sprite[CurrentAnimationIndex++];
        }
    }
}

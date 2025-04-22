using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GameOver : Form
    {
        int CurrentLvl;
        public GameOver(int currentLvl)
        {
            InitializeComponent();
            CurrentLvl = currentLvl;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Repeat_Click(object sender, EventArgs e)
        {
            Map map = new Map(CurrentLvl, 0);
            map.Show();
            this.Hide();
        }
    }
}

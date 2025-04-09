
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
    public partial class Form2 : Form
    {
        public Form2(Form1 startform)
        {
            InitializeComponent();
            button6.Click += startform.ShowForm1;
            button6.Click += this.Closelvl;
        }

        private void Chooselvlclick(object sender, EventArgs e)
        {
            int lvl = int.Parse(((Button)sender).Tag.ToString());
            Map map = new Map(lvl);
            map.Show();
            this.Hide();
        }
        private void Closelvl(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}

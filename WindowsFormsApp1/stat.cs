using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class stat : Form
    {
        public stat()
        {
            InitializeComponent();
            this.Invalidate();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void Stat_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString($"Records", new Font("Bloq", 50), Brushes.White, new PointF(870, 120));
        }

        async void ReadAndDisplayFilesAsync(object sender, PaintEventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string resourcesDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\Resources"));
            string resourcePath = Path.Combine(resourcesDirectory, "PlayersScores.csv");
            String filename = resourcePath;
            string[] scores = File.ReadAllLines(filename);
            foreach (var c in scores)
            {
                e.Graphics.DrawString($"{c}", new Font("Bloq", 50), Brushes.White, new PointF(870, 200));
            }            
        }
    }
}

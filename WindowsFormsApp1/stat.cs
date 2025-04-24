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
            string[,] result = new string[File.ReadAllLines(filename).Length, 3];
            int counter = 0;
            foreach (string s in scores)
            {
                string[] temp  = s.Split(';');
                for (int i = 0; i < 3; i++)
                {
                    result[counter, i] = temp[i];                   
                }
                counter++;
            }














            place1Score.Text = result[0, 0];
            place2Score.Text = result[1, 0];
            place3Score.Text = result[2, 0];
            place4Score.Text = result[3, 0];
            place5Score.Text = result[4, 0];
            place6Score.Text = result[5, 0];
            place7Score.Text = result[6, 0];
            place8Score.Text = result[7, 0];
            
            place1Name.Text = result[0, 1];
            place2Name.Text = result[1, 1];
            place3Name.Text = result[2, 1];
            place4Name.Text = result[3, 1];
            place5Name.Text = result[4, 1];
            place6Name.Text = result[5, 1];
            place7Name.Text = result[6, 1];
            place8Name.Text = result[7, 1];

            place1Time.Text = result[0, 2];
            place2Time.Text = result[1, 2];
            place3Time.Text = result[2, 2];
            place4Time.Text = result[3, 2];
            place5Time.Text = result[4, 2];
            place6Time.Text = result[5, 2];
            place7Time.Text = result[6, 2];
            place8Time.Text = result[7, 2];
        }
    }
}

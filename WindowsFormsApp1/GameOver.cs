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
    public partial class GameOver : Form
    {
        int CurrentLvl;
        int sc;
        

        private void AddScoreAndName(int Score, string Name) 
        {            
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string resourcesDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\Resources"));
            string resourcePath = Path.Combine(resourcesDirectory, "PlayersScores.csv");
            using (StreamWriter sw = new StreamWriter(resourcePath, true))
            { 
                sw.WriteLine($"{Score};{Name};{DateTime.Now}");
                sw.Close();              
            }
        }

        public bool ValidName(string Name)
        {
            if (Name.Contains(';') || Name.Length > 6)
            {
                return false;
            }
            return true;
        }

        public GameOver(int currentLvl, int score)
        {
            InitializeComponent();
            CurrentLvl = currentLvl;
            //playerScore.Text = score.ToString();
            sc = score;
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
        private void Score_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString($"Your score: {sc} \n Enter 6 letter name", new Font("Bloq", 50), Brushes.White, new PointF(700,473));
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidName(NameSc.Text))
            {
                AddScoreAndName(sc, NameSc.Text);
                button1.Enabled = false;
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
        }

        private void NameSc_TextChanged(object sender, EventArgs e)
        {
            if (NameSc.Text.Length > 6)
            {
                NameSc.BackColor = Color.LightCoral; 
            }
            else
            {
                NameSc.BackColor = Color.Green; 
            }
        }
    }
}

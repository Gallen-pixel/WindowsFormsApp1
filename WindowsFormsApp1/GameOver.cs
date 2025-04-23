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

        private void AddScore(int Score) 
        {            
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string resourcesDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\Resources"));
            string resourcePath = Path.Combine(resourcesDirectory, "PlayersScores.csv");
            using (StreamWriter sw = new StreamWriter(resourcePath, true))
            { 
                sw.WriteLine(Score);
                sw.Close();
            }
        }
        public GameOver(int currentLvl, int score)
        {
            InitializeComponent();
            CurrentLvl = currentLvl;
            AddScore(score);
            playerScore.Text = score.ToString();
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

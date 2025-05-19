
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            Map map = new Map(lvl, 0);
            map.Show();
            this.Hide();
        }
        private void Closelvl(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            try
            {
                string targetFolder = @"C:\Users\user\source\repos\WindowsFormsApp1\WindowsFormsApp1\Resources\game\map";
                if (Directory.Exists(targetFolder))
                {
                    openFileDialog.InitialDirectory = targetFolder;
                }

                openFileDialog.Filter = "(*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    List<string> correctedLines = new List<string>();

                    string[] lines = File.ReadAllLines(filePath);

                    //  Проверка: больше 31 строки
                    if (lines.Length > 31)
                    {
                        MessageBox.Show("Ошибка: Файл содержит больше 31 строки.");
                        return;
                    }

                    foreach (string line in lines)
                    {
                        string[] cells = line.Split(',');

                        //  Проверка: больше 21 столбца
                        if (cells.Length > 21)
                        {
                            MessageBox.Show("Ошибка: Одна из строк содержит больше 21 значения.");
                            return;
                        }

                        List<string> newCells = new List<string>();

                        for (int i = 0; i < cells.Length; i++)
                        {
                            string value = cells[i].Trim();
                            if (string.IsNullOrEmpty(value))
                                value = "0";

                            if (!int.TryParse(value, out _))
                            {
                                MessageBox.Show("Ошибка: В ячейках должны быть только числа.");
                                return;
                            }

                            newCells.Add(value);
                        }

                        // Дополнить до 21 столбца нулями
                        while (newCells.Count < 21)
                        {
                            newCells.Add("0");
                        }

                        correctedLines.Add(string.Join(",", newCells));
                    }

                    // Дополнить до 31 строки строками с 21 нулём
                    while (correctedLines.Count < 31)
                    {
                        correctedLines.Add(string.Join(",", Enumerable.Repeat("0", 21)));
                    }

                    // Сохраняем файл обратно
                    File.WriteAllLines(filePath, correctedLines);

                    // Открываем в Excel
                    Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке файла: {ex.Message}");
            }
        }
    }
}

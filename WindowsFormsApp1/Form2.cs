
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

        private void ChangeCustomLvl(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл не найден.", filePath);

            string[] lines = File.ReadAllLines(filePath);

            // Проверяем, что файл содержит хотя бы 21 строку
            if (lines.Length < 21)
                throw new InvalidOperationException("Файл должен содержать минимум 21 строку.");

            for (int i = 0; i < 21; i++)
            {
                string[] elements = lines[i].Split(',');

                // Проверяем, что строка содержит минимум 31 элемент
                if (elements.Length < 31)
                    throw new InvalidOperationException($"Строка {i + 1} должна содержать минимум 31 элемент.");

                for (int j = 0; j < 31; j++)
                {
                    if (!int.TryParse(elements[j].Trim(), out int intelement))
                        throw new FormatException($"Неверный формат числа в строке {i + 1}, столбец {j + 1}.");

                    if (intelement < 50)
                    {
                        Levels.Level[4][0, i, j] = intelement;  // Предполагаем, что слой 0 — для значений <50
                    }
                    else
                    {
                        Levels.Level[4][1, i, j] = intelement;  // Предполагаем, что слой 1 — для значений >=50
                    }
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string targetFolder = @"C:\Users\Admin\Desktop\WindowsFormsApp1\WindowsFormsApp1\Resources\levelscs";
            if (Directory.Exists(targetFolder))
            {
                openFileDialog.InitialDirectory = targetFolder;
            }

            openFileDialog.Filter = "(*.csv)|*.csv";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;

            if (!File.Exists(filePath))
                return;

            // Открываем файл
            Process.Start(filePath);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            string targetFolder = @"C:\Users\Admin\Desktop\WindowsFormsApp1\WindowsFormsApp1\Resources\levelscs";
            if (Directory.Exists(targetFolder))
            {
                openFileDialog.InitialDirectory = targetFolder;
            }

            openFileDialog.Filter = "(*.csv)|*.csv";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = openFileDialog.FileName;

            try
            {
                ValidateAndFixCsvFile(filePath);
                ChangeCustomLvl(filePath);
                MessageBox.Show("Файл успешно проверен и добавлен в 5 уровень.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ValidateAndFixCsvFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл не найден.", filePath);

            string[] lines = File.ReadAllLines(filePath);
            List<string> correctedLines = new List<string>();

            HashSet<int> allowedValues = new HashSet<int>
    {
        0, 1, 2, 3, 4, 10, 11, 20, 30, 32, 33, 40, 41, 42, 43, 50, 51, 52, 53, 54, 31
    };

            int maxRows = 21;
            int maxCols = 31;

            // Словарь для подсчета специальных значений
            Dictionary<int, int> specialValuesCount = new Dictionary<int, int>
    {
        {50, 0}, {51, 0}, {52, 0}, {53, 0}, {54, 0}
    };

            for (int i = 0; i < Math.Min(lines.Length, maxRows); i++)
            {
                string[] cells = lines[i].Split(',');
                List<string> newCells = new List<string>();

                for (int j = 0; j < Math.Min(cells.Length, maxCols); j++)
                {
                    string trimmed = cells[j].Trim();
                    if (trimmed == "")
                        trimmed = "0";

                    if (!int.TryParse(trimmed, out int value))
                        throw new FormatException($"Неверный формат значения \"{trimmed}\" в строке {i + 1}.");

                    if (!allowedValues.Contains(value))
                        throw new ArgumentOutOfRangeException($"Недопустимое значение \"{value}\" в строке {i + 1}.");

                    // Увеличиваем счетчик для специальных значений
                    if (specialValuesCount.ContainsKey(value))
                        specialValuesCount[value]++;

                    newCells.Add(value.ToString());
                }

                if (cells.Length > maxCols)
                    throw new InvalidOperationException($"Строка №{i + 1} содержит больше {maxCols} значений.");

                while (newCells.Count < maxCols)
                {
                    newCells.Add("0");
                }

                correctedLines.Add(string.Join(",", newCells));
            }

            while (correctedLines.Count < maxRows)
            {
                correctedLines.Add(string.Join(",", Enumerable.Repeat("0", maxCols)));
            }

            if (lines.Length > maxRows)
                throw new InvalidOperationException($"Файл содержит больше {maxRows} строк.");

            // Проверка количества специальных значений
            foreach (var kvp in specialValuesCount)
            {
                if (kvp.Value != 1)
                    throw new InvalidOperationException($"Файл должен содержать ровно одно значение {kvp.Key}, но найдено {kvp.Value}.");
            }

            File.WriteAllLines(filePath, correctedLines);
        }
        //загружаем
        //количество строк
        //если больше то exep, если меньше - заполнить 0
        //количество элементов в строке
        //если больше то exep, если меньше - заполнить 0

    }
}


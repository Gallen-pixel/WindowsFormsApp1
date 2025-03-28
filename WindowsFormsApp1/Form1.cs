using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Form2;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public int SelectedLevel { get; set; } = 1;
        public static Form1 Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Form1();
                }
                return instance;
            }
        }

            public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Map form2 = new Map();
            form2.Show();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    

    //public partial class Form2 : Form
    //{
    //    // Размеры игрового поля и ячеек
    //    private const int CellSize = 44;
    //    private const int GridWidth = 32;
    //    private const int GridHeight = 18;

    //    // Положение Pac-Man
    //    private int pacManX = 1;
    //    private int pacManY = 1;

    //    // Направление движения Pac-Man
    //    private int pacManDirectionX = 0;
    //    private int pacManDirectionY = 0;

    //    // Игровое поле (0 - пусто, 1 - стена, 2 - еда)
    //    public int[,] grid = new int[GridWidth, GridHeight];

    //    // Изображение для стен
    //    private Image wallImage;
    //    private Image foodImage;

    //    public static Form2 instance;

    //    public static Form2 Instance
    //    {
    //        get
    //        {
    //            if (instance == null || instance.IsDisposed)
    //            {
    //                instance = new Form2();
    //            }
    //            return instance;
    //        }
    //    }

    //    private List<Ghost> ghosts;
    //    public Form2()
    //    {
    //        InitializeComponent();
    //        InitializeGame();
    //        this.KeyDown += new KeyEventHandler(Form2_KeyDown);
    //        this.Paint += new PaintEventHandler(Form2_Paint);
    //        this.DoubleBuffered = true; // Убираем мерцание


    //        // Загрузка изображения для стен
            
    //        wallImage = Properties.Resources.wall; // Замените "wall" на имя вашего изображения
    //        foodImage = Properties.Resources.food;

    //        ghosts = new List<Ghost>
    //    {
    //        new Ghost(10, 5), // Призрак 1
    //        new Ghost(15, 5), // Призрак 2
    //        new Ghost(10, 10), // Призрак 3
    //        new Ghost(15, 10)  // Призрак 4
    //    };
    //    }

    //    private void InitializeGame()
    //    {
    //        // Удалите объявление локальной переменной grid и используйте поле класса
    //        grid = new int[,]
    //        {
    //            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
    //            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
    //            {1,2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1},
    //            {1,2,1,2,2,2,2,2,2,2,2,2,2,2,2,1,2,1},
    //            {1,2,1,2,1,1,1,1,1,1,1,1,1,1,2,1,2,1},
    //            {1,2,1,2,1,2,2,2,2,2,2,2,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,1,1,1,1,1,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,2,2,2,2,1,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,2,1,1,2,1,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,2,1,2,2,1,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,2,1,1,1,1,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,2,2,2,2,2,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,1,1,1,1,1,1,1,2,1,2,1},
    //            {1,2,1,2,1,2,2,2,2,2,2,2,2,2,2,1,2,1},
    //            {1,2,1,2,1,1,1,1,1,1,1,1,1,1,1,1,2,1},
    //            {1,2,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
    //            {1,2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
    //            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
    //            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
    //            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1},
    //            {1,2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1},
    //            {1,2,1,2,2,2,2,2,2,2,2,2,2,2,2,1,2,1},
    //            {1,2,1,2,1,1,1,1,1,1,1,1,1,1,2,1,2,1},
    //            {1,2,1,2,1,2,2,2,2,2,2,2,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,1,1,1,1,1,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,2,2,2,2,1,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,2,1,1,2,1,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,2,1,2,2,1,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,2,1,1,1,1,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,2,2,2,2,2,2,1,2,1,2,1},
    //            {1,2,1,2,1,2,1,1,1,1,1,1,1,1,2,1,2,1},
    //            {1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,1}
    //        };

    //        // Запуск таймера для обновления игры
    //        Timer gameTimer = new Timer();
    //        gameTimer.Interval = 1; // Интервал обновления (100 мс)
    //        gameTimer.Tick += new EventHandler(GameTimer_Tick);
    //        gameTimer.Start();
    //    }

    //    private void Form2_Paint(object sender, PaintEventArgs e)
    //    {

    //        // Отрисовка игрового поля
    //        for (int x = 0; x < GridWidth; x++)
    //        {
    //            for (int y = 0; y < GridHeight; y++)
    //            {
    //                if (grid[x, y] == 1)
    //                {
    //                    // Отрисовка изображения стены
    //                    e.Graphics.DrawImage(wallImage, x * CellSize, y * CellSize, CellSize, CellSize);
    //                }
    //                else if (grid[x, y] == 2)
    //                {
    //                    // Отрисовка еды
    //                    e.Graphics.DrawImage(foodImage, x * CellSize, y * CellSize, CellSize, CellSize);
    //                }
    //                else
    //                {

    //                }
    //            }
    //        }

    //        // Отрисовка Pac-Man
    //        e.Graphics.FillPie(Brushes.Yellow, pacManX * CellSize, pacManY * CellSize, CellSize, CellSize, 45, 270);

    //        // Отрисовка призраков
    //        foreach (var ghost in ghosts)
    //        {
    //            e.Graphics.FillRectangle(Brushes.Red, ghost.X * CellSize, ghost.Y * CellSize, CellSize, CellSize);
    //        }
    //    }


    //    private void Form2_KeyDown(object sender, KeyEventArgs e)
    //    {
    //        // Управление Pac-Man
    //        switch (e.KeyCode)
    //        {
    //            case Keys.Up:
    //                pacManDirectionX = 0;
    //                pacManDirectionY = -1;
    //                break;
    //            case Keys.Down:
    //                pacManDirectionX = 0;
    //                pacManDirectionY = 1;
    //                break;
    //            case Keys.Left:
    //                pacManDirectionX = -1;
    //                pacManDirectionY = 0;
    //                break;
    //            case Keys.Right:
    //                pacManDirectionX = 1;
    //                pacManDirectionY = 0;
    //                break;
    //        }
    //    }

    //    private void GameTimer_Tick(object sender, EventArgs e)
    //    {
    //        // Обновление положения Pac-Man
    //        int newX = pacManX + pacManDirectionX;
    //        int newY = pacManY + pacManDirectionY;

    //        // Проверка на столкновение со стенами
    //        if (newX >= 0 && newX < GridWidth && newY >= 0 && newY < GridHeight && grid[newX, newY] != 1)
    //        {
    //            pacManX = newX;
    //            pacManY = newY;

    //            // Сбор еды
    //            if (grid[pacManX, pacManY] == 2)
    //            {
    //                grid[pacManX, pacManY] = 0;
    //            }
    //        }

    //        // Движение призраков
    //        foreach (var ghost in ghosts)
    //        {
    //            ghost.Move(grid);
    //        }

    //        // Проверка на столкновение с призраками
    //        foreach (var ghost in ghosts)
    //        {
    //            if (ghost.X == pacManX && ghost.Y == pacManY)
    //            {
    //                // Игра окончена
    //                MessageBox.Show("Игра окончена! Призрак поймал Pac-Man.");
    //                Application.Exit();
    //            }
    //        }

    //        // Перерисовка формы
    //        this.Invalidate();
    //    }

    //    private void CloseButton_Click(object sender, EventArgs e)
    //    {
    //        Form1 form1 = Form1.Instance;
    //        form1.Show();
    //        this.Hide();
    //    }


    //    public class Ghost
    //    {
    //        public int Speed { get; set; } = 1;
    //        public int X { get; set; }
    //        public int Y { get; set; }
    //        private int directionX;
    //        private int directionY;
    //        private Random random;

    //        public Ghost(int startX, int startY)
    //        {
    //            X = startX;
    //            Y = startY;
    //            random = new Random();
    //            directionX = 0;
    //            directionY = 0;
    //        }

    //        public void Move(int[,] grid)
    //        {
    //            // Случайное направление движени
    //            int newDirection = random.Next(0, 4); // 0: вверх, 1: вниз, 2: влево, 3: вправо
    //            for (int i = 0; i < Speed; i++)
    //            {
    //                switch (newDirection)
    //                {
    //                    case 0: directionX = 0; directionY = -1; break; // Вверх
    //                    case 1: directionX = 0; directionY = 1; break;  // Вниз
    //                    case 2: directionX = -1; directionY = 0; break; // Влево
    //                    case 3: directionX = 1; directionY = 0; break;  // Вправо
    //                }

    //                // Проверка на столкновение со стенами
    //                int newX = X + directionX;
    //                int newY = Y + directionY;

    //                if (newX >= 0 && newX < grid.GetLength(0) && newY >= 0 && newY < grid.GetLength(1) && grid[newX, newY] != 1)
    //                {
    //                    X = newX;
    //                    Y = newY;
    //                }
    //            }
                
    //        }
    //    }
    //}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GameObject;
using WindowsFormsApp1.GameObjects;

namespace WindowsFormsApp1
{
    public partial class Map : Form
    {
        int[,,] Level = new int[2, 21, 31]
        {
                {
                {33,10,43,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,43,10,10,10,43,10,31},
                {11,1,11,1,1,1,1,2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,1,11,1,1,1,11,1,11},
                {11,1,1,1,11,1,11,1,1,33,10,10,10,10,10,10,10,10,10,31,1,1,11,1,11,1,11,1,1,1,11},
                {11,1,10,10,32,1,11,1,1,11,1,1,1,1,1,1,1,1,1,11,1,1,11,1,1,1,30,10,10,1,11},
                {11,1,1,1,1,1,30,43,10,32,1,33,10,10,10,10,10,31,1,30,10,43,32,1,11,1,1,1,1,1,11},
                {41,10,10,10,10,1,1,11,1,1,1,11,0,0,0,0,0,11,1,1,1,11,1,1,30,10,10,10,10,10,42},
                {11,1,1,1,1,1,1,1,1,1,10,42,0,0,0,0,0,41,10,1,1,1,1,1,1,1,1,1,1,1,11},
                {11,1,11,1,11,1,11,1,11,1,1,11,0,0,0,0,0,11,1,1,11,1,11,1,11,1,11,1,11,1,11},
                {11,1,11,1,11,1,11,2,11,1,1,30,43,31,0,33,43,32,1,1,11,1,11,1,11,1,11,1,11,1,11},
                {11,1,11,1,11,1,11,1,11,1,1,1,11,1,1,1,11,1,1,1,11,1,11,1,11,1,11,1,11,1,11},
                {11,1,1,1,1,1,1,1,1,1,11,1,1,1,1,1,1,1,11,1,1,1,1,1,1,1,1,1,1,1,11},
                {41,10,1,10,1,10,10,10,10,10,40,10,1,11,1,11,1,10,40,10,10,10,10,10,10,1,10,10,10,1,11},
                {11,1,1,1,1,1,1,1,1,1,1,1,1,11,1,11,1,1,1,1,1,1,1,1,1,1,1,1,1,1,11},
                {11,1,10,10,10,10,10,10,10,1,10,10,10,42,1,41,10,10,10,1,10,10,10,10,10,10,10,10,1,1,11},
                {11,1,1,1,2,1,1,1,1,1,1,1,1,11,1,11,1,1,1,1,1,1,1,1,1,1,1,1,2,1,11},
                {41,10,10,10,10,10,1,10,10,10,10,10,1,11,1,11,1,10,10,10,10,10,10,1,10,10,10,10,10,1,11},
                {11,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,11},
                {11,1,33,10,43,10,10,10,10,10,43,10,43,10,1,10,10,10,10,10,43,10,43,10,10,10,10,10,31,1,11},
                {11,1,11,1,11,1,1,1,1,1,11,1,11,1,0,1,1,2,1,1,11,1,11,1,1,1,1,1,11,1,11},
                {11,1,1,1,1,1,11,1,11,1,1,1,1,1,1,1,11,1,11,1,1,1,1,1,11,1,11,1,1,1,11},
                {30,10,10,10,10,10,40,10,40,10,10,10,10,10,10,10,40,10,40,10,10,10,10,10,40,10,40,10,10,10,32},
                },
            {
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,51,0,0,0,54,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,52,0,0,0,53,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,50,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
            }
        };
        MoveObject pacman = ObjectPool.Pacman;
        List<MoveObject> ghosts = new List<MoveObject>();
        int CellSize = 48;
        public Map()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            InitializeEntities();
            StartGame();
        }
        public void InitializeEntities()
        {            
            Tuple<int, int> xy = CoordinatesOf(Level, pacman.ObjectID);
            pacman.X = xy.Item1;
            pacman.Y = xy.Item2;

            ghosts.Add(ObjectPool.Ghost1);
            ghosts.Add(ObjectPool.Ghost2);
            ghosts.Add(ObjectPool.Ghost3);
            ghosts.Add(ObjectPool.Ghost4);

            foreach (MoveObject Ghost in  ghosts)
            {
                xy = CoordinatesOf(Level, Ghost.ObjectID);
                Ghost.X = xy.Item1;
                Ghost.Y = xy.Item2;
            }
        }
        public static Tuple<int, int> CoordinatesOf(int [,,] matrix, int value)
        {
            int w = matrix.GetLength(1); // width
            int h = matrix.GetLength(2); // height

            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    if (matrix[1, x, y].Equals(value))
                        return Tuple.Create(x, y);
                }
            }

            return Tuple.Create(-1, -1);
        }
        void StartGame()
        {
            System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000; // Интервал обновления (1000 мс)
            gameTimer.Tick += new EventHandler(Game_tick);
            gameTimer.Start();
        }
        void DrawGrid(PaintEventArgs e)
        {
            for (int x = 0; x < Level.GetLength(1); x++)
            {

                for (int y = 0; y < Level.GetLength(2); y++)
                {
                    switch (Level[0, x, y])
                    {
                        case 10:
                            e.Graphics.DrawImage(Properties.Resources.LR, y * CellSize, x * CellSize, CellSize, CellSize);
                            break;
                        case 11:
                            e.Graphics.DrawImage(Properties.Resources.TB, y * CellSize, x * CellSize, CellSize, CellSize);
                            break;
                        case 20:
                            e.Graphics.DrawImage(Properties.Resources.X, y * CellSize, x * CellSize, CellSize, CellSize);
                            break;
                        case 30:
                            e.Graphics.DrawImage(Properties.Resources.RT, y * CellSize, x * CellSize, CellSize, CellSize);
                            break;
                        case 31:
                            e.Graphics.DrawImage(Properties.Resources.LB, y * CellSize, x * CellSize, CellSize, CellSize);

                            break;
                        case 32:
                            e.Graphics.DrawImage(Properties.Resources.LT, y * CellSize, x * CellSize, CellSize, CellSize);

                            break;
                        case 33:
                            e.Graphics.DrawImage(Properties.Resources.RB, y * CellSize, x * CellSize, CellSize, CellSize);

                            break;
                        case 40:
                            e.Graphics.DrawImage(Properties.Resources.LRT, y * CellSize, x * CellSize, CellSize, CellSize);

                            break;
                        case 41:
                            e.Graphics.DrawImage(Properties.Resources.RTB, y * CellSize, x * CellSize, CellSize, CellSize);

                            break;
                        case 42:
                            e.Graphics.DrawImage(Properties.Resources.LTB, y * CellSize, x * CellSize, CellSize, CellSize);

                            break;
                        case 43:
                            e.Graphics.DrawImage(Properties.Resources.LRB, y * CellSize, x * CellSize, CellSize, CellSize);
                            break;

                        case 1:
                            e.Graphics.DrawImage(Properties.Resources.small_coin, y * CellSize, x * CellSize, CellSize, CellSize);
                            break;
                        case 2:
                            e.Graphics.DrawImage(Properties.Resources.big_coin, y * CellSize, x * CellSize, CellSize, CellSize);
                            break;
                        case 0:

                        default:

                            break;
                    }
                }
            }
        }
        void DrawEntity(PaintEventArgs e)
        {
            for (int x = 0; x < Level.GetLength(1); x++)
            {

                for (int y = 0; y < Level.GetLength(2); y++)
                {
                    switch (Level[1, x, y])
                    {
                        case 50:
                            {
                                MoveImage(pacman, new Point(pacman.X, pacman.Y), new Point(pacman.X , pacman.Y), e);
                            }
                            break;
                        case 51:
                            {
                                MoveImage(ghosts[0], new Point(ghosts[0].X, ghosts[0].Y), new Point(ghosts[0].X, ghosts[0].Y), e);
                            }
                            break;
                        case 52:
                            {
                                MoveImage(ghosts[1], new Point(ghosts[1].X, ghosts[1].Y), new Point(ghosts[1].X, ghosts[1].Y), e);
                            }
                            break;
                        case 53:
                            {
                                MoveImage(ghosts[2], new Point(ghosts[2].X, ghosts[2].Y), new Point(ghosts[2].X, ghosts[2].Y), e);
                            }
                            break;
                        case 54:
                            {
                                MoveImage(ghosts[3], new Point(ghosts[3].X, ghosts[3].Y), new Point(ghosts[3].X, ghosts[3].Y), e);
                            }
                            break;
                        case 0:
                        default:
                            break;
                    }
                }
            }
        }
        private void Map_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        pacman.ChangeDirection(-1, 0);
                        break;
                    }
                case Keys.Down:
                    {
                        pacman.ChangeDirection(1, 0);
                        break;
                    }
                case Keys.Left:
                    {
                        pacman.ChangeDirection(0, -1);
                        break;
                    }
                case Keys.Right:
                    {
                        pacman.ChangeDirection(0,1);
                        break;
                    }
            }
        }
        void MoveImage(GameObject.GameObject name, Point pos1,Point pos2, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Black, pos1.Y*CellSize, pos1.X * CellSize, CellSize, CellSize);
            e.Graphics.DrawImage(name.sprite[0],pos2.Y * CellSize, pos2.X * CellSize, CellSize, CellSize);           
        }
        private void Game_tick(object sender, EventArgs e)
        {
            Pacman_move();
            Ghost_move();
            this.Invalidate();
        }

        void Pacman_move()
        {
            int dX = pacman.dX;
            int dY = pacman.dY;
            int x = pacman.X;
            int y = pacman.Y;
            if (Level[0, x + dX, y + dY] < 5)
            {
                Level[1, x + dX, y + dY] = 50;
                Level[1, x, y] = 0;
                Level[0, x, y] = 0;
                pacman.Move();
            }
        }

        void Ghost_move()
        {
            Random newDirection = new Random();
            foreach (MoveObject Ghost in ghosts)
            {               
                
                 // 0: вверх, 1: вниз, 2: влево, 3: вправо
                switch (newDirection.Next(0,4))
                {
                    case 0: Ghost.ChangeDirection(0, -1); break; // Вверх
                    case 1: Ghost.ChangeDirection(0, 1); break;  // Вниз
                    case 2: Ghost.ChangeDirection(-1, 0); break; // Влево
                    case 3: Ghost.ChangeDirection(1, 0); break;  // Вправо
                }

                // Проверка на столкновение со стенами
                int newX = Ghost.X + Ghost.dX;
                int newY = Ghost.Y + Ghost.dY;

                if (Level[0, Ghost.X + Ghost.dX, Ghost.Y + Ghost.dY] < 5)
                {
                    Level[1, Ghost.X + Ghost.dX, Ghost.Y + Ghost.dY] = Ghost.ObjectID;
                    Level[1, Ghost.X, Ghost.Y] = 0;
                    Ghost.Move();
                }
            }
        }
        private void Map_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e);
            DrawEntity(e);            
        }
    }
}



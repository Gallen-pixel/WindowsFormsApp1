﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp1.GameObject;
using WindowsFormsApp1.GameObjects;

namespace WindowsFormsApp1
{
    public partial class Map : Form
    {
        System.Windows.Forms.Timer gameTimer;
        SoundPlayer simpleSound;
        int[,,] Level = new int[2, 21, 31];

        MoveObject pacman = ObjectPool.DeepClone<MoveObject> (ObjectPool.Pacman);
        List<MoveObject> ghosts = new List<MoveObject>();
        int CellSize = 48;
        int CurrentLvl;
        int Score;
        
        
        public Map(int lvl, int playerscore)
        {
            CurrentLvl = lvl;
            Score = playerscore;
            InitializeComponent();
            Array.Copy( Levels.Level[lvl-1],Level, Levels.Level[lvl - 1].Length);
            RandomBuffs();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            InitializeEntities();
            StartGame();
            playSimpleSound();

        }
        public void InitializeEntities()
        {            
            Tuple<int, int> xy = CoordinatesOf(Level, pacman.ObjectID);
            pacman.X = xy.Item1;
            pacman.Y = xy.Item2;
            pacman.SetRespawn(pacman.X, pacman.Y);
            ghosts.Add(ObjectPool.DeepClone<MoveObject>(ObjectPool.Ghost1));
            ghosts.Add(ObjectPool.DeepClone<MoveObject>(ObjectPool.Ghost2));
            ghosts.Add(ObjectPool.DeepClone<MoveObject>(ObjectPool.Ghost3));
            ghosts.Add(ObjectPool.DeepClone<MoveObject>(ObjectPool.Ghost4));

            foreach (MoveObject Ghost in  ghosts)
            {
                xy = CoordinatesOf(Level, Ghost.ObjectID);
                Ghost.X = xy.Item1;
                Ghost.Y = xy.Item2;
                Ghost.SetRespawn(Ghost.X, Ghost.Y);
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
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 300; // Интервал обновления (0.3 с)
            gameTimer.Tick += new EventHandler(Game_tick);
            gameTimer.Start();
        }

        void RandomBuffs()
        {
            Random random = new Random();
            int randX = random.Next(1, Level.GetLength(1));
            int randY = random.Next(1, Level.GetLength(2));

            for (int i = 0; i < 4; i++)
            {               
                while (Level[0, randX, randY] != 1)
                {
                    randX = random.Next(1, Level.GetLength(1));
                    randY = random.Next(1, Level.GetLength(2));
                }
                Level[0, randX, randY] = 2;
            }
            for (int i = 0; i < 3; i++)
            {
                while (Level[0, randX, randY] != 1)
                {
                    randX = random.Next(1, Level.GetLength(1));
                    randY = random.Next(1, Level.GetLength(2));
                }
                Level[0, randX, randY] = 3;
            }
            for (int i = 0; i < 3; i++)
            {
                while (Level[0, randX, randY] != 1)
                {
                    randX = random.Next(1, Level.GetLength(1));
                    randY = random.Next(1, Level.GetLength(2));
                }
                Level[0, randX, randY] = 4;
            }
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
                        case 3:
                            e.Graphics.DrawImage(Properties.Resources.star, y * CellSize, x * CellSize, CellSize, CellSize);
                            break;
                        case 4:
                            e.Graphics.DrawImage(Properties.Resources.potion, y * CellSize, x * CellSize, CellSize, CellSize);
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
            MoveImage(pacman, e);
            foreach (MoveObject Ghost in ghosts)
                MoveImage(Ghost, e);
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
                case Keys.Escape:
                    {
                        gameTimer.Stop();
                        Form1 over = new Form1();
                        over.Show();
                        this.Hide();
                        simpleSound.Stop();
                        break;
                    }
            }
        }
        void MoveImage(GameObject.MoveObject obj, PaintEventArgs e)
        {
            e.Graphics.DrawImage(obj.sprite[obj.CurrentState,obj.Direction,obj.CurrentFrame], obj.Y*CellSize, obj.X*CellSize, CellSize, CellSize);           
        }
        private void Game_tick(object sender, EventArgs e)
        {
            Ghost_move();
            Pacman_move();
            HandleTimeouts();
            

            this.Invalidate();
            if (pacman.Lifes == 0)
            {
                gameTimer.Stop();
                Score += pacman.CoinsEaten;

                GameOver over = new GameOver(CurrentLvl, Score);
                over.Show();
                this.Hide();
                simpleSound.Stop();
                return;
            }

            if (IsLevelCleared())
            {
                gameTimer.Stop();
                simpleSound.Stop();
                Score += pacman.CoinsEaten;
                int nextLvl = CurrentLvl + 1;
                if (nextLvl <= Levels.Level.GetLength(0))
                {
                    Map nextMap = new Map(nextLvl, Score);
                    nextMap.Show();
                }
                else
                {
                    
                    Map firstMap = new Map(1, Score);
                    firstMap.Show();
                }
                this.Hide();
            }
        }
        void HandleTimeouts()
        {
            pacman.PowerDurationDecrease();
            pacman.TimeOut();
            foreach (MoveObject Ghost in ghosts)
            {
                Ghost.TimeOut();
                if (pacman.Power > 0)
                {
                    Ghost.SetState(pacman.Power - 1);
                }
                else
                {
                    Ghost.SetState(0);
                }
            }
            if (pacman.Power == 3)
            {
                gameTimer.Interval = 150;
            }
            else
            {
                gameTimer.Interval = 300;
            }


        }
        void Pacman_move()
        {
            if (!CheckMove(pacman) || pacman.Timeout>0)
                return;
            int newX = pacman.dX + pacman.X;
            int newY = pacman.dY + pacman.Y;
            int nextPos0 = Level[0, newX, newY];
            int nextPos1 = Level[1, newX, newY];
            if(HandleGhostCollision(nextPos1) && HandleItemCollision(newX, newY, nextPos0))
            {
                Level[1, pacman.X, pacman.Y] = 0;
                Level[1, newX, newY] = pacman.ObjectID;
                Level[0, pacman.X, pacman.Y] = 0;
                pacman.Move();
            }
            
        }
        bool HandleGhostCollision(int content)
        {
            if (content <= 50)
                return true;
            MoveObject Ghost = ghosts[content % 50 - 1];
            if (pacman.Power > Ghost.Power)
            {
                Ghost.Respawn();
                Level[1, Ghost.X, Ghost.Y] = Ghost.ObjectID;
                return true;
            }
            else
            {
                pacman.Respawn();
                Level[1, pacman.X, pacman.Y] = pacman.ObjectID;
                return false;
            }
        }
        bool HandleItemCollision(int newX, int newY,int content)
        {
            switch (content)
            {
                
                case 1:
                case 2:
                case 3:
                case 4:
                    {
                    pacman.EatCoin(content);
                    break;
                }


            }
            Level[0, newX, newY] = 0;
            return true;
        }
        bool HandlePacmanCollision(MoveObject obj, int content)
        {
            if (content == pacman.ObjectID)
            {
                if (pacman.Power > obj.Power) 
                { 
                    Level[1, obj.X, obj.Y] = 0; 
                    obj.Respawn();
                    Level[1, obj.X, obj.Y] = obj.ObjectID;
                    return false; 
                }
                else 
                { 
                    pacman.Respawn();
                    Level[1, pacman.X, pacman.Y] = pacman.ObjectID;
                    return true;
                }
            }
            return true;
        }
        bool CheckMove(MoveObject obj)
        {
            int newX = obj.X + obj.dX;
            int newY = obj.Y + obj.dY;
            int nextPos0 = Level[0, newX, newY];
            int nextPos1 = Level[1, newX, newY];
            if (nextPos0 > 5)
                return false;
            if (obj.ObjectID == 50)
            {
                return true;
            }
            else
            {
                if(nextPos1 >= 51 && nextPos1 <= 54)
                    return false;
            }
            return true;
        }
        void Ghost_move()
        {
            if (pacman.Power == 4 )
            {
                return;
            }
            Random random = new Random();
            foreach (MoveObject Ghost in ghosts)
            {
                if (Ghost.Timeout > 0)
                    continue;
                // Calculate the direction to Pacman
                int dx = Math.Sign(pacman.X - Ghost.X); // Horizontal direction to Pacman
                int dy = Math.Sign(pacman.Y - Ghost.Y); // Vertical direction to Pacman

                // Determine whether to chase or flee based on Pacman's power state
                if (pacman.Power > Ghost.Power)
                {
                    // Flee: Reverse the direction
                    dx = -dx;
                    dy = -dy;
                }

                // Create a list of possible directions, prioritized by proximity to Pacman
                List<(int dX, int dY)> possibleDirections = new List<(int dX, int dY)>
                {
                    (dx, 0),    // Horizontal movement first
                    (0, dy),    // Vertical movement second
                    (-dx, 0),   // Opposite horizontal movement
                    (0, -dy)    // Opposite vertical movement
                };

                // Shuffle directions slightly to add randomness in tie-breaking scenarios
                possibleDirections = possibleDirections.OrderBy(_ => random.Next()).ToList();

                // Try each direction until a valid one is found
                bool moved = false;
                foreach (var (dX, dY) in possibleDirections)
                {
                    Ghost.ChangeDirection(dX, dY);
                    if (CheckMove(Ghost))
                    {
                        moved = true;
                        break;
                    }
                }

                // If no valid direction was found, try reversing the current direction
                if (!moved)
                {
                    Ghost.ChangeDirection(-Ghost.dX, -Ghost.dY); // Reverse direction
                    if (CheckMove(Ghost))
                    {
                        moved = true;
                    }
                }

                // If still no valid direction, stop moving (fallback)
                if (!moved)
                {
                    Ghost.ChangeDirection(0, 0); // Stop moving
                }

                // Move the ghost and handle collisions
                int newX = Ghost.X + Ghost.dX;
                int newY = Ghost.Y + Ghost.dY;
                int nextPos1 = Level[1, newX, newY];

                if (HandlePacmanCollision(Ghost, nextPos1) && CheckMove(Ghost))
                {
                    Level[1, newX, newY] = Ghost.ObjectID; // Update the level grid
                    Level[1, Ghost.X, Ghost.Y] = 0;       // Clear the old position
                    Ghost.Move();                         // Move the ghost
                }
            }
        }
        private void Map_Paint(object sender, PaintEventArgs e)
        {
           
            DrawGrid(e);
            DrawEntity(e);
            e.Graphics.DrawString($"{Score+pacman.CoinsEaten}", new Font("Bloq", 32), Brushes.White, new PointF(1600, 435));
            e.Graphics.DrawString($"{pacman.Lifes}", new Font("Bloq", 64), Brushes.White, new PointF(1680, 220));
            
        }
        private void playSimpleSound()
        {

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string resourcesDirectory = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\Resources"));
            string resourcePath = Path.Combine(resourcesDirectory, "pac-man-1.wav");

            simpleSound = new SoundPlayer(resourcePath);
            simpleSound.PlayLooping();
            
        }

        private void Map_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        bool IsLevelCleared()
        {
            for (int x = 0; x < Level.GetLength(1); x++)
            {
                for (int y = 0; y < Level.GetLength(2); y++)
                {
                    if (Level[0, x, y] == 1)
                        return false;
                }
            }
            return true;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.GameObject
{
    [Serializable]
    public class MoveObject : GameObject
    {
        public int Power { get; private set; } = 0;
        int RespawnX = 0;
        int RespawnY = 0;
        public int Timeout { get; private set; } = 0;
        int PowerDuration = 0;
        public int Lifes { get; private set; } = 3;
        public int dX { get; private set; }
        public int dY { get; private set; }
        public int CoinsEaten { get; private set; }       
        public void Move()
        {
            X += dX;
            Y += dY;
        }
        public void ChangeDirection(int directionX, int directionY)
        {
            dX = directionX;
            dY = directionY;
        }
        public void EatCoin(int coin)
        {
            CoinsEaten += coin * 10; 
            if (coin == 2) {SetPower(2);SetPowerDuration(30);}
        }
        public void SetRespawn(int respawnX, int respawnY)
        {
            RespawnX = respawnX;
            RespawnY = respawnY;
        }
        public void Respawn()
        {
            SetTimeOut(20);
            X = RespawnX;
            Y = RespawnY;
        }
        public void SetTimeOut(int timeOut)
        {
            Timeout = timeOut;
        }
        public bool TimeOut()
        {
            if (Timeout>0)
                Timeout--;
            return Timeout>0;
        }
        private void SetPower(int power)
        {
            Power = power;
        }
        public void SetPowerDuration(int duration)
        {  
            PowerDuration = duration; 
        }
        public void PowerDurationDecrease()
        {
            if (PowerDuration > 0)
                PowerDuration--;
            else
                SetPower(0);
        }
        public MoveObject(Bitmap[] sprites, int ID, int Power,int Lifes) : base(sprites, ID) 
        { 
            this.Power = Power;
            this.Lifes = Lifes;
        }
        public MoveObject(Bitmap[] sprites, int ID, int Power) : base(sprites, ID)
        {
            this.Power = Power;
        }
        public MoveObject(Bitmap[] sprites, int ID) : base(sprites, ID) { }
        public MoveObject(Bitmap[] sprites) : base(sprites) { }
    }
}

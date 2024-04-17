using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenghtonAntForm
{
    internal class Ant
    {
        private int xPos;
        private int yPos;
        private int direction;
        //0 - North, 1 - East, 2 - South, 3 - West

        public int XPos
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public int YPos
        {
            get { return yPos; }
            set { yPos = value; }
        }
        public int Direction
        {
            get { return direction; }
            set { direction = value; }
        }
        public Ant(int xPos, int yPos, byte direction)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.direction = direction;
        }
        public void RotateRight()
        {
            direction = (direction + 1) % 4;
        }
        public void RotateLeft()
        {
            if(direction == 0)
            {
                direction = 3;
            }
            else
            {
                direction -= 1;
            }
        }
        public void Move()
        {
            switch (direction)
            {
                case 0: yPos--;break;
                case 1: xPos++;break;
                case 2: yPos++;break;
                case 3: xPos--;break;
            }
        }
    }
}

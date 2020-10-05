using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Invaders_Summative
{


    class Monster
    {
        public int monsterX;
        public int monsterY;
        public int monsterSpeed;
        public int monsterSize;
        public Color monstercolor;

        public Monster(int _monsterX, int _monsterY,  int _monsterSize, Color _monsterColor)
        {
            monsterX = _monsterX;
            monsterY = _monsterY;
            monsterSize = _monsterSize;
            monstercolor = _monsterColor;

        }

        public void MoveX(int speed)
        {
            monsterX += speed;
        }

        public void MoveBackX(int speed)
        {
            monsterX -= speed;
        }

        public void MoveY(int speed)
        {
            monsterY += speed;
        }

    }
}

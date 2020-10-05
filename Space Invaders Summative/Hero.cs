using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Space_Invaders_Summative
{
    class Hero
    {
        public int heroX;
        public int heroY;
        public int heroSpeed;
        public int heroSize;
        public Color herocolor;

        public Hero(int _heroX, int _heroY, int _heroSize, Color _heroColor)
        {
            heroX = _heroX;
            heroY = _heroY;
            heroSize = _heroSize;
            herocolor = _heroColor;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Space_Invaders_Summative
{
    class Pellet
    {
        public int pelletX;
        public int pelletY;
        public int pelletSpeed;
        public int pelletSize;
        public Color pelletColor;

        public Pellet(int _pelletX, int _pelletY, int _pelletSize, Color _pelletColor)
        {
            pelletX = _pelletX;
            pelletY = _pelletY;
            pelletSize = _pelletSize;
            pelletColor = _pelletColor;

        }

        public void PelletMoveY(int speed)
        {
            pelletY -= speed;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Invaders_Summative
{
    public partial class EndScreen : UserControl
    {
        Boolean spaceDown;
        public EndScreen()
        {
            InitializeComponent();

            

            if (GameScreen.winCondtion = true)
            {
                winOrLoseLabel.Text = "You Win!";
                scoreLabel.Text = "Your Score: " + GameScreen.score;
            }


            if (GameScreen.loseCondtion == true)
            {
                winOrLoseLabel.Text = "You Lose!";
                scoreLabel.Text = "Your Score: " + GameScreen.score;
            }

            if (spaceDown == true)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                MainScreen ms = new MainScreen();
                f.Controls.Add(ms);
            }


        }

        private void EndScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }

        private void EndScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = true;
                    break;
            }
        }
    }
}

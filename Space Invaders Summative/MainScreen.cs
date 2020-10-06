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
    public partial class MainScreen : UserControl
    {

        Boolean spaceDown = true;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {


            switch (e.KeyCode)
            {
                case Keys.Space:
                    if (spaceDown)
                    {
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        GameScreen gs = new GameScreen();
                        f.Controls.Add(gs);
                        gs.Focus();
                    }
                    break; 
            }

  
        }

        private void MainScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                 spaceDown = false;
                 break;
                   
            }
        }

    }
}

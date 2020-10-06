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


    public partial class GameScreen : UserControl
    {

        //These are referred to in the end screen
        public static Boolean winCondtion = false;
        public static Boolean loseCondtion = false;
        public static int score = 0;

        //List declaration
        Hero newHero;
        Pellet newPellet;

        //Establish lists
        List<Monster> monsterRow1 = new List<Monster>();
        List<Monster> monsterRow2 = new List<Monster>();
        List<Monster> monsterRow3 = new List<Monster>();
        List<Pellet> pelletList = new List<Pellet>();

        //Pellet counter
        int pelletCounter = 50;

        //Brushes to paint objects
        SolidBrush monsterBrush = new SolidBrush(Color.White);
        SolidBrush heroBrush = new SolidBrush(Color.Green);

        // Monster distance from left side of screen and top of screen
        int leftX = 100;
        int leftY = 50;
        int monsterDirection = 1;
        int nextDirection = 2;

        // Hero distance from left side of screen and top of screen
        int HeroLeftX = 300;
        int HeroLeftY = 350;

        //Monster move down counter
        int counter = 0;

        //Button control keys
        Boolean leftArrowDown, rightArrowDown, spaceDown;

        //Hero set-up
        Hero hero;
        int heroSpeed = 10;


        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void HitBoxCheck()
        {


            foreach (Pellet p in pelletList)
            {
                Rectangle pelletRec = new Rectangle(p.pelletX, p.pelletY, p.pelletSize, p.pelletSize);

                foreach (Monster m in monsterRow1)
                {
                    Rectangle monRec = new Rectangle(m.monsterX, m.monsterY, m.monsterSize, m.monsterSize);

                    if (pelletRec.IntersectsWith(monRec))
                    {
                        pelletList.Remove(p);
                        monsterRow1.Remove(m);
                        score = score + 100;
                        return;
                    }

                }

                foreach (Monster m in monsterRow2)
                {
                    Rectangle monRec = new Rectangle(m.monsterX, m.monsterY, m.monsterSize, m.monsterSize);

                    if (pelletRec.IntersectsWith(monRec))
                    {
                        pelletList.Remove(p);
                        monsterRow2.Remove(m);
                        score = score + 100;
                        return;
                    }

                }

                foreach (Monster m in monsterRow3)
                {
                    Rectangle monRec = new Rectangle(m.monsterX, m.monsterY, m.monsterSize, m.monsterSize);

                    if (pelletRec.IntersectsWith(monRec))
                    {
                        pelletList.Remove(p);
                        monsterRow3.Remove(m);
                        score = score + 100;
                        return;
                    }

                }

            }



        }

        public void MakeMonster()
        {
            //Row 1

            Monster newMonster1 = new Monster(leftX, leftY, 30, Color.White);
            monsterRow1.Add(newMonster1);

            Monster newMonster2 = new Monster(leftX + 60, leftY, 30, Color.White);
            monsterRow1.Add(newMonster2);

            Monster newMonster3 = new Monster(leftX + 60 + 60, leftY, 30, Color.White);
            monsterRow1.Add(newMonster3);

            Monster newMonster4 = new Monster(leftX + 60 + 60 + 60, leftY, 30, Color.White);
            monsterRow1.Add(newMonster4);

            Monster newMonster5 = new Monster(leftX + 60 + 60 + 60 + 60, leftY, 30, Color.White);
            monsterRow1.Add(newMonster5);

            Monster newMonster6 = new Monster(leftX + 60 + 60 + 60 + 60 + 60, leftY, 30, Color.White);
            monsterRow1.Add(newMonster6);

            Monster newMonster7 = new Monster(leftX + 60 + 60 + 60 + 60 + 60 + 60, leftY, 30, Color.White);
            monsterRow1.Add(newMonster7);

            Monster newMonster8 = new Monster(leftX + 60 + 60 + 60 + 60 + 60 + 60 + 60, leftY, 30, Color.White);
            monsterRow1.Add(newMonster8);

            //Row 2
            Monster newMonster9 = new Monster(leftX, leftY + 60, 30, Color.White);
            monsterRow2.Add(newMonster9);

            Monster newMonster10 = new Monster(leftX + 60, leftY + 60, 30, Color.White);
            monsterRow2.Add(newMonster10);

            Monster newMonster11 = new Monster(leftX + 60 + 60, leftY + 60, 30, Color.White);
            monsterRow2.Add(newMonster11);

            Monster newMonster12 = new Monster(leftX + 60 + 60 + 60, leftY + 60, 30, Color.White);
            monsterRow2.Add(newMonster12);

            Monster newMonster13 = new Monster(leftX + 60 + 60 + 60 + 60, leftY + 60, 30, Color.White);
            monsterRow2.Add(newMonster13);

            Monster newMonster14 = new Monster(leftX + 60 + 60 + 60 + 60 + 60, leftY + 60, 30, Color.White);
            monsterRow2.Add(newMonster14);

            Monster newMonster15 = new Monster(leftX + 60 + 60 + 60 + 60 + 60 + 60, leftY + 60, 30, Color.White);
            monsterRow2.Add(newMonster15);

            Monster newMonster16 = new Monster(leftX + 60 + 60 + 60 + 60 + 60 + 60 + 60, leftY + 60, 30, Color.White);
            monsterRow2.Add(newMonster16);

            //Row 3

            Monster newMonster17 = new Monster(leftX, leftY + 60 + 60, 30, Color.White);
            monsterRow3.Add(newMonster17);

            Monster newMonster18 = new Monster(leftX + 60, leftY + 60 + 60, 30, Color.White);
            monsterRow3.Add(newMonster18);

            Monster newMonster19 = new Monster(leftX + 60 + 60, leftY + 60 + 60, 30, Color.White);
            monsterRow3.Add(newMonster19);

            Monster newMonster20 = new Monster(leftX + 60 + 60 + 60, leftY + 60 + 60, 30, Color.White);
            monsterRow3.Add(newMonster20);

            Monster newMonster21 = new Monster(leftX + 60 + 60 + 60 + 60, leftY + 60 + 60, 30, Color.White);
            monsterRow3.Add(newMonster21);

            Monster newMonster22 = new Monster(leftX + 60 + 60 + 60 + 60 + 60, leftY + 60 + 60, 30, Color.White);
            monsterRow3.Add(newMonster22);

            Monster newMonster23 = new Monster(leftX + 60 + 60 + 60 + 60 + 60 + 60, leftY + 60 + 60, 30, Color.White);
            monsterRow3.Add(newMonster23);

            Monster newMonster24 = new Monster(leftX + 60 + 60 + 60 + 60 + 60 + 60 + 60, leftY + 60 + 60, 30, Color.White);
            monsterRow3.Add(newMonster24);

        }

        public void MakeHero()
        {
            newHero = new Hero(HeroLeftX, HeroLeftY, 20, Color.Green);
        }

        public void MakePellet()
        {
            // This pellet counter governs how fast the hero can shoot as every time the hero shoots
            pelletCounter++;
            if (spaceDown == true && pelletCounter > 20)
            {
                newPellet = new Pellet(newHero.heroX, newHero.heroY, 10, Color.Green);
                pelletList.Add(newPellet);
                pelletCounter = 0;
            }
        }

        public void OnStart()
        {
            MakeMonster();
            MoveMonster();
            MakeHero();
            MoveHero();
        }

        public void MoveMonster()
        {
            if (monsterDirection == 1)
            {
                foreach (Monster b in monsterRow1.Union(monsterRow2).Union(monsterRow3))
                {
                    b.MoveX(1);
                }
            }

            else if (monsterDirection == 2)
            {
                foreach (Monster b in monsterRow1.Union(monsterRow2).Union(monsterRow3))
                {
                    b.MoveY(1);
                }
            }

            else if (monsterDirection == 3)
            {
                foreach (Monster b in monsterRow1.Union(monsterRow2).Union(monsterRow3))
                {
                    b.MoveX(-1);
                }
            }

            //Check positions and change direction if need be

            if (monsterDirection != 2)
            {

                foreach (Monster b in monsterRow1.Union(monsterRow2).Union(monsterRow3))
                {
                    if (b.monsterX >= this.Width - 120)
                    {
                        monsterDirection = 2;
                        nextDirection = 3;
                    }
                }

                foreach (Monster b in monsterRow1.Union(monsterRow2).Union(monsterRow3))
                {
                    if (b.monsterX < 10)
                    {
                        monsterDirection = 2;
                        nextDirection = 1;
                    }
                }

            }

            else
            {
                counter++;
                if (counter >= 50)
                {
                    monsterDirection = nextDirection;
                    counter = 0;
                }
            }
        }

        public void MoveHero()
        {

            if (leftArrowDown == true && newHero.heroX > 0)
            {
                newHero.heroX -= heroSpeed;
            }

            if (rightArrowDown == true && newHero.heroX < this.Width - 120)
            {
                newHero.heroX += heroSpeed;
            }
        }

        public void MovePellet()
        {
            foreach (Pellet b in pelletList)
            {
                b.PelletMoveY(5);
            }


        }

        public void GameEndCondtions()
        {
            if (score == 2400)
            {
                winCondtion = true;
                GameEnd();
            }
            foreach (Monster m in monsterRow1.Union(monsterRow2).Union(monsterRow3))
            {
                if (m.monsterY >= this.Height - 100)
                {
                   loseCondtion = true;
                    GameEnd();
                    return;
                }
            }
        }

        public void GameEnd()
        {
            timer1.Enabled = false;
            Form f = this.FindForm();
            f.Controls.Remove(this);
            EndScreen es = new EndScreen();
            f.Controls.Add(es);
            es.Focus();

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Monster b in monsterRow1)
            {
                e.Graphics.FillRectangle(monsterBrush, b.monsterX, b.monsterY, b.monsterSize, b.monsterSize);
            }

            foreach (Monster b in monsterRow2)
            {
                e.Graphics.FillRectangle(monsterBrush, b.monsterX, b.monsterY, b.monsterSize, b.monsterSize);
            }

            foreach (Monster b in monsterRow3)
            {
                e.Graphics.FillRectangle(monsterBrush, b.monsterX, b.monsterY, b.monsterSize, b.monsterSize);
            }

            e.Graphics.FillRectangle(heroBrush, newHero.heroX, newHero.heroY, newHero.heroSize, newHero.heroSize);


            foreach (Pellet n in pelletList)
            {
                e.Graphics.FillRectangle(heroBrush, n.pelletX, n.pelletY, n.pelletSize, n.pelletSize);
            }

        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (monsterDirection == 2)
            {
                counter++;
            }

            MoveMonster();
            MoveHero();
            MakePellet();
            MovePellet();
            HitBoxCheck();
            GameEndCondtions();
            Refresh();
        }
    }

}


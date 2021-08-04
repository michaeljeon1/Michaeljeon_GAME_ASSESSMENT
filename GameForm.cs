using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Michaeljeon_GAME_ASSESSMENT
{
    public partial class GameForm : Form
    {
        Graphics g; //declare a graphics object called g so we can draw on the Form
        Spaceship spaceship = new Spaceship(); //create an instance of the Spaceship Class called spaceship
        Planet[] planet = new Planet[7];
        bool turnLeft, turnRight;
        int score, lives;
        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int x, y, width, height;//variables for the rectangle


        //declare a list  missiles from the Missile class
        List<Missile> missiles = new List<Missile>();
        List<Planet> planets = new List<Planet>();
        Random yspeed = new Random();



        public GameForm()
        {
            InitializeComponent();
            for (int i = 0; i < 7; i++)
            {
                int displacement = 10 + (i * 70);
                planets.Add(new Planet(displacement));
            }

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            // pass lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);

        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 7; i++)
                //get the graphics used to paint on the Form control
                g = e.Graphics;


            foreach (Planet p in planets)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 20);
                p.draw(g);//Draw the planet 

                p.movePlanet(g);//move the planet

                if (spaceship.spaceRec.IntersectsWith(p. planetRec))
                {
                    //reset planet[i] back to top of panel
                    p.y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    LblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }
                //if the planet reaches the bottom of the form relocate it back to the top
                if (p.y >= ClientSize.Height)
                {

                    score += 1;//update the score
                    LblScore.Text = score.ToString();// display score
                    p.y = 30;
                }

            }


            //Draw the spaceship
            spaceship.drawSpaceship(g);
            foreach (Missile m in missiles)
            {
                m.drawMissile(g);
                m.moveMissile(g);



            }



        }


        private void tmrSpaceship_Tick(object sender, EventArgs e)
        {
            if (turnRight)
            {
                spaceship.rotationAngle += 5;
            }
            if (turnLeft)
                spaceship.rotationAngle -= 5;



            Invalidate();

        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = true; }
            if (e.KeyData == Keys.Right) { turnRight = true; }

        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { turnLeft = false; }
            if (e.KeyData == Keys.Right) { turnRight = false; }

        }

        private void GameForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(spaceship.spaceRec, spaceship.rotationAngle));
            }

        }

        private void TmrShoot_Tick(object sender, EventArgs e)
        {
            foreach (Planet p in planets)
            {

                foreach (Missile m in missiles)
                {
                    if (p.planetRec.IntersectsWith(m.missileRec))
                    {



                        p.x = 600;
                       missiles.Remove(m);
                        break;
                    }
                }

            }

        }


        private void GameForm_MouseMove(object sender, MouseEventArgs e)
        {
            spaceship.moveSpaceship(e.X, e.Y);

        }

        private void LblLives_Click(object sender, EventArgs e)
        {

        }
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrPlanet.Enabled = false;
                tmrSpaceship.Enabled = false;
                MessageBox.Show("Game Over", "gameover", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TmrPlanet.Enabled = true;
                
            }
        }


        private void LblScore_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {



            }

        }
    }

}

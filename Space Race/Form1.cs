using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Space_Race
{
    public partial class spaceRace : Form
    {
        Rectangle player1 = new Rectangle(250, 400, 10, 40);
        Rectangle player2 = new Rectangle(450, 400, 10, 40);

        List<Rectangle> asteroids = new List<Rectangle>();
        List<int> asteroidSpeeds = new List<int>();
        List<string> asteroidColour = new List<string>();
        int asteroidSize = 5;

        int player1Score = 0;
        int player2Score = 0;
        int playerSpeed = 4;

        bool wDown = false;
        bool sDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;

        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);

        Random randGen = new Random();
        int randValue = 0;

        string gameState = "waiting";

        public spaceRace()
        {
            InitializeComponent();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Clear screen
            startButton.Visible = false;
            titleLabel.Visible = false;

            

            GameInitialize();
        }

        private void spaceRace_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Space:
                    if (gameState == "waiting" || gameState == "over")
                    {
                        GameInitialize();
                    }
                    break;

                case Keys.Escape:
                    if (gameState == "waiting" || gameState == "over")
                    {
                        Application.Exit();
                    }
                    break;
            }
        }

        private void spaceRace_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move player 1 & player 2

            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= playerSpeed;
                
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += playerSpeed;
                
            }

            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= playerSpeed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += playerSpeed;
            }


            //check to see if asteroids need to be created
            randValue = randGen.Next(0, 101);

            if (randValue > 70)
            {
                int y = randGen.Next(10, this.Width - asteroidSize * 2);
                asteroids.Add(new Rectangle(20, y, asteroidSize, asteroidSize));
                asteroidSpeeds.Add(randGen.Next(2, 10));
                asteroidColour.Add("white");
            }

            //move asteroids
            for (int i = 0; i < asteroids.Count(); i++)
            {
                int x = asteroids[i].X + asteroidSpeeds[i];
                asteroids[i] = new Rectangle(x, asteroids[i].Y, asteroidSize, asteroidSize);
            }


            //check if asteroids are outside of the play area and remove if is
            //check collision of asteroid and player 1 & player 2 
            for (int i = 0; i < asteroids.Count(); i++)
            {
                if (player1.IntersectsWith(asteroids[i]))
                {
                    if (asteroidColour[i] == "white")
                    {
                        player1.X = 250;
                        player1.Y = 400;
                    }

                    asteroids.RemoveAt(i);
                    asteroidSpeeds.RemoveAt(i);
                    asteroidColour.RemoveAt(i);
                }
                else if (player2.IntersectsWith(asteroids[i]))
                {
                    if (asteroidColour[i] == "white")
                    {
                        player2.X = 450;
                        player2.Y = 400;
                    }

                    asteroids.RemoveAt(i);
                    asteroidSpeeds.RemoveAt(i);
                    asteroidColour.RemoveAt(i);
                }
            }

            //check if players collide with top wall, reset players to start position
            //add points to player who collided with top wall
            if (player1.Y == 0)
            {
                player1Score++;
                p1ScoreLabel.Text = $"{player1Score}";

                player1.X = 250;
                player1.Y = 400;

                SoundPlayer player = new SoundPlayer(Properties.Resources.service_bell_daniel_simion);
                player.Play();


            }
            else if (player2.Y == 0)
            {
                player2Score++;
                p2ScoreLabel.Text = $"{player2Score}";

                player2.X = 450;
                player2.Y = 400;

                SoundPlayer player = new SoundPlayer(Properties.Resources.service_bell_daniel_simion);
                player.Play();


            }

            //check score and stop game if either player is at 5
            if (player1Score == 5)
            {
                gameTimer.Enabled = false;
                titleLabel.Visible = true;
                startButton.Visible = true;
                titleLabel.Text = "GAME OVER!";
                startButton.Text = "Play Again?";
                gameState = "over";

                
            }
            else if (player2Score == 5)
            {
                gameTimer.Enabled = false;
                titleLabel.Visible = true;
                startButton.Visible = true;
                titleLabel.Text = "GAME OVER!";
                startButton.Text = "Play Again?";
                gameState = "over";

                
            }

            Refresh();
        }

        private void spaceRace_Paint(object sender, PaintEventArgs e)
        {
            if (gameState == "waiting")
            {
                titleLabel.Text = "Space Race";
                startButton.Text = "Start";
            }
            else if (gameState == "running")
            {
                p1ScoreLabel.Text = $"Score Player 1: {player1Score}";
                p2ScoreLabel.Text = $"Score Player 2: {player2Score}";

                e.Graphics.FillRectangle(whiteBrush, player1);
                e.Graphics.FillRectangle(whiteBrush, player2);

                for (int i = 0; i < asteroids.Count(); i++)
                {
                    if (asteroidColour[i] == "white")
                    {
                        e.Graphics.FillEllipse(whiteBrush, asteroids[i]);
                    }
                }
            }
            else if (gameState == "over")
            {
                p1ScoreLabel.Text = "";
                p2ScoreLabel.Text = "";

                titleLabel.Text = "GAME OVER";
                startButton.Text = "Play Again?";
            }
        }
        public void GameInitialize()
        {
            titleLabel.Text = "";
            startButton.Text = "";

            gameTimer.Enabled = true;
            gameState = "running";
            player1Score = 0;
            player2Score = 0;
            asteroids.Clear();
            asteroidColour.Clear();
            asteroidSpeeds.Clear();

            this.Focus();
        }
    }
}

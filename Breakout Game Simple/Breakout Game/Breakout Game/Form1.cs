using System;
using System.Drawing;
using System.Windows.Forms;

namespace Breakout_Game
{
    public partial class Form1 : Form
    {

        bool goRight;
        bool goLeft;
        bool isGameOver;


        int Score;
        int Ballx;
        int Bally;
        int PlayerSpeed;

        Random rnd = new Random();

        PictureBox[] BlocksArray;
        public Form1()
        {
            InitializeComponent();
            PlatzBlocks();
        }
        private void setUpGame()
        {
            isGameOver = false;
            Score = 0;
            Ballx = 5;
            Bally = 5;
            PlayerSpeed = 17;

            TxtScore.Text = "Score : " + Score;

            Ball.Left = 383;
            Ball.Top = 286;

            Player.Left = 356;
            Player.Top = 529;


            GameTimer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Blocks")
                {
                    x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }

            }
        }

        private void GameOver(string message)
        {
            isGameOver = true;
            GameTimer.Stop();

            TxtScore.Text = "Score: " + Score + "" + message;

        }

        private void PlatzBlocks()
        {
            BlocksArray = new PictureBox[25];

            int a = 0;
            int top = 50;
            int left = 100;

            for (int i = 0; i < BlocksArray.Length; i++)
            {
                BlocksArray[i] = new PictureBox();
                BlocksArray[i].Height = 32;
                BlocksArray[i].Width = 100;
                BlocksArray[i].Tag = "Blocks";
                BlocksArray[i].BackColor = Color.White;

                if (a == 5)
                {
                    top = top + 50;
                    left = 100;
                    a = 0;
                }
                if (a < 5)
                {
                    a++;
                    BlocksArray[i].Left = left;
                    BlocksArray[i].Top = top;
                    this.Controls.Add(BlocksArray[i]);
                    left = left + 130;
                }

            }
            setUpGame();
        }

        private void removeBlocks()
        {
            foreach (PictureBox x in BlocksArray)
            {
                this.Controls.Remove(x);
            }
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            TxtScore.Text = "Score: " + Score;

            if (goLeft == true && Player.Left > 0)
            {
                Player.Left -= PlayerSpeed;
            }
            if (goRight == true && Player.Left < 700)
            {
                Player.Left += PlayerSpeed;
            }

            Ball.Left += Ballx;
            Ball.Top += Bally;

            if (Ball.Left < 0 || Ball.Left > 775)
            {
                Ballx = -Ballx;
            }
            if (Ball.Top < 0)
            {
                Bally = -Bally;
            }

            if (Ball.Bounds.IntersectsWith(Player.Bounds))
            {
                Ball.Top = 500;

                Bally = rnd.Next(5, 13) * -1;

                if (Ballx < 0)
                {
                    Ballx = rnd.Next(5, 13) * -1;
                }
                else
                {
                    Ballx = rnd.Next(5, 13);
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Blocks")
                {
                    if (Ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        Score += 1;

                        Bally = -Bally;

                        this.Controls.Remove(x);
                    }


                }
            }
            if (Score == 25)
            {
                GameOver(" Du hast gewonnen (:\nPress Enter to Play again");
            }

            if (Ball.Top > 612)
            {
                GameOver(" Du hast nicht gewonnen ):\nPress Enter to Play again ");
            }

        }
        private void KeyisDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }


        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeBlocks();
                PlatzBlocks();
            }
        }
    }
}

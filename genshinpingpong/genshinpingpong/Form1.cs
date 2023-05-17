using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace genshinpingpong
{
    public partial class Pong : Form
    {
        //location
        int _cpuDirection = 5;
        int _ballXCoordinate = 5;
        int _ballYCoordinate = 5;

        //score
        int _playerScore = 0;
        int _cpuScore = 0;

        //some physics
        int _bottomBoudary;
        int _centerPoint;
        int _xMidpoint;
        int _yMidpoint;

        //detection movement of player
        bool _playerDetectedUp;
        bool _playerDetectedDown;

        int _spaceBBarClicked = 0;

        //some tries to add particles on background...
        //List files = new List();
        //List particles = new List();
        //Random random = new Random();

        public Pong()
        {
            InitializeComponent();

            _bottomBoudary = ClientSize.Height - player.Height;
            _xMidpoint = ClientSize.Width / 2;
            _yMidpoint = ClientSize.Height / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            pongBall.Top -= _ballYCoordinate;
            pongBall.Left -= _ballXCoordinate;

            cpuplayer.Top += _cpuDirection;

            if (cpuplayer.Top < 0 || cpuplayer.Top > _bottomBoudary) { _cpuDirection = -_cpuDirection; }

            if (pongBall.Left < 0)
            {
                pongBall.Left = _xMidpoint;
                pongBall.Top = newSpot;
                _ballXCoordinate = -_ballXCoordinate;
                _cpuScore++;
                cpuScoreLabel.Text = _cpuScore.ToString();
            }

            if (pongBall.Left + pongBall.Width > ClientSize.Width)
            {
                pongBall.Left = _xMidpoint;
                pongBall.Top = newSpot;
                _ballXCoordinate = -_ballXCoordinate;
                _playerScore++;
                playerScoreLabel.Text = _playerScore.ToString();
            }

            if (pongBall.Top < 0 || pongBall.Top + pongBall.Height > ClientSize.Height) { _ballYCoordinate = -_ballYCoordinate; }

            if (pongBall.Bounds.IntersectsWith(player.Bounds) || pongBall.Bounds.IntersectsWith(cpuplayer.Bounds))
            {
                Random rand = new Random();
                int max = byte.MaxValue + 1;
                int r = rand.Next(max);
                int g = rand.Next(max);
                int b = rand.Next(max);
                Color c = Color.FromArgb(r, g, b);

                int r1 = rand.Next(max);
                int g1 = rand.Next(max);
                int b1 = rand.Next(max);
                Color c2 = Color.FromArgb(r1, g1, b1);

                player.BackColor = c;
                cpuplayer.BackColor = c2;

                _ballXCoordinate = -_ballXCoordinate;
            }

            if (_playerDetectedUp == true && player.Top > 0) { player.Top -= 10; }

            if (_playerDetectedDown == true && player.Top < _bottomBoudary) { player.Top += 10; }

            if (_playerScore >= 10) { pongTimer.Stop(); }
        }

        private void pongBall_Click(object sender, EventArgs e)
        {

        }

        private void pongBall_Click_1(object sender, EventArgs e)
        {

        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { _playerDetectedUp = false; }
            if (e.KeyCode == Keys.Down) { _playerDetectedDown = false; }

        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { _playerDetectedUp = true; }
            if (e.KeyCode == Keys.Down) { _playerDetectedDown = true; }

            if (e.KeyCode == Keys.Space)
            {
                if (_spaceBBarClicked % 2 == 0)
                {
                    pongTimer.Stop();
                }
                else
                {
                    pongTimer.Start();
                }
            }
            _spaceBBarClicked++;


        }
    }
}

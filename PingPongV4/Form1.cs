using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongV4
{
    public partial class Form1 : Form
    {
        int X = 300;
        int Y = 150;
        int Xverandern = 9;
        int Yverandern = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            
            GameTimer.Start();
            
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //Ball Versetzung
            Ball.Location = new Point(Ball.Location.X, Ball.Location.Y);
            if (Ball.Location.X <= Gamefield.Location.X)
            {
               
                Xverandern = 10;
            }
            if (Ball.Location.X >= Gamefield.Width)
            {
               
                Xverandern = -10;
            }
            if (Ball.Location.Y >= Gamefield.Height)
            {
               
               Yverandern = -5;
            }
            if (Ball.Location.Y <= Gamefield.Location.Y)
            {
               
              Yverandern =  5;
            }
        }

        private void Gamefield_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ball_Click(object sender, EventArgs e)
        {

        }



        private void Schlager_Scroll(object sender, ScrollEventArgs e)
        {
            Schläger.Location = new Point(Schläger.Location.X, Gamefield.Location.Y +
               Gamefield.Height /Schlager.Value + 10);
        }

        private void Schläger_Paint(object sender, PaintEventArgs e)
        {

        }
    }




    }

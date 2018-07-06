using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arkanoid_05072018
{
    public partial class FormGame : Form
    {

        static Random random = new Random();
        int rocketX, rocketY;

        int ball_X, ball_Y;
        int ballShift_X = 4; //max ball shift
        int ballShift_Y = 3;
        int ball_sx; // current ball shift
        int ball_sy;

        int racketShift = 10;
        int sideLX, // left side x
            sideRX, // right side x
            sideUY; // top side y

        int totalBricks;
        
        public FormGame()
        {
            InitializeComponent();
        }

        private void FormGame_Shown(object sender, EventArgs e)
        {
            GameInit();
        }

        private void GameInit()
        {
            rocketX = buttonRacket.Location.X;
            rocketY = buttonRacket.Location.Y;
            sideLX = labelLeft.Location.X + labelLeft.Width;
            sideRX = labelRight.Location.X;
            sideUY = labelTop.Location.X + labelTop.Height;

            ball_X = ball.Location.X;
            ball_Y = ball.Location.Y;
            ball_sx = ballShift_X;
            ball_sy = -ballShift_Y;
            totalBricks = 5;
            //ball.Visible = true;
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys keys = e.KeyCode;
            switch(keys)
            {
                case Keys.Left: ShiftRocket(-racketShift); break;
                case Keys.Right: ShiftRocket(racketShift); break;
                case Keys.Space: timer.Enabled = true; break;
            }
       
        }

        private void ShiftRocket(int sx)
        {
            int aX_Left = rocketX + sx;
            int aX_Right = aX_Left + buttonRacket.Width;

            if (sideLX > aX_Left) aX_Left = sideLX;
            if (sideRX < aX_Right) aX_Left = sideRX - buttonRacket.Width;

            rocketX = aX_Left;
            buttonRacket.Location = new Point(rocketX, rocketY);                        
        }

        private void MoveBall()
        {
            //bool lose = true;
            int bx1, by1, //coordinates ball shape
                bx2, by2;

            bx1 = ball_X;
            bx2 = ball_X + ball.Width;

            by1 = ball_Y;
            by2 = ball_Y + ball.Height;

            if (bx1 + ball_sx < sideLX) ball_sx = ballShift_X;
            if (bx2 + ball_sx > sideRX) ball_sx = -ballShift_X;
            if (by1 + ball_sy < sideUY) ball_sy = ballShift_Y;
            if (by2 + ball_sy > rocketY)
            {
                int rx1 = rocketX; // rocket area x
                int rx2 = rocketX + buttonRacket.Width;

                int bx0 = (bx1 + bx2) / 2; // coordinates center ball
                int by0 = (by1 + by2) / 2;

                if (rx1 <= bx0 && bx0 <= rx2)
                {
                    //lose = false;
                    ball_sy = -ballShift_Y + random.Next( -1, 2);
                } else if (rx1 <= bx2 + ball.Width && bx2 + ball.Width <= rx2)
                {
                    ball_sy = -ballShift_Y + random.Next(-1, 2);
                    ball_sx = -ballShift_X + random.Next(-1, 2);
                } else if (rx1 <= bx1 - ball.Width && bx1 - ball.Width <= rx2)
                {
                    ball_sy = -ballShift_Y + random.Next(-1, 2);
                    ball_sx = ballShift_X + random.Next(-1, 2);
                } else
                {
                    loseBall();
                }
            }
            //---move ball
            ball_X += ball_sx;
            ball_Y += ball_sy;
            ball.Location = new Point(ball_X, ball_Y);
            CrossBrick(brick1);
            CrossBrick(brick2);
            CrossBrick(brick3);
            CrossBrick(brick4);
            CrossBrick(brick5);
        }

        private void CrossBrick(Label brick)
        {
            if (brick.Visible)
            {
                int bx1, bx0, bx2,
                    by1, by0, by2;

                int rx1, rx2,
                    ry1, ry2;

                bx1 = ball_X;
                bx2 = ball_X + ball.Width;
                bx0 = (bx1 + bx2) / 2;

                by1 = ball_Y;
                by2 = ball_Y + ball.Height;
                by0 = (by1 + by2) / 2;

                rx1 = brick.Location.X;
                rx2 = rx1 + brick.Width;
                ry1 = brick.Location.Y;
                ry2 = ry1 + brick.Height;

                if(rx1 <= bx0 && bx0 <= rx2 &&
                    ry1 <= by2 && by2 <= ry2)
                {
                    DropBrick(brick);
                    ball_sy = -ball_sy;
                    return;
                }

                if (rx1 <= bx0 && bx0 <= rx2 &&
                    ry1 <= by1 && by1 <= ry2)
                {
                    DropBrick(brick);
                    ball_sy = -ball_sy;
                    return;
                }

                if (rx1 <= bx2 && bx2 <= rx2 &&
                    ry1 <= by0 && by0 <= ry2)
                {
                    DropBrick(brick);
                    ball_sy = -ball_sy;
                    return;
                }

                if (rx1 <= bx0 && bx0 <= rx2 &&
                    ry1 <= by2 && by2 <= ry2)
                {
                    DropBrick(brick);
                    ball_sx = -ball_sx;
                    return;
                }

                if (rx1 <= bx1 && bx1 <= rx2 &&
                    ry1 <= by0 && by0 <= ry2)
                {
                    DropBrick(brick);
                    ball_sx = -ball_sx;
                    return;
                }

                if ((rx1 <= bx2 && bx2 <= rx2 && ry1 <= by2 && by2 <= ry2) ||
                    (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by2 && by2 <= ry2) ||
                    (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by1 && by1 <= ry2) ||
                    (rx1 <= bx2 && bx2 <= rx2 && ry1 <= by1 && by1 <= ry2))
                {
                    DropBrick(brick);
                    ball_sx = -ball_sx;
                    ball_sy = -ball_sy;
                    return;
                }
            }
        }

        private void DropBrick(Label label)
        {
            label.Visible = false;
            totalBricks--;
            if (totalBricks == 0)
            {
                timer.Enabled = false;
                MessageBox.Show("You are Win","Game over");
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void loseBall()
        {
            timer.Enabled = false;
            MessageBox.Show("You lost ball", "Run game agane");
            DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            MoveBall();
        }

    }
}

/*
 * Интересно было сделать логику игры, все очень доступно, а главное практично.
Хотелось бы увидеть, как с точки зрения ООП написать такую программу.
сложным было уследить за логикой просчета условий отскока шарика, если это делать самому, то потребовалось бы много времени для просчета условий по отскоку и прочим условиям логики поведения шарика внутри игрового поля.
*/
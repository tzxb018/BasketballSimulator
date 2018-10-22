using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//defender needs collision detection
//keyboard shortcuts (key events are broken up into form, trackbar, and buttons)
//stats over game
//high scores
namespace Basketball
{
    public partial class Form1 : Form
    {
        public static double seconds;
        public static int gravityIndex = 5, quarterLength = 900; //in deciseconds
        public static double power = 50;
        public static int angle = 0;
        public static double bounce = 1, rimIndex = 1;
        public static int lastStartX, lastStartY; //after event placement of ball
        public static int score1, score2, period = 1;
        public static bool inHoop = false, IsBounceBack = false;
        public static int ballStartX, ballStartY; //initial poistion
        public static bool isPlayer1 = false, canStartNewQuarter = false, isBallMoving = false, is3 = false, isHorz = false;

        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            lblSound.Visible = false;
            ballStartX = picBall.Location.X;
            ballStartY = picBall.Location.Y;
            lastStartX = ballStartX;
            lastStartY = ballStartY;
            pcArrow1.Visible = false;
            pcArrow2.Visible = false;
            btnStart.Text = "Start";

            if (decisecondsForShot > 600)
            {
                int min = (int)decisecondsForShot / 600;
                int secondsOnClockAfterMin = (int)(decisecondsForShot - min * 600) / 10;
                if (decisecondsForShot % 600 < 100)
                {
                    lblTime.Text = min + " : 0" + secondsOnClockAfterMin;
                }
                else
                    lblTime.Text = min + " : " + secondsOnClockAfterMin;
            }
            else if (decisecondsForShot == 600)
            {
                lblTime.Text = "60.0";
            }
            else
            {
                if (decisecondsForShot % 600 < 100)
                {
                    if (decisecondsForShot % 10 == 0)
                        lblTime.Text = (decisecondsForShot / 10) + ".0";
                    else
                        lblTime.Text = (decisecondsForShot / 10).ToString();
                }
                else
                {
                    if (decisecondsForShot % 10 == 0)
                        lblTime.Text = (decisecondsForShot / 10) + ".0";
                    else
                        lblTime.Text = (decisecondsForShot / 10).ToString();
                }
            }
        }
        
        //*********************SHOOTING THE BALL***********************//
        double x, y;
        bool offRim = false;
        private void btnShoot_Click(object sender, EventArgs e)
        {
            shootEventStart();
        }
        public void shootEventStart()
        {
            seconds = 0;
            tmrTime.Enabled = true;
            btnShoot.Enabled = false;
            btnBasket.Enabled = false;
            btnStop.Enabled = true;
            inHoop = false;
            rimIndex = 1;
            ballStartX = picBall.Location.X;
            ballStartY = picBall.Location.Y;
            lastStartX = ballStartX;
            lastStartY = ballStartY;
            angle = trckAngle.Value;
            power = trckPower.Value;
            IsBounceBack = false;
            label1.Text = "";
            canStartNewQuarter = false;
            isBallMoving = true;
        }
        private void tmrTime_Tick(object sender, EventArgs e) //main ball movement 
        {
            
            seconds += 1; //former location of the ball
    
            //disable trackbars
            trckAngle.Enabled = false;
            trckGravity.Enabled = false;
            trckPower.Enabled = false;
                       
            //vertical movement
            double dy = 1 * YMovement(power,angle,seconds,gravityIndex); //makeshift gravity
            y = dy + lastStartY; 
          
            //horizontal movement
            double dx;
            x = picBall.Location.X;
            if (IsBounceBack == true)
            {
                dx = power * .5  * Math.Cos(angle * (3.14 / 180));
                dx /= 10;
                x -= (int)dx;

            }
            else
            {
                dx = power * Math.Cos(angle * (3.14 / 180));
                dx /= 10;
                x += (int)dx;
            }

            label1.Text += "\ndx " + (int)dx + " Time: " + seconds + " " + (int)x + ", " + (int)y; 

            //meeting with the ground event
            if (y > ground.Y1 - (picBall.Size.Height-3)) //if ball is below the ground 
            {
                bounce *= (.7);
                power *= bounce;
                seconds = 0;
                lastStartX = picBall.Location.X;
                lastStartY = picBall.Location.Y;

                if (bounce < .4) //if bounce coefficient make the bounces too small to distinguish on the screen
                {
                    y = ballStartY;
                    x = ballStartX;
                    lastStartY = ballStartY;
                    lastStartX = ballStartX;
                    doneMovement();
                    bounce = 1;
                    power = trckPower.Value;
                    inHoop = false;
                    canStartNewQuarter = true;
                }
            }

            //if ball goes off the screen
            if (x > 1000 || x < 0)
            {
                y = ballStartY;
                x = ballStartX;
                lastStartY = ballStartY;
                lastStartX = ballStartX;
                doneMovement();
                bounce = 1;
                power = trckPower.Value;
            }

            //contact with backboard
            if (IsBounceBack == false && picBall.Location.X >= Backboard.Location.X - picBall.Size.Width && picBall.Location.X <= Backboard.Location.X + 10 - picBall.Size.Width && picBall.Location.Y >= Backboard.Location.Y - picBall.Size.Height && picBall.Location.Y <= Backboard.Location.Y + Backboard.Size.Height)
            {
                rimIndex = -1;
                lastStartX = (int)picBall.Location.X;
                //lastStartY = (int)picBall.Location.Y;
                IsBounceBack = true; //make sure the background bounce is only being read once
                //changing placement of lable
                lblSound.Location = new Point(rim.Location.X - 37, rim.Location.Y + 14);
                lblSound.Text = "Boink";
                tmrSoundEffect.Enabled = true;
            }

            //contact with pole
            if (picBall.Location.X >= pole.X1 - picBall.Size.Width && picBall.Location.X <= pole.X1 + 10 - picBall.Size.Width && picBall.Location.Y >= pole.Y1 - picBall.Size.Height)
            {
                rimIndex = -1;
                lastStartX = (int)picBall.Location.X;
                IsBounceBack = true;
            }

            //contact with rim
            if (offRim == false)
            {
                if (picBall.Location.X >= rim.Location.X - picBall.Size.Width && picBall.Location.X < (rim.Location.X + 2))
                {
                    if (picBall.Location.Y >= rim.Location.Y - picBall.Size.Height + 5 && picBall.Location.Y <= rim.Location.Y)
                    {
                        offRim = true;
                        //changing placement of lable
                        lblSound.Location = new Point(rim.Location.X - 37, rim.Location.Y + 14);
                        lblSound.Text = "Clink";
                        tmrSoundEffect.Enabled = true;
                        if (IsBounceBack == true)
                        {
                            IsBounceBack = false;
                            rimIndex = 1;
                            lastStartX = (int)picBall.Location.X;
                            //lastStartY = (int)picBall.Location.Y;

                        }
                        else
                        {
                            IsBounceBack = true;
                            rimIndex = -1;
                            lastStartX = (int)picBall.Location.X;
                            //lastStartY = (int)picBall.Location.Y;

                        }
                    }
                }
            }

            
            
            //if ball goes into hoop (tip)
            if (picBall.Location.X >= rim.Location.X + 2 && picBall.Location.X <= (rim.Location.X + rim.Size.Width) - 2)
            {
                if (picBall.Location.Y >= rim.Location.Y - 7 && picBall.Location.Y <= rim.Location.Y + 10)
                {
                    inHoop = true;
                    power *= .2;
                }
            }

            if (inHoop == true)
            {
                if (picBall.Location.X >= rim.Location.X - 10 && picBall.Location.X <= (rim.Location.X + rim.Size.Width) + 10 && picBall.Location.Y >= rim.Location.Y + 15 && picBall.Location.Y <= rim.Location.Y + 45)
                {
                    if (isPlayer1)
                    {
                        if (is3)
                            score1 += 3;
                        else
                            score1 += 2;
                    }
                    else
                    {
                        if (is3)
                            score2 += 3;
                        else
                            score2 += 2;
                    }

                    if (score1 < 10)
                        lblScore1.Text = "0" + score1.ToString();
                    else
                        lblScore1.Text = score1.ToString();

                    if (score2 < 10)
                        lblScore2.Text = "0" + score2.ToString();
                    else
                        lblScore2.Text = score2.ToString();

                    

                    y = ballStartY;
                    x = ballStartX;
                    lastStartY = ballStartY;
                    lastStartX = ballStartX;
                    doneMovement();
                    bounce = 1;
                    power = trckPower.Value;
                    seconds = 0;
                    inHoop = false;
                    //changing placement of lable
                    lblSound.Location = new Point(rim.Location.X - 37, rim.Location.Y + 14);
                    lblSound.Text = "Swish";
                    tmrSoundEffect.Enabled = true;
                    //screen change with text
                    tmrChangeBack.Enabled = true;
                     
                }
            }

            //new location of the ball
            picBall.Location = new Point((int)x,(int)y);
        }
        public double YMovement(double speed, double theta, double time, double gravity) //makeshift gravity
        {
            double a = Math.Sin(theta * (Math.PI / 180));
            //speed = speed;
            return (((speed * a * -10) * time + gravity * Math.Pow(time, 2)) / 100); //s = ut + .5at^2
        }
        public double XMovement(double speed, double theta, double time)
        {
            return ((speed * Math.Cos(theta * (Math.PI / 180)) * time) / 10); //s = d/t
        }
        public void doneMovement()
        {
            isBallMoving = false;
            seconds = 0;
            //bounceSec = 0;
            tmrTime.Enabled = false;
            trckAngle.Enabled = true;
            trckGravity.Enabled = true;
            trckPower.Enabled = true;
            if (decisecondsForShot > 0)
            {
                btnShoot.Enabled = true;
                btnBasket.Enabled = true;
                btnStop.Enabled = false;
            }
            else
            {
                btnStart.Enabled = true;
                btnShoot.Enabled = false;
                btnStop.Enabled = false;
                trckAngle.Enabled = false;
                trckGravity.Enabled = false;
                trckPower.Enabled = false;
                tmrTimeForShooting.Enabled = false;
                btnBasket.Enabled = false;
                //tmrBuzzer.Enabled = true;
            }
            inHoop = false;
            rimIndex = 1;
            angle = trckAngle.Value;
            offRim = false;
            canStartNewQuarter = true;
        }

        //*****************TRACKBARS*****************************************//
        private void trckGravity_Scroll(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush b2 = new SolidBrush(Color.White);
            for (double t = 1; t < 30; t += 1)
            {
                double dx;
                dx = power * Math.Cos(angle * (3.14 / 180));
                dx /= 10;
                g.FillEllipse(b2, (int)((ballStartX) + (int)dx * t), (int)(picBall.Location.Y + ((picBall.Size.Height) / 2) + YMovement(power, angle, t - 1, gravityIndex)), 4, 4);
            }

            gravityIndex = trckGravity.Value;
            if (gravityIndex == 5)
            {
                lblGravityText.Text = "Gravity: " + gravityIndex.ToString() + " (normal)";
            }
            else
                lblGravityText.Text = "Gravity: " + gravityIndex.ToString();

            SolidBrush b = new SolidBrush(Color.Black);
            for (double t = 1; t < 30; t += 1)
            {
                double dx;
                dx = power * Math.Cos(angle * (3.14 / 180));
                dx /= 10;
                g.FillEllipse(b, (int)((ballStartX) + (int)dx * t), (int)(picBall.Location.Y + ((picBall.Size.Height) / 2) + YMovement(power, angle, t - 1, gravityIndex)), 4, 4);
            }
            redraw();
        }
        private void trckGravity_MouseDown(object sender, MouseEventArgs e)
        {
            trckGravity.Enabled = true;
        }
        private void trckGravity_MouseUp(object sender, MouseEventArgs e)
        {
            trckGravity.Enabled = false;
            trckGravity.Enabled = true;
        }
        private void trckGravity_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void trckGravity_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void trckPower_Scroll(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush b2 = new SolidBrush(Color.White);
            for (double t = 1; t < 30; t += 1)
            {
                double dx;
                dx = power * Math.Cos(angle * (3.14 / 180));
                dx /= 10;
                g.FillEllipse(b2, (int)((ballStartX  ) + (int)dx * t), (int)(picBall.Location.Y + ((picBall.Size.Height)/2) + YMovement(power, angle, t - 1, gravityIndex)), 4, 4);
            }


            power = trckPower.Value;
            angle = trckAngle.Value;
            lblPowerText.Text = "Power: " + power.ToString();
            label2.Text = "";

            label2.Text = "";
            SolidBrush b = new SolidBrush(Color.Black);
            for (double t = 1; t < 30; t += 1)
            {
                double dx;
                dx = power * Math.Cos(angle * (3.14 / 180));
                dx /= 10;
                g.FillEllipse(b, (int)((ballStartX) + (int)dx * t), (int)(picBall.Location.Y + ((picBall.Size.Height) / 2)  + YMovement(power, angle, t - 1, gravityIndex)), 4, 4);
            }
            redraw();
        }
        private void trckPower_MouseDown(object sender, MouseEventArgs e)
        {
            trckPower.Enabled = true;
        }
        private void trckPower_MouseUp(object sender, MouseEventArgs e)
        {
            trckPower.Enabled = false;
            trckPower.Enabled = true;
        }
        private void trckPower_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void trckPower_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void trckAngle_Scroll(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush b2 = new SolidBrush(Color.White);
            for (double t = 1; t < 30; t += 1)
            {
                double dx;
                dx = power * Math.Cos(angle * (3.14 / 180));
                dx /= 10;
                g.FillEllipse(b2, (int)((ballStartX) + (int)dx * t), (int)(picBall.Location.Y + ((picBall.Size.Height) / 2) + YMovement(power, angle, t - 1, gravityIndex)), 4, 4);
            }

            angle = trckAngle.Value;
            lblAngleText.Text = "Angle: " + angle.ToString();

            SolidBrush b = new SolidBrush(Color.Black);
            for (double t = 1; t <30; t += 1)
            {
                double dx;
                dx = power * Math.Cos(angle * (3.14 / 180));
                dx /= 10;
                g.FillEllipse(b, (int)((ballStartX) + (int)dx * t), (int)(picBall.Location.Y + ((picBall.Size.Height) / 2) + YMovement(power, angle, t - 1, gravityIndex)), 4, 4);
                
            }
            redraw();
        }
        private void trckAngle_MouseDown(object sender, MouseEventArgs e)
        {
            trckAngle.Enabled = true;
        }
        private void trckAngle_MouseUp(object sender, MouseEventArgs e)
        {
            trckAngle.Enabled = false;
            trckAngle.Enabled = true;
        }
        private void trckAngle_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        private void trckAngle_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        //*****************************HOOP*********************************//
        private void btnBasket_Click(object sender, EventArgs e)
        {
            moveBasket();
            btnBasket.Enabled = false;
            btnBasket.Enabled = true;
        }
        public void moveBasket()
        {
            Random gen = new Random();
            int x, y;
            x = gen.Next(150, 800);
            y = gen.Next(375, 475);

            rim.Location = new Point(x, y);
            Backboard.Location = new Point(x + 31, y - 24);
            net1.X1 = rim.Location.X;
            net1.X2 = rim.Location.X + 6;
            net1.Y1 = rim.Location.Y + 4;
            net1.Y2 = net1.Y1 + 30;
            net2.X1 = net1.X1 + 31;
            net2.X2 = net2.X1 - 6;
            net2.Y1 = rim.Location.Y + 4;
            net2.Y2 = net2.Y1 + 30;
            net3.X1 = net1.X2;
            net3.X2 = net2.X2;
            net3.Y1 = net1.Y2;
            net3.Y2 = net2.Y2;
            pole.X1 = Backboard.Location.X + 4;
            pole.X2 = pole.X1;
            pole.Y1 = Backboard.Location.Y + 14;
            pole.Y2 = ground.Y1;

            double dist = Math.Sqrt(Math.Pow(x - ballStartX, 2) + Math.Pow(y - ballStartY, 2));

            if (dist > 450)
            {
                is3 = true;
                rim.BorderColor = Color.Lime;
            }
            else
            {
                is3 = false;
                rim.BorderColor = Color.Orange;
            }
        }
        public void redraw()
        {
            rim.Visible = false;
            rim.Visible = true;
            Backboard.Visible = false;
            Backboard.Visible = true;
            net1.Visible = false;
            net1.Visible = true;
            net2.Visible = false;
            net2.Visible = true;
            net3.Visible = false;
            net3.Visible = true;
            ground.Visible = false;
            ground.Visible = true;
            pole.Visible = false;
            pole.Visible = true;
        }
        
        //**************************STOPPING THE BALL**********************// 
        private void btnStop_Click(object sender, EventArgs e)
        {
            seconds = 0;
            picBall.Location = new Point(ballStartX, ballStartY);
            tmrTime.Enabled = false;
            trckAngle.Enabled = true;
            trckGravity.Enabled = true;
            trckPower.Enabled = true;
            lastStartX = ballStartX;
            lastStartY = ballStartY;
            bounce = 1;
            power = trckPower.Value;
            if (decisecondsForShot > 0)
                btnShoot.Enabled = true;

            doneMovement();
            tmrTime.Enabled = false;
            canStartNewQuarter = true;
        }    
        
        

        //*****************SCREEN CHANGING TIMERS**************************//
        int timeForBack = 0;
        private void tmrChangeBack_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
            timeForBack++;
            if (timeForBack > 3)
            {
                tmrChangeBack.Enabled = false;
                this.BackColor = Color.White;
                timeForBack = 0;
                moveBasket();
            }

        }
        int timeForSound = 0;
        private void tmrSoundEffect_Tick(object sender, EventArgs e)
        {
            lblSound.Visible = true;
            timeForSound++;
            if (timeForSound > 2)
            {
                tmrSoundEffect.Enabled = false;
                timeForSound = 0;
                lblSound.Visible = false;
            }
        }

        //********************CHANGING THE QUARTER************************//
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isPlayer1)
            {
                isPlayer1 = false;
            }
            else
            {
                isPlayer1 = true;
            }

            btnStart.Enabled = false;
            btnShoot.Enabled = true;
            trckAngle.Enabled = true;
            trckGravity.Enabled = true;
            trckPower.Enabled = true;
            tmrTimeForShooting.Enabled = true;
            btnBasket.Enabled = true;
            lblPeriod.Text = period.ToString();
            moveBasket();

            if (isPlayer1)
            {
                pcArrow1.Visible = true;
                pcArrow2.Visible = false;
            }
            else
            {
                pcArrow2.Visible = true;
                pcArrow1.Visible = false;
            }

            decisecondsForShot = quarterLength;
            Graphics g = this.CreateGraphics();
            SolidBrush b = new SolidBrush(Color.Black);
            for (double t = 1; t < 30; t += 1)
            {
                double dx;
                dx = power * Math.Cos(angle * (3.14 / 180));
                dx /= 10;
                g.FillEllipse(b, (int)((ballStartX) + (int)dx * t), (int)(picBall.Location.Y + ((picBall.Size.Height) / 2) + YMovement(power, angle, t - 1, gravityIndex)), 4, 4);
            }
            redraw();
        }
        double decisecondsForShot = quarterLength;
        private void tmrTimeForShooting_Tick(object sender, EventArgs e)
        {
            decisecondsForShot--;
            if (decisecondsForShot > 600)
            {
                int min = (int)decisecondsForShot / 600;
                int secondsOnClockAfterMin = (int)(decisecondsForShot - min * 600) / 10;
                if (decisecondsForShot % 600 < 100)
                {
                    lblTime.Text = min + " : 0" + secondsOnClockAfterMin;
                }
                else
                    lblTime.Text = min + " : " + secondsOnClockAfterMin;
            }
            else if (decisecondsForShot == 600)
            {
                lblTime.Text = "60.0";
            }
            else
            {
                if (decisecondsForShot % 600 < 100)
                {
                    if (decisecondsForShot % 10 == 0)
                        lblTime.Text = (decisecondsForShot / 10) + ".0";
                    else
                        lblTime.Text = (decisecondsForShot / 10).ToString();
                }
                else
                {
                    if (decisecondsForShot % 10 == 0)
                        lblTime.Text = (decisecondsForShot / 10) + ".0";
                    else
                        lblTime.Text = (decisecondsForShot / 10).ToString();
                }
            }

            if (decisecondsForShot == 0)
            {
                this.BackColor = Color.White;
                tmrTimeForShooting.Enabled = false;
                lblTime.Text = "00 : 00";
                endQuarter();
            }

        }
        DialogResult result;
        private void endQuarter()
        {
             //time is already zero. Need somehting to check to see if ball is still moving or not
            if (isBallMoving == false)
            {
                btnStart.Enabled = true;
                btnShoot.Enabled = false;
                btnStop.Enabled = false;
                trckAngle.Enabled = false;
                trckGravity.Enabled = false;
                trckPower.Enabled = false;
                tmrTimeForShooting.Enabled = false;
                btnBasket.Enabled = false;
                
            }

            tmrBuzzer.Enabled = true;
            btnStart.Text = "Continue";

            if (!isPlayer1)
            {
                period++;
            }

            if (period > 4) 
            {
                if (!isPlayer1 && score2 != score1)
                {
                    btnEnd.Visible = true;
                    btnStart.Enabled = false;
                }
                else
                {
                    lblPeriod.Text = "OT";
                }
            }

            if (decisecondsForShot > 600)
            {
                int min = (int)decisecondsForShot / 600;
                int secondsOnClockAfterMin = (int)(decisecondsForShot - min * 600) / 10;
                if (decisecondsForShot % 600 < 100)
                {
                    lblTime.Text = min + " : 0" + secondsOnClockAfterMin;
                }
                else
                    lblTime.Text = min + " : " + secondsOnClockAfterMin;
            }
            else if (decisecondsForShot == 600)
            {
                lblTime.Text = "60.0";
            }
            else
            {
                if (decisecondsForShot % 600 < 100)
                {
                    if (decisecondsForShot % 10 == 0)
                        lblTime.Text = (decisecondsForShot / 10) + ".0";
                    else
                        lblTime.Text = (decisecondsForShot / 10).ToString();
                }
                else
                {
                    if (decisecondsForShot % 10 == 0)
                        lblTime.Text = (decisecondsForShot / 10) + ".0";
                    else
                        lblTime.Text = (decisecondsForShot / 10).ToString();
                }
            }
        }
        private void newGame()
        {
            score1 = 0;
            score2 = 0;
            lblScore1.Text = "00";
            lblScore2.Text = "00";
            isPlayer1 = true;
            period = 1;
            decisecondsForShot = quarterLength;
            btnStart.Text = "Start";
            btnEnd.Visible = false;
        }
        private void tmrBuzzer_Tick(object sender, EventArgs e)
        {
            scoreBoard.BorderColor = Color.Red;
            timeForBack++;
            lblBuzzer.Visible = true;
            if (timeForBack > 5)
            {
                tmrBuzzer.Enabled = false;
                scoreBoard.BorderColor = Color.Black;
                timeForBack = 0;
                lblBuzzer.Visible = false;
            }
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (period > 4)
            {
                if (score1 > score2)
                {
                    result = MessageBox.Show("Player 1 wins!! Want to play again?", "Game Over", MessageBoxButtons.YesNo);
                }
                else if (score2 > score1)
                {
                    result = MessageBox.Show("Player 2 wins!! Want to play again?", "Game Over", MessageBoxButtons.YesNo);
                }

                if (result == DialogResult.Yes)
                {
                    newGame();
                    btnStart.Enabled = true;
                }
                else
                {
                    Close();
                }
            }
        }

       

        //**************KEY EVENTS FOR ALL BUTTONS*********************//
        private void btnStart_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void btnStart_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        //Form 1  
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            

        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //*************************************************************//
        
    }
}

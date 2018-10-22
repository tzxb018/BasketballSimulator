namespace Basketball
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trckPower = new System.Windows.Forms.TrackBar();
            this.trckAngle = new System.Windows.Forms.TrackBar();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.scoreBoard = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pole = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.net3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.net2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.net1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rim = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Backboard = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.ground = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.trckGravity = new System.Windows.Forms.TrackBar();
            this.lblGravityText = new System.Windows.Forms.Label();
            this.lblPowerText = new System.Windows.Forms.Label();
            this.lblAngleText = new System.Windows.Forms.Label();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.tmrChangeBack = new System.Windows.Forms.Timer(this.components);
            this.lblSound = new System.Windows.Forms.Label();
            this.tmrSoundEffect = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.tmrTimeForShooting = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrBuzzer = new System.Windows.Forms.Timer(this.components);
            this.lblBuzzer = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.pcArrow2 = new System.Windows.Forms.PictureBox();
            this.pcArrow1 = new System.Windows.Forms.PictureBox();
            this.btnBasket = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.picPerson = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trckPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckGravity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcArrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcArrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trckPower
            // 
            this.trckPower.Enabled = false;
            this.trckPower.LargeChange = 1;
            this.trckPower.Location = new System.Drawing.Point(155, 635);
            this.trckPower.Maximum = 100;
            this.trckPower.Name = "trckPower";
            this.trckPower.Size = new System.Drawing.Size(117, 45);
            this.trckPower.TabIndex = 1;
            this.trckPower.TabStop = false;
            this.trckPower.Value = 50;
            this.trckPower.Scroll += new System.EventHandler(this.trckPower_Scroll);
            this.trckPower.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trckPower_KeyDown);
            this.trckPower.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trckPower_KeyUp);
            this.trckPower.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trckPower_MouseDown);
            this.trckPower.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trckPower_MouseUp);
            // 
            // trckAngle
            // 
            this.trckAngle.Enabled = false;
            this.trckAngle.Location = new System.Drawing.Point(268, 635);
            this.trckAngle.Maximum = 90;
            this.trckAngle.Name = "trckAngle";
            this.trckAngle.Size = new System.Drawing.Size(102, 45);
            this.trckAngle.TabIndex = 2;
            this.trckAngle.TabStop = false;
            this.trckAngle.Scroll += new System.EventHandler(this.trckAngle_Scroll);
            this.trckAngle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trckAngle_KeyDown);
            this.trckAngle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trckAngle_KeyUp);
            this.trckAngle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trckAngle_MouseDown);
            this.trckAngle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trckAngle_MouseUp);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 10;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(919, 673);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bal";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.scoreBoard,
            this.pole,
            this.net3,
            this.net2,
            this.net1,
            this.rim,
            this.Backboard,
            this.ground});
            this.shapeContainer1.Size = new System.Drawing.Size(984, 751);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // scoreBoard
            // 
            this.scoreBoard.BackColor = System.Drawing.Color.DimGray;
            this.scoreBoard.BackgroundImage = global::Basketball.Properties.Resources.scoreboard;
            this.scoreBoard.BorderWidth = 10;
            this.scoreBoard.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.scoreBoard.Location = new System.Drawing.Point(580, 46);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(317, 157);
            // 
            // pole
            // 
            this.pole.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.pole.BorderWidth = 4;
            this.pole.Name = "pole";
            this.pole.X1 = 466;
            this.pole.X2 = 465;
            this.pole.Y1 = 484;
            this.pole.Y2 = 600;
            // 
            // net3
            // 
            this.net3.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.net3.Name = "net3";
            this.net3.X1 = 438;
            this.net3.X2 = 454;
            this.net3.Y1 = 509;
            this.net3.Y2 = 509;
            // 
            // net2
            // 
            this.net2.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.net2.Name = "net2";
            this.net2.X1 = 461;
            this.net2.X2 = 455;
            this.net2.Y1 = 481;
            this.net2.Y2 = 509;
            // 
            // net1
            // 
            this.net1.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.net1.Name = "net1";
            this.net1.X1 = 431;
            this.net1.X2 = 437;
            this.net1.Y1 = 478;
            this.net1.Y2 = 508;
            // 
            // rim
            // 
            this.rim.BorderColor = System.Drawing.Color.Orange;
            this.rim.BorderWidth = 2;
            this.rim.Location = new System.Drawing.Point(431, 474);
            this.rim.Name = "rim";
            this.rim.Size = new System.Drawing.Size(30, 7);
            // 
            // Backboard
            // 
            this.Backboard.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.Backboard.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.Backboard.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Backboard.Location = new System.Drawing.Point(462, 451);
            this.Backboard.Name = "Backboard";
            this.Backboard.Size = new System.Drawing.Size(8, 34);
            // 
            // ground
            // 
            this.ground.Name = "ground";
            this.ground.X1 = 0;
            this.ground.X2 = 1000;
            this.ground.Y1 = 600;
            this.ground.Y2 = 600;
            // 
            // trckGravity
            // 
            this.trckGravity.Enabled = false;
            this.trckGravity.LargeChange = 1;
            this.trckGravity.Location = new System.Drawing.Point(50, 635);
            this.trckGravity.Name = "trckGravity";
            this.trckGravity.Size = new System.Drawing.Size(99, 45);
            this.trckGravity.TabIndex = 7;
            this.trckGravity.TabStop = false;
            this.trckGravity.Value = 5;
            this.trckGravity.Scroll += new System.EventHandler(this.trckGravity_Scroll);
            this.trckGravity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trckGravity_KeyDown);
            this.trckGravity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trckGravity_KeyUp);
            this.trckGravity.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trckGravity_MouseDown);
            this.trckGravity.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trckGravity_MouseUp);
            // 
            // lblGravityText
            // 
            this.lblGravityText.AutoSize = true;
            this.lblGravityText.Location = new System.Drawing.Point(57, 617);
            this.lblGravityText.Name = "lblGravityText";
            this.lblGravityText.Size = new System.Drawing.Size(92, 13);
            this.lblGravityText.TabIndex = 8;
            this.lblGravityText.Text = "Gravity: 5 (normal)";
            // 
            // lblPowerText
            // 
            this.lblPowerText.AutoSize = true;
            this.lblPowerText.Location = new System.Drawing.Point(169, 616);
            this.lblPowerText.Name = "lblPowerText";
            this.lblPowerText.Size = new System.Drawing.Size(55, 13);
            this.lblPowerText.TabIndex = 9;
            this.lblPowerText.Text = "Power: 50";
            // 
            // lblAngleText
            // 
            this.lblAngleText.AutoSize = true;
            this.lblAngleText.Location = new System.Drawing.Point(287, 616);
            this.lblAngleText.Name = "lblAngleText";
            this.lblAngleText.Size = new System.Drawing.Size(46, 13);
            this.lblAngleText.TabIndex = 11;
            this.lblAngleText.Text = "Angle: 0";
            // 
            // lblScore1
            // 
            this.lblScore1.BackColor = System.Drawing.Color.Black;
            this.lblScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore1.Font = new System.Drawing.Font("Myriad Web Pro", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore1.ForeColor = System.Drawing.Color.Red;
            this.lblScore1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblScore1.Location = new System.Drawing.Point(591, 142);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(91, 50);
            this.lblScore1.TabIndex = 12;
            this.lblScore1.Text = "00";
            this.lblScore1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tmrChangeBack
            // 
            this.tmrChangeBack.Tick += new System.EventHandler(this.tmrChangeBack_Tick);
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSound.Location = new System.Drawing.Point(394, 487);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(35, 13);
            this.lblSound.TabIndex = 14;
            this.lblSound.Text = "Swish";
            // 
            // tmrSoundEffect
            // 
            this.tmrSoundEffect.Tick += new System.EventHandler(this.tmrSoundEffect_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(919, 705);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "69,511";
            // 
            // lblScore2
            // 
            this.lblScore2.BackColor = System.Drawing.Color.Black;
            this.lblScore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblScore2.Font = new System.Drawing.Font("Myriad Web Pro", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore2.ForeColor = System.Drawing.Color.Red;
            this.lblScore2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblScore2.Location = new System.Drawing.Point(795, 142);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(91, 50);
            this.lblScore2.TabIndex = 16;
            this.lblScore2.Text = "00";
            this.lblScore2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Myriad Web Pro", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.Location = new System.Drawing.Point(675, 53);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(126, 52);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "00 : 00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeriod
            // 
            this.lblPeriod.BackColor = System.Drawing.Color.Black;
            this.lblPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPeriod.Font = new System.Drawing.Font("Myriad Web Pro", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriod.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblPeriod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPeriod.Location = new System.Drawing.Point(712, 135);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(53, 39);
            this.lblPeriod.TabIndex = 19;
            this.lblPeriod.Text = "1";
            this.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrTimeForShooting
            // 
            this.tmrTimeForShooting.Interval = 92;
            this.tmrTimeForShooting.Tick += new System.EventHandler(this.tmrTimeForShooting_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(397, 617);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 53);
            this.btnStart.TabIndex = 20;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnStart_KeyDown);
            this.btnStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnStart_KeyUp);
            // 
            // tmrBuzzer
            // 
            this.tmrBuzzer.Tick += new System.EventHandler(this.tmrBuzzer_Tick);
            // 
            // lblBuzzer
            // 
            this.lblBuzzer.AutoSize = true;
            this.lblBuzzer.Font = new System.Drawing.Font("Swis721 Blk BT", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuzzer.ForeColor = System.Drawing.Color.Red;
            this.lblBuzzer.Location = new System.Drawing.Point(449, 46);
            this.lblBuzzer.Name = "lblBuzzer";
            this.lblBuzzer.Size = new System.Drawing.Size(121, 33);
            this.lblBuzzer.TabIndex = 24;
            this.lblBuzzer.Text = "Bzzzzz";
            this.lblBuzzer.Visible = false;
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(397, 676);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(116, 53);
            this.btnEnd.TabIndex = 25;
            this.btnEnd.TabStop = false;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Visible = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Transparent;
            this.picBall.Image = global::Basketball.Properties.Resources.basketballFinal;
            this.picBall.Location = new System.Drawing.Point(54, 467);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(20, 20);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // pcArrow2
            // 
            this.pcArrow2.BackColor = System.Drawing.Color.Black;
            this.pcArrow2.Image = global::Basketball.Properties.Resources.sierpinsky0;
            this.pcArrow2.Location = new System.Drawing.Point(767, 146);
            this.pcArrow2.Name = "pcArrow2";
            this.pcArrow2.Size = new System.Drawing.Size(21, 21);
            this.pcArrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcArrow2.TabIndex = 22;
            this.pcArrow2.TabStop = false;
            // 
            // pcArrow1
            // 
            this.pcArrow1.BackColor = System.Drawing.Color.Black;
            this.pcArrow1.Image = global::Basketball.Properties.Resources.sierpinsky0Copy;
            this.pcArrow1.Location = new System.Drawing.Point(688, 148);
            this.pcArrow1.Name = "pcArrow1";
            this.pcArrow1.Size = new System.Drawing.Size(21, 21);
            this.pcArrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcArrow1.TabIndex = 21;
            this.pcArrow1.TabStop = false;
            // 
            // btnBasket
            // 
            this.btnBasket.BackColor = System.Drawing.Color.Transparent;
            this.btnBasket.BackgroundImage = global::Basketball.Properties.Resources.Refresh_icon1;
            this.btnBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBasket.Enabled = false;
            this.btnBasket.Location = new System.Drawing.Point(317, 677);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(53, 49);
            this.btnBasket.TabIndex = 13;
            this.btnBasket.TabStop = false;
            this.btnBasket.UseVisualStyleBackColor = false;
            this.btnBasket.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::Basketball.Properties.Resources.playerstopoutline512;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(258, 676);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(53, 49);
            this.btnStop.TabIndex = 10;
            this.btnStop.TabStop = false;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.BackgroundImage = global::Basketball.Properties.Resources.player1;
            this.btnShoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShoot.Enabled = false;
            this.btnShoot.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShoot.Location = new System.Drawing.Point(199, 676);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(53, 49);
            this.btnShoot.TabIndex = 0;
            this.btnShoot.TabStop = false;
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // picPerson
            // 
            this.picPerson.BackColor = System.Drawing.Color.Transparent;
            this.picPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPerson.Image = global::Basketball.Properties.Resources.shooting1;
            this.picPerson.Location = new System.Drawing.Point(12, 478);
            this.picPerson.Name = "picPerson";
            this.picPerson.Size = new System.Drawing.Size(55, 122);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPerson.TabIndex = 6;
            this.picPerson.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Basketball.Properties.Resources.sierpinsky0;
            this.pictureBox1.Location = new System.Drawing.Point(768, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 751);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.lblBuzzer);
            this.Controls.Add(this.pcArrow2);
            this.Controls.Add(this.pcArrow1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.btnBasket);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.lblAngleText);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblPowerText);
            this.Controls.Add(this.lblGravityText);
            this.Controls.Add(this.trckGravity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.trckAngle);
            this.Controls.Add(this.trckPower);
            this.Controls.Add(this.picPerson);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Basketball Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.trckPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckGravity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcArrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcArrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.TrackBar trckPower;
        private System.Windows.Forms.TrackBar trckAngle;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape ground;
        private System.Windows.Forms.PictureBox picPerson;
        private System.Windows.Forms.TrackBar trckGravity;
        private System.Windows.Forms.Label lblGravityText;
        private System.Windows.Forms.Label lblPowerText;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblAngleText;
        private System.Windows.Forms.Label lblScore1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape rim;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape Backboard;
        private System.Windows.Forms.Button btnBasket;
        private System.Windows.Forms.Timer tmrChangeBack;
        private Microsoft.VisualBasic.PowerPacks.LineShape net3;
        private Microsoft.VisualBasic.PowerPacks.LineShape net2;
        private Microsoft.VisualBasic.PowerPacks.LineShape net1;
        private Microsoft.VisualBasic.PowerPacks.LineShape pole;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Timer tmrSoundEffect;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape scoreBoard;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Timer tmrTimeForShooting;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrBuzzer;
        private System.Windows.Forms.PictureBox pcArrow1;
        private System.Windows.Forms.PictureBox pcArrow2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBuzzer;
        private System.Windows.Forms.Button btnEnd;
    }
}


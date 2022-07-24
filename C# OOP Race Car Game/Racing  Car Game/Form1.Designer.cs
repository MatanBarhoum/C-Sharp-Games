namespace Racing__Car_Game
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblKmh = new System.Windows.Forms.Label();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin7 = new System.Windows.Forms.PictureBox();
            this.Coin6 = new System.Windows.Forms.PictureBox();
            this.Coin5 = new System.Windows.Forms.PictureBox();
            this.Coin4 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Astroied2 = new System.Windows.Forms.PictureBox();
            this.Astroied3 = new System.Windows.Forms.PictureBox();
            this.Car = new System.Windows.Forms.PictureBox();
            this.Coin = new System.Windows.Forms.PictureBox();
            this.Astroied = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Astroied2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Astroied3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Astroied)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(228, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(228, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(228, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(228, 396);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 100);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(228, 528);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 100);
            this.panel5.TabIndex = 4;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 22);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "Score";
            // 
            // lblKmh
            // 
            this.lblKmh.AutoSize = true;
            this.lblKmh.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblKmh.ForeColor = System.Drawing.Color.White;
            this.lblKmh.Location = new System.Drawing.Point(374, 588);
            this.lblKmh.Name = "lblKmh";
            this.lblKmh.Size = new System.Drawing.Size(74, 22);
            this.lblKmh.TabIndex = 10;
            this.lblKmh.Text = "5 Km\\h";
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCoins.ForeColor = System.Drawing.Color.White;
            this.lblCoins.Location = new System.Drawing.Point(375, 9);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(81, 18);
            this.lblCoins.TabIndex = 11;
            this.lblCoins.Text = "Coins: 240";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDistance.ForeColor = System.Drawing.Color.White;
            this.lblDistance.Location = new System.Drawing.Point(1, 591);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(76, 19);
            this.lblDistance.TabIndex = 15;
            this.lblDistance.Text = "Distance";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Coin3
            // 
            this.Coin3.Image = global::Racing__Car_Game.Properties.Resources.coin;
            this.Coin3.Location = new System.Drawing.Point(174, -50);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(22, 21);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Coin3.TabIndex = 21;
            this.Coin3.TabStop = false;
            this.Coin3.Visible = false;
            // 
            // Coin7
            // 
            this.Coin7.Image = global::Racing__Car_Game.Properties.Resources.coin;
            this.Coin7.Location = new System.Drawing.Point(174, -250);
            this.Coin7.Name = "Coin7";
            this.Coin7.Size = new System.Drawing.Size(22, 21);
            this.Coin7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Coin7.TabIndex = 25;
            this.Coin7.TabStop = false;
            this.Coin7.Visible = false;
            // 
            // Coin6
            // 
            this.Coin6.Image = global::Racing__Car_Game.Properties.Resources.coin;
            this.Coin6.Location = new System.Drawing.Point(304, -300);
            this.Coin6.Name = "Coin6";
            this.Coin6.Size = new System.Drawing.Size(22, 21);
            this.Coin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Coin6.TabIndex = 24;
            this.Coin6.TabStop = false;
            this.Coin6.Visible = false;
            // 
            // Coin5
            // 
            this.Coin5.Image = global::Racing__Car_Game.Properties.Resources.coin;
            this.Coin5.Location = new System.Drawing.Point(231, -200);
            this.Coin5.Name = "Coin5";
            this.Coin5.Size = new System.Drawing.Size(22, 21);
            this.Coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Coin5.TabIndex = 23;
            this.Coin5.TabStop = false;
            this.Coin5.Visible = false;
            // 
            // Coin4
            // 
            this.Coin4.Image = global::Racing__Car_Game.Properties.Resources.coin;
            this.Coin4.Location = new System.Drawing.Point(95, -150);
            this.Coin4.Name = "Coin4";
            this.Coin4.Size = new System.Drawing.Size(22, 21);
            this.Coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Coin4.TabIndex = 22;
            this.Coin4.TabStop = false;
            this.Coin4.Visible = false;
            // 
            // Coin2
            // 
            this.Coin2.Image = global::Racing__Car_Game.Properties.Resources.coin;
            this.Coin2.Location = new System.Drawing.Point(264, -100);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(22, 21);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Coin2.TabIndex = 20;
            this.Coin2.TabStop = false;
            this.Coin2.Visible = false;
            // 
            // Astroied2
            // 
            this.Astroied2.Image = global::Racing__Car_Game.Properties.Resources.asteroid01;
            this.Astroied2.Location = new System.Drawing.Point(53, -180);
            this.Astroied2.Name = "Astroied2";
            this.Astroied2.Size = new System.Drawing.Size(47, 47);
            this.Astroied2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Astroied2.TabIndex = 14;
            this.Astroied2.TabStop = false;
            this.Astroied2.Visible = false;
            // 
            // Astroied3
            // 
            this.Astroied3.Image = global::Racing__Car_Game.Properties.Resources.asteroid01;
            this.Astroied3.Location = new System.Drawing.Point(163, 64);
            this.Astroied3.Name = "Astroied3";
            this.Astroied3.Size = new System.Drawing.Size(47, 47);
            this.Astroied3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Astroied3.TabIndex = 13;
            this.Astroied3.TabStop = false;
            // 
            // Car
            // 
            this.Car.Image = global::Racing__Car_Game.Properties.Resources.SportsRacingCar_01;
            this.Car.Location = new System.Drawing.Point(214, 492);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(35, 43);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 5;
            this.Car.TabStop = false;
            // 
            // Coin
            // 
            this.Coin.Image = global::Racing__Car_Game.Properties.Resources.coin;
            this.Coin.Location = new System.Drawing.Point(174, 160);
            this.Coin.Name = "Coin";
            this.Coin.Size = new System.Drawing.Size(22, 21);
            this.Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Coin.TabIndex = 7;
            this.Coin.TabStop = false;
            this.Coin.Visible = false;
            // 
            // Astroied
            // 
            this.Astroied.Image = global::Racing__Car_Game.Properties.Resources.asteroid01;
            this.Astroied.Location = new System.Drawing.Point(352, -80);
            this.Astroied.Name = "Astroied";
            this.Astroied.Size = new System.Drawing.Size(47, 47);
            this.Astroied.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Astroied.TabIndex = 8;
            this.Astroied.TabStop = false;
            this.Astroied.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(74, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(475, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin7);
            this.Controls.Add(this.Coin6);
            this.Controls.Add(this.Coin5);
            this.Controls.Add(this.Coin4);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.Astroied2);
            this.Controls.Add(this.Astroied3);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.Coin);
            this.Controls.Add(this.Astroied);
            this.Controls.Add(this.lblKmh);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UserLeftKey);
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Astroied2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Astroied3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Astroied)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.PictureBox Coin;
        private System.Windows.Forms.PictureBox Astroied;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblKmh;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox Astroied3;
        private System.Windows.Forms.PictureBox Astroied2;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.PictureBox Coin4;
        private System.Windows.Forms.PictureBox Coin5;
        private System.Windows.Forms.PictureBox Coin6;
        private System.Windows.Forms.PictureBox Coin7;
        private System.Windows.Forms.Label label1;
    }
}


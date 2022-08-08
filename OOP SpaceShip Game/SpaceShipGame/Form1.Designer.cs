namespace SpaceShipGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SpaceCraft = new System.Windows.Forms.PictureBox();
            this.gameMainTimer = new System.Windows.Forms.Timer(this.components);
            this.planet1 = new System.Windows.Forms.PictureBox();
            this.planet3 = new System.Windows.Forms.PictureBox();
            this.planet2 = new System.Windows.Forms.PictureBox();
            this.planet5 = new System.Windows.Forms.PictureBox();
            this.planet4 = new System.Windows.Forms.PictureBox();
            this.lblhp = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.Shieldimg = new System.Windows.Forms.PictureBox();
            this.ShieldActivate = new System.Windows.Forms.Timer(this.components);
            this.timeSpan1 = new System.Windows.Forms.Label();
            this.imgShield = new System.Windows.Forms.PictureBox();
            this.lblShield = new System.Windows.Forms.Label();
            this.lblPressSpace = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceCraft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shieldimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SpaceCraft
            // 
            this.SpaceCraft.BackColor = System.Drawing.Color.Transparent;
            this.SpaceCraft.Image = ((System.Drawing.Image)(resources.GetObject("SpaceCraft.Image")));
            this.SpaceCraft.Location = new System.Drawing.Point(321, 559);
            this.SpaceCraft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpaceCraft.Name = "SpaceCraft";
            this.SpaceCraft.Size = new System.Drawing.Size(65, 79);
            this.SpaceCraft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpaceCraft.TabIndex = 1;
            this.SpaceCraft.TabStop = false;
            // 
            // gameMainTimer
            // 
            this.gameMainTimer.Enabled = true;
            this.gameMainTimer.Interval = 1;
            this.gameMainTimer.Tick += new System.EventHandler(this.gameMainTimer_Tick);
            // 
            // planet1
            // 
            this.planet1.BackColor = System.Drawing.Color.Transparent;
            this.planet1.Image = global::SpaceShipGame.Properties.Resources.asteroid01;
            this.planet1.Location = new System.Drawing.Point(321, 16);
            this.planet1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.planet1.Name = "planet1";
            this.planet1.Size = new System.Drawing.Size(80, 67);
            this.planet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planet1.TabIndex = 2;
            this.planet1.TabStop = false;
            // 
            // planet3
            // 
            this.planet3.BackColor = System.Drawing.Color.Transparent;
            this.planet3.Image = global::SpaceShipGame.Properties.Resources.asteroid01;
            this.planet3.Location = new System.Drawing.Point(275, 145);
            this.planet3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.planet3.Name = "planet3";
            this.planet3.Size = new System.Drawing.Size(80, 67);
            this.planet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planet3.TabIndex = 3;
            this.planet3.TabStop = false;
            // 
            // planet2
            // 
            this.planet2.BackColor = System.Drawing.Color.Transparent;
            this.planet2.Image = global::SpaceShipGame.Properties.Resources.asteroid01;
            this.planet2.Location = new System.Drawing.Point(440, 3);
            this.planet2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.planet2.Name = "planet2";
            this.planet2.Size = new System.Drawing.Size(80, 67);
            this.planet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planet2.TabIndex = 4;
            this.planet2.TabStop = false;
            // 
            // planet5
            // 
            this.planet5.BackColor = System.Drawing.Color.Transparent;
            this.planet5.Image = global::SpaceShipGame.Properties.Resources.asteroid01;
            this.planet5.Location = new System.Drawing.Point(334, 312);
            this.planet5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.planet5.Name = "planet5";
            this.planet5.Size = new System.Drawing.Size(80, 67);
            this.planet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planet5.TabIndex = 5;
            this.planet5.TabStop = false;
            // 
            // planet4
            // 
            this.planet4.BackColor = System.Drawing.Color.Transparent;
            this.planet4.Image = global::SpaceShipGame.Properties.Resources.asteroid01;
            this.planet4.Location = new System.Drawing.Point(373, 275);
            this.planet4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.planet4.Name = "planet4";
            this.planet4.Size = new System.Drawing.Size(80, 67);
            this.planet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planet4.TabIndex = 6;
            this.planet4.TabStop = false;
            // 
            // lblhp
            // 
            this.lblhp.AutoSize = true;
            this.lblhp.BackColor = System.Drawing.Color.Transparent;
            this.lblhp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblhp.ForeColor = System.Drawing.Color.White;
            this.lblhp.Location = new System.Drawing.Point(14, 651);
            this.lblhp.Name = "lblhp";
            this.lblhp.Size = new System.Drawing.Size(80, 28);
            this.lblhp.TabIndex = 7;
            this.lblhp.Text = "HP: 100";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(14, 12);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(84, 28);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score: 0";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(14, 55);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(84, 28);
            this.lblSpeed.TabIndex = 10;
            this.lblSpeed.Text = "Score: 0";
            // 
            // Shieldimg
            // 
            this.Shieldimg.BackColor = System.Drawing.Color.Transparent;
            this.Shieldimg.Image = global::SpaceShipGame.Properties.Resources.spr_shield;
            this.Shieldimg.Location = new System.Drawing.Point(275, 525);
            this.Shieldimg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Shieldimg.Name = "Shieldimg";
            this.Shieldimg.Size = new System.Drawing.Size(160, 145);
            this.Shieldimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shieldimg.TabIndex = 11;
            this.Shieldimg.TabStop = false;
            this.Shieldimg.Visible = false;
            // 
            // ShieldActivate
            // 
            this.ShieldActivate.Interval = 1;
            this.ShieldActivate.Tick += new System.EventHandler(this.ShieldActivate_Tick);
            // 
            // timeSpan1
            // 
            this.timeSpan1.AutoSize = true;
            this.timeSpan1.BackColor = System.Drawing.Color.Transparent;
            this.timeSpan1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeSpan1.ForeColor = System.Drawing.Color.White;
            this.timeSpan1.Location = new System.Drawing.Point(14, 96);
            this.timeSpan1.Name = "timeSpan1";
            this.timeSpan1.Size = new System.Drawing.Size(84, 28);
            this.timeSpan1.TabIndex = 12;
            this.timeSpan1.Text = "Score: 0";
            // 
            // imgShield
            // 
            this.imgShield.BackColor = System.Drawing.Color.Transparent;
            this.imgShield.Image = global::SpaceShipGame.Properties.Resources.spr_shield;
            this.imgShield.Location = new System.Drawing.Point(504, 559);
            this.imgShield.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgShield.Name = "imgShield";
            this.imgShield.Size = new System.Drawing.Size(61, 60);
            this.imgShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShield.TabIndex = 13;
            this.imgShield.TabStop = false;
            this.imgShield.Visible = false;
            // 
            // lblShield
            // 
            this.lblShield.AutoSize = true;
            this.lblShield.BackColor = System.Drawing.Color.Transparent;
            this.lblShield.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShield.ForeColor = System.Drawing.Color.White;
            this.lblShield.Location = new System.Drawing.Point(560, 559);
            this.lblShield.Name = "lblShield";
            this.lblShield.Size = new System.Drawing.Size(138, 54);
            this.lblShield.TabIndex = 14;
            this.lblShield.Text = "Shield";
            this.lblShield.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblShield.Visible = false;
            // 
            // lblPressSpace
            // 
            this.lblPressSpace.AutoSize = true;
            this.lblPressSpace.BackColor = System.Drawing.Color.Transparent;
            this.lblPressSpace.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPressSpace.ForeColor = System.Drawing.Color.White;
            this.lblPressSpace.Location = new System.Drawing.Point(504, 623);
            this.lblPressSpace.Name = "lblPressSpace";
            this.lblPressSpace.Size = new System.Drawing.Size(190, 28);
            this.lblPressSpace.TabIndex = 15;
            this.lblPressSpace.Text = "Press the Space Bar";
            this.lblPressSpace.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpaceShipGame.Properties.Resources.Background_4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(761, 704);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceShipGame.Properties.Resources.Background_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 691);
            this.Controls.Add(this.lblPressSpace);
            this.Controls.Add(this.lblShield);
            this.Controls.Add(this.imgShield);
            this.Controls.Add(this.timeSpan1);
            this.Controls.Add(this.SpaceCraft);
            this.Controls.Add(this.Shieldimg);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblhp);
            this.Controls.Add(this.planet4);
            this.Controls.Add(this.planet5);
            this.Controls.Add(this.planet2);
            this.Controls.Add(this.planet3);
            this.Controls.Add(this.planet1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SapceShip by Matan Barhoum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceCraft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shieldimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SpaceCraft;
        private System.Windows.Forms.Timer gameMainTimer;
        private System.Windows.Forms.PictureBox planet1;
        private System.Windows.Forms.PictureBox planet3;
        private System.Windows.Forms.PictureBox planet2;
        private System.Windows.Forms.PictureBox planet5;
        private System.Windows.Forms.PictureBox planet4;
        private System.Windows.Forms.Label lblhp;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.PictureBox Shieldimg;
        private System.Windows.Forms.Timer ShieldActivate;
        private System.Windows.Forms.Label timeSpan1;
        private System.Windows.Forms.PictureBox imgShield;
        private System.Windows.Forms.Label lblShield;
        private System.Windows.Forms.Label lblPressSpace;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

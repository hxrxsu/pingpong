namespace genshinpingpong
{
    partial class Pong
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            cpuplayer = new PictureBox();
            player = new PictureBox();
            pictureBox2 = new PictureBox();
            playerScoreLabel = new Label();
            cpuScoreLabel = new Label();
            pongTimer = new System.Windows.Forms.Timer(components);
            pongBall = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)cpuplayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pongBall).BeginInit();
            SuspendLayout();
            // 
            // cpuplayer
            // 
            cpuplayer.Location = new Point(771, 170);
            cpuplayer.Name = "cpuplayer";
            cpuplayer.Size = new Size(17, 114);
            cpuplayer.TabIndex = 0;
            cpuplayer.TabStop = false;
            cpuplayer.Click += pictureBox1_Click;
            // 
            // player
            // 
            player.Location = new Point(12, 170);
            player.Name = "player";
            player.Size = new Size(17, 114);
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.aaaaa;
            pictureBox2.Location = new Point(159, 394);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(494, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // playerScoreLabel
            // 
            playerScoreLabel.BackColor = Color.Transparent;
            playerScoreLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            playerScoreLabel.ForeColor = Color.Fuchsia;
            playerScoreLabel.Location = new Point(133, 405);
            playerScoreLabel.Name = "playerScoreLabel";
            playerScoreLabel.Size = new Size(20, 36);
            playerScoreLabel.TabIndex = 3;
            playerScoreLabel.Text = "0";
            // 
            // cpuScoreLabel
            // 
            cpuScoreLabel.BackColor = Color.Transparent;
            cpuScoreLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cpuScoreLabel.ForeColor = Color.FromArgb(255, 128, 128);
            cpuScoreLabel.Location = new Point(659, 405);
            cpuScoreLabel.Name = "cpuScoreLabel";
            cpuScoreLabel.Size = new Size(20, 36);
            cpuScoreLabel.TabIndex = 4;
            cpuScoreLabel.Text = "0";
            // 
            // pongTimer
            // 
            pongTimer.Enabled = true;
            pongTimer.Interval = 20;
            pongTimer.Tick += timer1_Tick;
            // 
            // pongBall
            // 
            pongBall.BackColor = Color.Transparent;
            pongBall.BackgroundImage = Properties.Resources.sdfsdf1;
            pongBall.BackgroundImageLayout = ImageLayout.Stretch;
            pongBall.ErrorImage = null;
            pongBall.InitialImage = null;
            pongBall.Location = new Point(394, 206);
            pongBall.Name = "pongBall";
            pongBall.Size = new Size(22, 19);
            pongBall.SizeMode = PictureBoxSizeMode.StretchImage;
            pongBall.TabIndex = 5;
            pongBall.TabStop = false;
            pongBall.Click += pongBall_Click_1;
            // 
            // Pong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.landscape_anime_digital_art_fantasy_art_wallpaper_preview;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pongBall);
            Controls.Add(cpuScoreLabel);
            Controls.Add(playerScoreLabel);
            Controls.Add(pictureBox2);
            Controls.Add(player);
            Controls.Add(cpuplayer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pong";
            Text = "PingPnng";
            Load += Form1_Load;
            KeyDown += Pong_KeyDown;
            KeyUp += Pong_KeyUp;
            ((System.ComponentModel.ISupportInitialize)cpuplayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pongBall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cpuplayer;
        private PictureBox player;
        private PictureBox pictureBox2;
        private Label playerScoreLabel;
        private Label cpuScoreLabel;
        private PictureBox pongBall;
        public System.Windows.Forms.Timer pongTimer;
    }
}
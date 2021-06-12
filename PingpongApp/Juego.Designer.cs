namespace PingpongApp
{
    partial class Juego
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
            this.imgBall = new System.Windows.Forms.PictureBox();
            this.imgRacket = new System.Windows.Forms.PictureBox();
            this.timerJuego = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRacket)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBall
            // 
            this.imgBall.BackColor = System.Drawing.Color.Transparent;
            this.imgBall.BackgroundImage = global::PingpongApp.Properties.Resources.ballnudsf0214;
            this.imgBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgBall.Location = new System.Drawing.Point(42, 237);
            this.imgBall.Name = "imgBall";
            this.imgBall.Size = new System.Drawing.Size(33, 34);
            this.imgBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgBall.TabIndex = 0;
            this.imgBall.TabStop = false;
            // 
            // imgRacket
            // 
            this.imgRacket.BackColor = System.Drawing.Color.Red;
            this.imgRacket.Location = new System.Drawing.Point(712, 191);
            this.imgRacket.Name = "imgRacket";
            this.imgRacket.Size = new System.Drawing.Size(13, 102);
            this.imgRacket.TabIndex = 1;
            this.imgRacket.TabStop = false;
            // 
            // timerJuego
            // 
            this.timerJuego.Tick += new System.EventHandler(this.timerJuego_Tick);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PingpongApp.Properties.Resources.Table_0001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(727, 503);
            this.Controls.Add(this.imgRacket);
            this.Controls.Add(this.imgBall);
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
            this.Load += new System.EventHandler(this.Juego_Load);
            this.Click += new System.EventHandler(this.Juego_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Juego_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRacket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBall;
        private System.Windows.Forms.PictureBox imgRacket;
        private System.Windows.Forms.Timer timerJuego;
    }
}
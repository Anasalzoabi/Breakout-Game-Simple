namespace Breakout_Game
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtScore = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtScore
            // 
            this.TxtScore.AutoSize = true;
            this.TxtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtScore.ForeColor = System.Drawing.Color.White;
            this.TxtScore.Location = new System.Drawing.Point(12, 9);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(81, 20);
            this.TxtScore.TabIndex = 0;
            this.TxtScore.Text = "Score : 0";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.White;
            this.Player.Location = new System.Drawing.Point(356, 529);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 32);
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.DarkCyan;
            this.Ball.Location = new System.Drawing.Point(385, 416);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(25, 23);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.mainGameTimer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.TxtScore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Breakout Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtScore;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer GameTimer;
    }
}


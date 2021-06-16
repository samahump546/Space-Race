
namespace Space_Race
{
    partial class spaceRace
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(170, 92);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(464, 106);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Space Race";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(255, 269);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(299, 46);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1ScoreLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p1ScoreLabel.Location = new System.Drawing.Point(26, 22);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(267, 48);
            this.p1ScoreLabel.TabIndex = 2;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2ScoreLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p2ScoreLabel.Location = new System.Drawing.Point(481, 22);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(274, 48);
            this.p2ScoreLabel.TabIndex = 3;
            // 
            // spaceRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "spaceRace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Race";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.spaceRace_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spaceRace_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.spaceRace_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
    }
}


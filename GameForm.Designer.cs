
namespace Michaeljeon_GAME_ASSESSMENT
{
    partial class GameForm
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
            this.tmrSpaceship = new System.Windows.Forms.Timer(this.components);
            this.TmrShoot = new System.Windows.Forms.Timer(this.components);
            this.LblScore = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrSpaceship
            // 
            this.tmrSpaceship.Enabled = true;
            this.tmrSpaceship.Interval = 1;
            this.tmrSpaceship.Tick += new System.EventHandler(this.tmrSpaceship_Tick);
            // 
            // TmrShoot
            // 
            this.TmrShoot.Enabled = true;
            this.TmrShoot.Interval = 40;
            this.TmrShoot.Tick += new System.EventHandler(this.TmrShoot_Tick);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.BackColor = System.Drawing.Color.Transparent;
            this.LblScore.Location = new System.Drawing.Point(376, 372);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(13, 13);
            this.LblScore.TabIndex = 1;
            this.LblScore.Text = "0";
            this.LblScore.Click += new System.EventHandler(this.LblScore_Click);
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.BackColor = System.Drawing.Color.Transparent;
            this.LblLives.Location = new System.Drawing.Point(376, 322);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(13, 13);
            this.LblLives.TabIndex = 3;
            this.LblLives.Text = "5";
            this.LblLives.Click += new System.EventHandler(this.LblLives_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(367, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lives";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(367, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score";
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Enabled = true;
            this.TmrPlanet.Interval = 1;
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.LblScore);
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrSpaceship;
        private System.Windows.Forms.Timer TmrShoot;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TmrPlanet;
    }
}
using System.ComponentModel;

namespace TurtleClicker
{
    partial class MainGame
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
            System.Windows.Forms.Timer timer1;
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.turtle = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.turtle)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCORE: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ScoreText.Location = new System.Drawing.Point(131, 18);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(29, 29);
            this.ScoreText.TabIndex = 2;
            this.ScoreText.Text = "0";
            this.ScoreText.Click += new System.EventHandler(this.ScoreText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(686, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "TIME:";
            // 
            // timerText
            // 
            this.timerText.AutoSize = true;
            this.timerText.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.timerText.Location = new System.Drawing.Point(785, 18);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(45, 29);
            this.timerText.TabIndex = 4;
            this.timerText.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(836, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "SECONDS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // turtle
            // 
            this.turtle.Location = new System.Drawing.Point(489, 280);
            this.turtle.Name = "turtle";
            this.turtle.Size = new System.Drawing.Size(65, 65);
            this.turtle.TabIndex = 0;
            this.turtle.TabStop = false;
            this.turtle.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turtle);
            this.Name = "MainGame";
            this.Text = "Click that Turtle!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turtle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Label label3;
        private ISupportInitialize turtlePic;
        internal System.Windows.Forms.PictureBox turtle;
    }
}
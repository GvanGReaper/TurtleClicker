namespace TurtleClicker
{
    partial class GameEnd
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
            this.label1 = new System.Windows.Forms.Label();
            this.finalScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rank = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FINAL SCORE:";
            // 
            // finalScore
            // 
            this.finalScore.AutoSize = true;
            this.finalScore.BackColor = System.Drawing.Color.Transparent;
            this.finalScore.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.finalScore.Location = new System.Drawing.Point(223, 167);
            this.finalScore.Name = "finalScore";
            this.finalScore.Size = new System.Drawing.Size(29, 29);
            this.finalScore.TabIndex = 1;
            this.finalScore.Text = "0";
            this.finalScore.Click += new System.EventHandler(this.finalScore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "RANK:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Rank
            // 
            this.Rank.AutoSize = true;
            this.Rank.BackColor = System.Drawing.Color.Transparent;
            this.Rank.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Rank.Location = new System.Drawing.Point(111, 233);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(29, 29);
            this.Rank.TabIndex = 3;
            this.Rank.Text = "F";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "END OF GAME RESULTS:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Try again?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(14, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "DIFFICULTY:";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.BackColor = System.Drawing.Color.Transparent;
            this.difficultyLabel.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.difficultyLabel.Location = new System.Drawing.Point(209, 113);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(333, 29);
            this.difficultyLabel.TabIndex = 7;
            this.difficultyLabel.Text = "IM TOO YOUNG TO DIE!";
            // 
            // GameEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TurtleClicker.Properties.Resources.gameEndImage;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finalScore);
            this.Controls.Add(this.label1);
            this.Name = "GameEnd";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.GameEnd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label finalScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Rank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label difficultyLabel;
    }
}
namespace TurtleClicker
{
    partial class DifficultySelection
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
            this.startButton = new System.Windows.Forms.Button();
            this.easyButton = new System.Windows.Forms.RadioButton();
            this.normalButton = new System.Windows.Forms.RadioButton();
            this.hardButton = new System.Windows.Forms.RadioButton();
            this.difficulty_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.difficulty_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Difficulty";
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(81, 193);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // easyButton
            // 
            this.easyButton.AutoSize = true;
            this.easyButton.Location = new System.Drawing.Point(68, 109);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(120, 17);
            this.easyButton.TabIndex = 4;
            this.easyButton.TabStop = true;
            this.easyButton.Text = "I\'m too young to die!";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // normalButton
            // 
            this.normalButton.AutoSize = true;
            this.normalButton.Location = new System.Drawing.Point(68, 132);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(96, 17);
            this.normalButton.TabIndex = 5;
            this.normalButton.TabStop = true;
            this.normalButton.Text = "Hurt me plenty!";
            this.normalButton.UseVisualStyleBackColor = true;
            this.normalButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // hardButton
            // 
            this.hardButton.AutoSize = true;
            this.hardButton.Location = new System.Drawing.Point(68, 155);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(109, 17);
            this.hardButton.TabIndex = 6;
            this.hardButton.TabStop = true;
            this.hardButton.Text = "Turtle shell tough!";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // difficulty_pic
            // 
            this.difficulty_pic.Location = new System.Drawing.Point(91, 8);
            this.difficulty_pic.Name = "difficulty_pic";
            this.difficulty_pic.Size = new System.Drawing.Size(65, 65);
            this.difficulty_pic.TabIndex = 2;
            this.difficulty_pic.TabStop = false;
            this.difficulty_pic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DifficultySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 306);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.normalButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.difficulty_pic);
            this.Controls.Add(this.label1);
            this.Name = "DifficultySelection";
            this.Text = "DifficultySelection";
            this.Load += new System.EventHandler(this.DifficultySelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.difficulty_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox difficulty_pic;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RadioButton easyButton;
        private System.Windows.Forms.RadioButton normalButton;
        private System.Windows.Forms.RadioButton hardButton;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleClicker
{
    public partial class DifficultySelection : Form
    {
        public DifficultySelection()
        {
            InitializeComponent();
        }

       

        private void DifficultySelection_Load(object sender, EventArgs e)
        {
            

        }


        private void startButton_Click(object sender, EventArgs e)
        {
            MainGame maingame;
            if (easyButton.Checked)
            {
                maingame = new MainGame("Easy");
            }
            else if(normalButton.Checked) 
            {
                maingame = new MainGame("Normal");
            }
            else
            {
                maingame = new MainGame("Hard");
            }
            maingame.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        //easy button
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (easyButton.Checked)
            {
                difficulty_pic.Visible = true;
                difficulty_pic.BackgroundImage = Properties.Resources.ez_mode_turtle;
                difficulty_pic.Update();
                startButton.Enabled = true;
            }
        }

        //normal button
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (normalButton.Checked)
            {
                difficulty_pic.Visible = true;
                difficulty_pic.BackgroundImage = Properties.Resources.evil_turtle1;
                difficulty_pic.Update();
                startButton.Enabled = true;
            }
        }

        //hard button
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (hardButton.Checked)
            {
                difficulty_pic.Visible = true;
                difficulty_pic.BackgroundImage = Properties.Resources.dead_turtle;
                difficulty_pic.Update();
                startButton.Enabled = true;
            }
        }
    }
}   

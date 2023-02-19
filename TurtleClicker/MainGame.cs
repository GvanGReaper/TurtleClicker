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
    public partial class MainGame : Form
    {
        private Turtle turtle_enemy;
        private String difficulty;
        private int score = 0;
        private int counter = 60;
        public MainGame(string difficulty = "Easy")
        {
            InitializeComponent();
            this.difficulty = difficulty;
            if(difficulty == "Easy")
            {
                turtle.Image = Properties.Resources.evil_turtle1;
            }
            else if(difficulty == "Normal")
            {
                turtle.Image = Properties.Resources.evil_turtle1;
            }
            else if(difficulty == "Hard")
            {
                turtle.Image = Properties.Resources.dead_turtle;
            }
            turtle.Update();
            turtle_enemy = new Turtle(difficulty,turtle);
            turtle_enemy.change_Image();
            turtle = turtle_enemy.getPictureBox();
        }

        public int getCounter()
        {
            return this.counter;
        }

        public void setCounter(int new_counter_value)
        {
            this.counter = new_counter_value;
        }

        public int getScore()
        {
            return this.score;
        }

        public void setScore(int new_score)
        {
            this.score = new_score;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowTextRandomizer windowText = new WindowTextRandomizer();
            this.Text = windowText.getWindowText();
            this.Update();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int temp_score = getScore();
            temp_score++;
            setScore(temp_score);
            ScoreText.Text = score.ToString();
            ScoreText.Update();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void ScoreText_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                Debug.WriteLine(getScore());
                GameEnd endGameScreen = new GameEnd(score,difficulty);
                endGameScreen.Show();
                this.Close();
            }
            counter--;
            timerText.Text = counter.ToString();
            timerText.Update();
            turtle_enemy.turtle_act(ref turtle);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



       
    }
}

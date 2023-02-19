using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleClicker
{
    public partial class GameEnd : Form
    {
        private String difficulty;
        private int score;
        public GameEnd(int score,String difficulty)
        {
            this.difficulty = difficulty;
            this.score = score;
            InitializeComponent();
        }

        private void GameEnd_Load(object sender, EventArgs e)
        {
            WindowTextRandomizer windowText = new WindowTextRandomizer();
            this.Text = windowText.getWindowText();
            this.Update();

            finalScore.Text = score.ToString();
            finalScore.Update();

            Rank currentRank = new Rank(score);
            Rank.Text = currentRank.getRank();
            Rank.Update();

            difficultyLabel.Text = getDifficultyName(difficulty);
            difficultyLabel.Update();
        }

        

        private String getDifficultyName(String difficulty)
        {
            if(difficulty == "Easy")
            {
                return "IM TOO YOUNG TO DIE!";
            }
            else if(difficulty == "Normal")
            {
                return "HURT ME PLENTY!";
            }
            else
            {
                return "TURTLE SHELL TOUGH!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DifficultySelection newForm = new DifficultySelection();
            newForm.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void finalScore_Click(object sender, EventArgs e)
        {

        }
    }
}

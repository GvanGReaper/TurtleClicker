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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowTextRandomizer windowText = new WindowTextRandomizer();
            this.Text = windowText.getWindowText();
            this.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DifficultySelection difficultySelection = new DifficultySelection();
            difficultySelection.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HowToPlay how_to_play = new HowToPlay();
            how_to_play.Show();
        }
    }
}

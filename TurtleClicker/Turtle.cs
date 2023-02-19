using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtleClicker
{
    internal class Turtle
    {
        private PictureBox pictureBox;
        private String difficulty; // "Easy"/"Normal"/"Hard"
        private int speed;
        private bool enraged;
        private int phase; //1 - 3
        public Turtle(string difficulty, PictureBox pictureBox)
        {
            this.difficulty = difficulty;
            this.pictureBox = pictureBox;
            this.phase = 1;
            this.speed = 0;
            this.enraged = false;
        }

        public PictureBox getPictureBox()
        {
            return pictureBox;
        }


        public String getDifficulty()
        {
            return difficulty;
        }

        public void setDifficulty(String difficulty)
        {
            this.difficulty = difficulty;
        }

        public int getSpeed()
        {
            return speed;
        }

        public void setSpeed(int speed)
        {
            this.speed = speed;
        }

        public bool isEnraged()
        {
            return enraged;
        }

        public int getPhase()
        {
            return phase;
        }

        public void setPhase(int phase)
        {
            this.phase = phase;
        }

        //this multiplier is used for a lot of different calculations and it depends on the 
        //difficulty chosen by the player
        internal int getDifficultyMultiplier() 
        {
            int result = 0;
            if(getDifficulty() == "Easy")
            {
                result =  1;
            }
            else if(getDifficulty() == "Normal")
            {
                result = 2;
            }
            else if(getDifficulty() == "Hard")
            {
                result = 8;
            }
            if (isEnraged())
            {
                result = result * 3;
            }
            return result;
        }

        
        internal void change_Image()
        {
            if(getDifficulty() == "Easy")
            {
                pictureBox.Image = Properties.Resources.ez_mode_turtle;
                pictureBox.Update();
            }
            else if (getDifficulty() == "Normal")
            {
                pictureBox.Image = Properties.Resources.evil_turtle1;
                pictureBox.Update();
            }
            else if(getDifficulty() == "Hard")
            {
                pictureBox.Image = Properties.Resources.dead_turtle;
                pictureBox.Update();
            }
        }

        internal void calculateSpeed()
        {
            int speed = getPhase()*getDifficultyMultiplier();
            setSpeed(speed);
        }
        
        //the sprite origin is at the top left corner and the sprite is 65x65.Thus moving 32 pixels
        //down and to the right should give us the center of the sprite.
        private Point getCenter(PictureBox pictureBox)
        {
            Point point = new Point(pictureBox.Location.X + 32,pictureBox.Location.Y + 32);
            return point;
        }


        public void turtle_act(ref PictureBox pictureBox)
        {
            Point temp;
            do
            {
                temp = chooseMove(pictureBox);
            } while (!((temp.X < 900 && temp.X >= 0) && (temp.Y < 600 && temp.Y >= 0)));
            pictureBox.Location = temp;
        }


        private Point chooseMove(PictureBox pictureBox)
        {
            if(getDifficulty() == "Easy")
            {
                return easyMove(pictureBox);
            }
            else if(getDifficulty() == "Normal")
            {
                return normalMove(pictureBox);
            }
            else if(getDifficulty() == "Hard")
            {
                return hardmove(pictureBox);
            }
            return new Point(0, 0);
        }

        private Point easyMove(PictureBox pictureBox)
        {
            var random = new Random();
            int nextMove = random.Next();
            if(nextMove%4 == 0)
            {
                return moveInRadius(pictureBox);
            }
            else if(nextMove%4 == 1)
            {
                return moveHorizontaly(pictureBox);
            }
            else if(nextMove%4 == 2)
            {
                return moveVerticaly(pictureBox);
            }
            else
            {
                return new Point(500, 400);
            }
        }

        private Point normalMove(PictureBox pictureBox)
        {
            var random = new Random();
            int nextMove = random.Next();
            if (nextMove % 5 == 0)
            {
                return moveInRadius(pictureBox);
            }
            else if (nextMove % 5 == 1)
            {
                return moveHorizontaly(pictureBox);
            }
            else if (nextMove % 5 == 2)
            {
                return moveVerticaly(pictureBox);
            }
            else if(nextMove% 5 == 3)
            {
                return new Point(random.Next(0,900), random.Next(0,600));
            }
            else
            {
                return new Point(500, 400);
            }
        }

        private Point hardmove(PictureBox pictureBox) 
        {
            var random = new Random();
            int nextMove = random.Next();
            if (nextMove % 4 == 0)
            {
                return moveInRadius(pictureBox);
            }
            else if (nextMove % 4 == 1)
            {
                return moveHorizontaly(pictureBox);
            }
            else if (nextMove % 4 == 2)
            {
                return moveVerticaly(pictureBox);
            }
            else
            {
                return new Point(500, 400);
            }
        }

        private int getRandomDirection()
        {
            var random = new Random();
            if (random.Next() % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private Point moveInRadius(PictureBox pictureBox)
        {
            var random = new Random();
            double R = 40 * getDifficultyMultiplier();
            double r = R * Math.Sqrt(random.Next(0,2));
            double theta = random.Next(0,2)*Math.PI*2;
            double x = getCenter(pictureBox).X + r*Math.Cos(theta)*getRandomDirection();
            double y = getCenter(pictureBox).Y + r* Math.Sin(theta)*getRandomDirection();
            int intX = (int)x;
            int intY = (int)y;
            return new Point(intX, intY);
        }

        private Point moveHorizontaly(PictureBox pictureBox)
        {
            var random = new Random();
            int originalX = pictureBox.Location.X;
            int newX = random.Next(originalX - 5 * getDifficultyMultiplier(), originalX + 20*getDifficultyMultiplier());
            return new Point(newX, pictureBox.Location.Y);
        }

        private Point moveVerticaly(PictureBox pictureBox)
        {
            var random = new Random();
            int originalY = pictureBox.Location.Y;
            int newY = random.Next(originalY - 5 * getDifficultyMultiplier(),originalY + 20 * getDifficultyMultiplier());
            return new Point(pictureBox.Location.X,newY);
        }
    }
}

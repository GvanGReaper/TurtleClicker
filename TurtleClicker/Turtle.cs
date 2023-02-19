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
        public Turtle(string difficulty, PictureBox pictureBox)
        {
            this.difficulty = difficulty;
            this.pictureBox = pictureBox;
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
            return result;
        }

        
        //sets the image of the turtle according to the chosen difficulty
        internal void change_Image()
        {
            if(getDifficulty() == "Easy")
            {
                pictureBox.Image = Properties.Resources.ez_mode_turtle;
                pictureBox.Update();
            }
            else if (getDifficulty() == "Normal")
            {
                pictureBox.Image = Properties.Resources.evil_turtle_final; 
                pictureBox.Update();
            }
            else if(getDifficulty() == "Hard")
            {
                pictureBox.Image = Properties.Resources.dead_turtle;
                pictureBox.Update();
            }
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
            //these 3 are currently mostly the same but are within seperate methods and branches for the sake of
            //extendability if we decide to add more unique behavior to each separate difficulty
            if(getDifficulty() == "Easy")
            {
                return easyMove(pictureBox);
            }
            else if(getDifficulty() == "Normal")
            {
                return normalMove(pictureBox);
            }
            else
            {
                return hardmove(pictureBox);
            }     
        }

        private Point easyMove(PictureBox pictureBox)
        {
            var random = new Random();
            int nextMove = random.Next();
            //1 in 4 chance for every one of the following moves
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
                return moveVertically(pictureBox);
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
            //1 in 5 chance here since the turtle can now move in a random point of the screen thus adding a 5th alternative.
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
                return moveVertically(pictureBox);
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
            //1 in 5 chance here since the turtle can now move in a random point of the screen thus adding a 5th alternative.
            //Again,this is the same right now but was added for the sake of it making the possibility of adding more difficulty unique behavior easier.
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
                return moveVertically(pictureBox);
            }
            else if (nextMove % 5 == 3)
            {
                return new Point(random.Next(0, 900), random.Next(0, 600));
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

        //Chooses a random point in a radius of the turtles current location to move to.
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

        //Moves horizontaly within a certain range
        private Point moveHorizontaly(PictureBox pictureBox)
        {
            var random = new Random();
            int originalX = pictureBox.Location.X;
            int newX = random.Next(originalX - 5 * getDifficultyMultiplier(), originalX + 20*getDifficultyMultiplier());
            return new Point(newX, pictureBox.Location.Y);
        }

        //Moves vertically by a certain range
        private Point moveVertically(PictureBox pictureBox)
        {
            var random = new Random();
            int originalY = pictureBox.Location.Y;
            int newY = random.Next(originalY - 5 * getDifficultyMultiplier(),originalY + 20 * getDifficultyMultiplier());
            return new Point(pictureBox.Location.X,newY);
        }
    }
}

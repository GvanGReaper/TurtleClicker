using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleClicker
{
    internal class Rank
    {
        int score;

        public Rank(int score)
        {
            this.score = score;
        }

        public int getScore()
        {
            return score;
        }

        public void setScore(int score)
        {
            this.score = score;
        }

        public String getRank()
        {
            if (getScore() > 0 && getScore() < 10)
            {
                return "F(ailure)";
            }
            if (getScore() >= 10 && getScore() < 20)
            {
                return "E.   You are doing something atleast.";
            }
            else if (getScore() >= 20 && getScore() < 30)
            {
                return "D.   Things are getting interesting!";
            }
            else if (getScore() >= 30 && getScore()   < 40)
            {
                return "C.   Not bad.";
            }
            else if (getScore() >= 40 && getScore() < 50)
            {
                return "B.   Not the Bees!";
            }
            else if (getScore() >= 50 && getScore() < 60)
            {
                return "A.   You getting good at this!";
            }
            else if (getScore() >= 60 && getScore() < 80)
            {
                return "S.   Ok maybe you need to do something better with your life than clicking a turtle...";
            }
            else if (getScore() >= 80 && getScore() < 120)
            {
                return "SS.  Stands for SStyle!";
            }
            else if (getScore() >= 120)
            {
                return "ULTRACLICK!  Ultrakill!";
            }
            else
            {
                return "Maybe try visiting the How to Play section...";
            }
        }
    }
}

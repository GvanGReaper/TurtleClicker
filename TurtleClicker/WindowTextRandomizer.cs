using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleClicker
{
    internal class WindowTextRandomizer
    {
        public String getWindowText()
        {
            var random = new Random();
            int num = random.Next();
            //1 in 20 chance of showing up
            if(num % 20 == 0)
            {
                return "E2M1: I clicked the turtles.";
            }
            else if(num % 20 == 1)
            {
                return "Knee deep in the turtle!";
            }
            else if(num % 20 == 2)
            {
                return "Bocchi the rock!";
            }
            else if(num % 20 == 3)
            {
                return "\"Are you dictating your fucking obituary to me Belmont?\"";
            }
            else if(num % 20 == 4)
            {
                return "Factorio rocks!";
            }
            else if(num% 20 == 5)
            {
                return "To turtle,or not to turtle.THAT is the question";
            }
            else if(num% 20 == 6)
            {
                return "Anyone wanna click some cookies?";
            }
            else if(num % 20 == 7)
            {
                return "01101000 01101001 00001010 ";
            }
            else if(num % 20 == 8)
            {
                return "Try coding in Rust too!";
            }
            else if(num % 20 == 9)
            {
                return "I'LL BE BACK!";
            }
            else if(num % 20 == 10)
            {
                return "GET OUT OF MY SWAMP!!!";
            }
            else if(num % 20 == 11)
            {
                return "Thunderstruck!";
            }
            else if(num % 20 == 12)
            {
                return "It's my life!";
            }
            else if(num % 20 == 13)
            {
                return "TurtleSocial!";
            }
            else if(num % 20 == 14)
            {
                return "Purple turtle clicker fever!";
            }
            else if(num % 20 == 15)
            {
                return "The factory must grow!";
            }
            else if (num % 20 == 16)
            {
                return "Luke...I am your turtle!";
            }
            else if (num % 20 == 17)
            {
                return "Born to be turtle!";
            }
            else if (num % 20 == 18)
            {
                return "The black parade!";
            }
            else
            {
                return "Turtle Clicker!";
            }
        }
    }
}

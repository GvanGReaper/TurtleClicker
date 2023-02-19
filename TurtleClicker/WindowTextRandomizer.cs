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
            if(num % 5 == 0)
            {
                return "E2M1: I clicked the turtles.";
            }
            else if(num % 5 == 1)
            {
                return "Knee deep in the turtle!";
            }
            else if(num % 5 == 2)
            {
                return "Bocchi the rock!";
            }
            else if(num % 5 == 3)
            {
                return "(-_-)...";
            }
            else if(num % 5 == 4)
            {
                return "Somebody once told me...";
            }
            else if(num% 10 == 0)
            {
                return "To turtle,or not to turtle.THAT is the question";
            }
            else if(num% 10 == 1)
            {
                return "Anyone wanna click some cookies?";
            }
            else if(num % 10 == 2)
            {
                return "01101000 01101001 00001010 ";
            }
            else if(num % 10 == 3)
            {
                return "Try coding in Rust too!";
            }
            else if(num % 10 == 4)
            {
                return "I'LL BE BACK!";
            }
            else if(num % 10 == 5)
            {
                return "GET OUT OF MY SWAMP!!!";
            }
            else if(num % 10 == 6)
            {
                return "Thunderstruck!";
            }
            else if(num % 10 == 7)
            {
                return "It's my life!";
            }
            else if(num % 10 == 8)
            {
                return "TurtleSocial!";
            }
            else if(num % 10 == 9)
            {
                return "Purple turtle clicker fever!";
            }
            else
            {
                return "Turtle Clicker!";
            }
        }
    }
}

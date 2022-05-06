using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotConsole
{
    public class Robot
    {
        // initial conditions
        public int maxPos = 4;
        public int minPos = 0;

        public char facing = 'N';
        public List<int> currentXY = new List<int>() { 0, 0 };
        public List<char> compass = new List<char>() { 'N', 'E', 'S', 'W' };

        public string Report()
        {
            return "position: (" + currentXY[0] +", "+ currentXY[1]+ "); facing direction: " + facing + ";";
        }

        public char Left(char faceDir)
        {
            // nwse -> one step down
            int val;
            int idx = compass.IndexOf(faceDir);

            if (idx == 0)
            {
                val = 3;
            }
            else
            {
                val = idx - 1;
            }
            return compass[val];
        }

        public char Right(char faceDir)
        {
            // nesw -> one step up
            int val;
            int idx = compass.IndexOf(faceDir);

            if (idx == 3)
            {
                val = 0;
            }
            else
            {
                val = idx + 1;
            }
            return compass[val];
        }

        public List<int> Moved(char faceDir, List<int> XY)
        {
            //MOVES FOREWARD ONLY 
            List<int> newXY = new List<int>();
            //NS are the y pos
            //WE are the x pos
            int xPos = XY[0];
            int yPos = XY[1];

            if (faceDir == 'N' && yPos != 4)
            {
                yPos++;
            }
            else if (faceDir == 'S' && yPos != 0)
            {
                yPos--;
            }
            else if (faceDir == 'W' && xPos != 0)
            {
                xPos--;
            }
            else if (faceDir == 'E' && xPos != 4)
            {
                    xPos++;
            }
            else
            {
                Console.WriteLine("Respectfully, There's No Way Commander, Nothing Could Survive That!");
                Console.WriteLine("Please Consider Another Direction.");
            }

            newXY.Add(xPos);
            newXY.Add(yPos);

            return newXY;
        }
        public void Placed(Robot rob)
        {
            List<int> toStartXY = new List<int>() { 0, 0 };
            rob.facing = 'N';
            rob.currentXY = toStartXY;
        }
    }
}

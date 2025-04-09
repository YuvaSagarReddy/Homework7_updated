using System;
namespace Homework7
{
    public class Solution_1
    {
        public bool JudgeCircle(string moves)
        {
            int RL = 0;
            int UD = 0;

            foreach (char a in moves)
            {
                if (a == 'R')
                {
                    RL++;
                }
                else if (a == 'L')
                {
                    RL--;
                }
                else if (a == 'U')
                {
                    UD++;
                }
                else if (a == 'D')
                {
                    UD--;
                }
            }

            return RL == 0 && UD == 0;

        }
    }
}


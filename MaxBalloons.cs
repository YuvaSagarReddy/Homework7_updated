using System;
namespace Homework7
{
    public class Solution
    {
        public int MaxNumberOfBalloons(string text)
        {
            int balloon_count = 0;
            List<char> balloon = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if ("balloon".Contains(text[i]))
                {
                    balloon.Add(text[i]);
                }
            }

            int b = 0, a = 0, l = 0, o = 0, n = 0;
            foreach (char c in balloon)
            {
                if (c == 'b') b++;
                else if (c == 'a') a++;
                else if (c == 'l') l++;
                else if (c == 'o') o++;
                else if (c == 'n') n++;
            }

            while (b >= 1 && a >= 1 && l >= 2 && o >= 2 && n >= 1)
            {
                balloon_count++;
                b -= 1;
                a -= 1;
                l -= 2;
                o -= 2;
                n -= 1;
            }

            return balloon_count;
        }
    }

}


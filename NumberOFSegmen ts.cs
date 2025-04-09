using System;
namespace Homework7
{
	public class NumberOFSegmen_ts
	{
        public int CountSegments(string s)
        {
            int count = 0;
            bool Segment = false;

            foreach (char c in s)
            {
                if (c != ' ')
                {
                    if (!Segment)
                    {
                        count++;
                        Segment = true;
                    }
                }
                else
                {
                    Segment = false;
                }
            }

            return count;
        }
    }

}



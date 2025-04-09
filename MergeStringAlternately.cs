using System;
namespace Homework7
{
	public class MergeStringAlternately
	{
        public string MergeAlternately(string word1, string word2)
        {
            int a = word1.Length;
            int b = word2.Length;
            int i = 0; int j = 0;

            string output = "";

            while (i < a && j < b)
            {

                output += word1[i];
                output += word2[j];
                i++;
                j++;

            }
            while (i < a)
            {
                output += word1[i];
                i++;
            }
            while (j < b)
            {
                output += word2[j];
                j++;
            }
            return output;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.String
{
    public class PrintAllTheDuplicatesInString
    {
        static int NO_OF_CHAR = 256;

        public void fillCharCounts(string str, int[] count)
        {
            for (int i = 0; i < str.Length; i++)
            {
                count[str[i]]++;
            }
        }

        public void printDups(string str)
        {
            int[] count = new int[NO_OF_CHAR];
            fillCharCounts(str, count); 

            for (int i = 0; i < NO_OF_CHAR; i++)
            {
                if(count[i] > 1)
                    Console.WriteLine((char)i + ", " + "count = " + count[i]);
            }
        }
    }
}

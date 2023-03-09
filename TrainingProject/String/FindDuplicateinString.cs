using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.String
{
    public class FindDuplicateinString
    {
        public int maxChars = 256;

        public void calculate(string s, int[] cal)
        {
            for(int i = 0; i < s.Length; i++)
            {
                cal[s[i]]++;
            }
        }

        public void Run()
        {

            string s = "welcomemywebsite";

            int[] cal = new int[maxChars];
            calculate(s, cal);

            for(int i = 0; i < maxChars; i++)
            {
                if(cal[i] > 1)
                {
                    Console.WriteLine("Character "+ (char)i);
                    Console.WriteLine("Occurrence = " + cal[i] + " times.");
                    Console.ReadKey();
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.String
{
    public class NonRepeatCharacter
    {
        public static int NO_OF_CHARS = 256;
        public static char[] count = new char[NO_OF_CHARS];

        public void getCharCountArray(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                count[str[i]]++;
            }
        }

        public int firstNonRepeating(string str)
        {
            getCharCountArray(str);
            int index = -1, i;

            for (i = 0; i < str.Length; i++)
            {
                if(count[str[i]] == 1)
                {
                    index=i;
                    break;
                }
            }

            return index;
        }
    }
}

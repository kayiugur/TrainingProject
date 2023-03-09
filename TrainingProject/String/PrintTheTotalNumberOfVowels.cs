using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.String
{
    public class PrintTheTotalNumberOfVowels
    {
        public void vowels(string str)
        {
            int i, len, vowel, consonants;

            vowel = 0;  
            consonants = 0;
            len = str.Length;

            for (i = 0; i < len; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' ||
                    str[i] == 'i' || str[i] == 'o' ||
                    str[i] == 'u' || str[i] == 'A' ||
                    str[i] == 'E' || str[i] == 'I' ||
                    str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') ||
                 (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    consonants++;
                }
            }


            Console.WriteLine("count of vowel: " +vowel);
            Console.WriteLine("count of consonants: " + consonants);
            Console.ReadKey();

        }
    }
}

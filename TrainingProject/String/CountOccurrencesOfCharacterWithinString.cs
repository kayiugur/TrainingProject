using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.String
{
    public class CountOccurrencesOfCharacterWithinString
    {
        public void example(string str, char c)
        {
            int freq = str.Count(f => (f == c)); 
            
            Console.WriteLine(freq);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public class HowManyDuplicateInArray
    {
        public void Example(int[] arr)
        {
            var dict = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                dict.TryGetValue(item, out int count);
                dict[item] = count + 1;
            }

            foreach(var pair in dict)
            {
                if (pair.Value != 1)
                { 
                    Console.WriteLine("Value {0} occured {1} times.", pair.Key, pair.Value); 
                }                
            }
                
            Console.ReadKey();
        }
    }
}

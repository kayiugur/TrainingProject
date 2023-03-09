using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public class getPairsCount
    {
        public void Example(int[] arr, int sum)
        {
            int count=0;

            for (int i=0; i < arr.Length; i++)
            {
                for (int j=i+1; j < arr.Length; j++)
                {
                    if((arr[i] + arr[j])== sum)
                    { count++; }
                }
            }

            Console.WriteLine("Count of pairs is " + count);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public class FindMissingNumber
    {
        public int Example (int[] testArray)
        {
            int missNumber, totalSum;
            totalSum = (testArray.Length + 1) * (testArray.Length + 2) / 2;

            foreach(int value in testArray)
            {
                totalSum = totalSum - value;
            }
            missNumber = totalSum;

            return missNumber;
        }
    }
}

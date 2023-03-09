using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public class SortArray
    {
        public List<int> Example(List<int> comingArray)
        {
            int[] arr = comingArray.ToArray();

            //Büyükten Küçüğe Sıralama
            arr = arr.OrderByDescending(x => x).ToArray();
            //Küçükten Büyüğe Sıralama
            arr = arr.OrderBy(x => x).ToArray();

            return arr.ToList();
        }
    }
}

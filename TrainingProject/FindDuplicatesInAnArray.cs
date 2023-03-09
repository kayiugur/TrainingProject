using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public class FindDuplicatesInAnArray
    {
        public List<int> Example()
        {
            int[] array = { 1, 3, 2, 4, 2, 5, 4, 3, 2, 2 };

            var duplicates = array.GroupBy(x => x)
                .Where(c => c.Count() > 1)
                .Select(y => y.Key)
                .ToList();

            return duplicates;
        }
    }
}

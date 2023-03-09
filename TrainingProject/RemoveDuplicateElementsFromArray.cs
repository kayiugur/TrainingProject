using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public class RemoveDuplicateElementsFromArray
    {
		public T[] RemoveArrayDuplicates<T>(T[] array)
		{
			HashSet<T> set = new HashSet<T>(array);
			T[] result = new T[set.Count];
			set.CopyTo(result);
			return result;
		}
	}
}

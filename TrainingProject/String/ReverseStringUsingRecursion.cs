using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.String
{
    public class ReverseStringUsingRecursion
    {
        public void reverse(string str)
        {
            if ((str == null) || (str.Length <= 1))
                Console.WriteLine(str);
            else
            {
                Console.WriteLine(str[str.Length - 1]);
                reverse(str.Substring(0, (str.Length - 1)));
            }
        }
    }
}

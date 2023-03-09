using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.String
{
    public class Rotations
    {
        public bool areRotations(string str1, string str2)
        {
            return (str1.Length == str2.Length) && ((str1 + str1).IndexOf(str2) != -1);
        }
    }
}

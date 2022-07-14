using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureExercise
{
    public class FindTheFactorial
    {
        public static int ReverseFactorial(int number)
        {
            if (number == 0)
                return 1;
            else
                return number * ReverseFactorial(number - 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureExercise
{
    public class CalcPower
    {
        public static double ClacPowerOfNumber(int number , int power)
        {
            if (power == 0)
                return number;
            else 
                return number * ClacPowerOfNumber(number, power - 1 );
        }
    }
}

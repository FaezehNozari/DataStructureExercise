using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureExercise
{
    public class CalcSquare
    {
        public static string CalcuSquareEachNumber(int[] number)
        {
            var Result = number.Select(x => x * x);
            return String.Join(Environment.NewLine, Result);
        }
    }
}

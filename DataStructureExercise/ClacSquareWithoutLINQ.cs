using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureExercise
{
    public class ClacSquareWithoutLINQ
    {
        public static String SquareArray(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = (int)Math.Pow(array[i], 2);
            }
            return String.Join(Environment.NewLine, result) ;
        }
    }
}

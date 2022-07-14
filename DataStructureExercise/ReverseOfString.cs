using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureExercise
{
    public class ReverseOfString
    {
         public static void ReverseString(string str)
        {
            
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(array);
        }
    }
}

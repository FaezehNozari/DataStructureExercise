using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureExercise
{
    internal class CharactersAndFrequency
    {
        public static string CharAndFrequence(string word)
        {
            var calc =
                        word
         .GroupBy(g => g).Select(x => new
                                     { Character = x.Key, frequency = x.Count() });

            return String.Join(Environment.NewLine, calc);
        }
    }
}

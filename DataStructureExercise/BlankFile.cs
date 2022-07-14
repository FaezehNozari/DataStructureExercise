using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataStructureExercise
{
    public class BlankFile
    {
        public static void CreateBlankFile(string str)
        {
            
            File.CreateText(str);

        }
    }
}

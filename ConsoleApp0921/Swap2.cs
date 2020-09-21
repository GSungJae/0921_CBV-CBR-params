using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class Swap2
    {
        static void ChangeWord(string arg)
        {
            arg = "World";
        }
        static void ChangeWord(ref string arg)
        {
            arg = "WorlD";
        }
        static void Main()
        {
            string str = "HellO";
            ChangeWord(str);
            Console.WriteLine(str);

            ChangeWord(ref str);
            Console.WriteLine(str) ;
        }
    }
}

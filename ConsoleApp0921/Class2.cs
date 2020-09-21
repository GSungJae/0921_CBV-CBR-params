using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class Class2
    {
        static int Divide(int x, int y, ref int mod)
        {
            mod = x % y;
            return x / y;
        }
        static void Main()
        {
            int x = 10;
            int y = 4;
            int mod = 0;
            Console.WriteLine($"몫 : {Divide(x,y,ref mod)} 나머지: {mod}");
        }
    }
}

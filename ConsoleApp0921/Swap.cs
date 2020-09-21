using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    //class MyCalc
    //{

    //}
    class Swap
    {
        static void VSwap(out int x, out int y)
        {
            x = 3;
            y = 5;

            int temp = x;
            x = y;
            y = temp;
        }
        //static void VSwap(ref int x,ref int y)
        //{

        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //static void VSwap(int x, int y)
        //{
            
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        static void Main()
        {
            int x = 3;
            int y = 5;

            Console.WriteLine($"x={x}, y={y}");

            //VSwap(ref x, ref y);
            VSwap(out x, out y);

            Console.WriteLine($"x={x}, y={y}");

            string str = "10";
            int num;
            if (!int.TryParse(str, out num))
                num = 0;

            Console.WriteLine(num);
        }
    }
}

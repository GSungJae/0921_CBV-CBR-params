using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class Class3
    {
        static int sum(int [] arr)
        {
            int tot = 0;
            foreach(int num in arr)
            {
                tot += num;
            }
            return tot;
        }
        static int sumparams(params int[] arr)
        {
            int tot = 0;
            foreach (int num in arr)
            {
                tot += num;
            }
            return tot;
        }
        static int sum(int a, int b)
        {
            return a + b;
        }
        static int sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        static void Main()
        {
            int[] arr= new int[5] { 3, 5, 2, 12, 4 };
            Console.WriteLine(sum(arr));

            Console.WriteLine(sum(new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));

            Console.WriteLine(sumparams(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }
    }
}

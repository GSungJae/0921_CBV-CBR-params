using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    class Point
    {
        public int x = 0;
        public int y = 0;
    }
    class Swap3
    {
        static void swap(Point p1)
        {
            int temp = p1.x;
            p1.x = p1.y;
            p1.y = temp;
        }
        static void Main()
        {
            Point p1 = new Point();
            p1.x = 3;
            p1.y = 5;

            Console.WriteLine($"x={p1.x}, y={p1.y}");
            swap(p1);
            Point p2 = new Point();
            p2.x = p1.x;
            p2.y = p1.y;

            swap(p2);

            Console.WriteLine($"x={p1.x}, y={p1.y}");
            Console.WriteLine($"x={p2.x}, y={p2.y}");
        }
    }
}

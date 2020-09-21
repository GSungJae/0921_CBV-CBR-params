using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{
    abstract class Person
    {
        public abstract void Speak();
        
        public void Work()
        {
            Console.WriteLine("일하는중");
        }
        public void Study()
        {
            Console.WriteLine("공부하는중");
        }
    }
    class Employee : Person
    {
        public override void Speak()
        {
            Console.WriteLine("Employee가 일을 합니다.");
        }
    }
    class Class1
    {
        static void  Main()
        {
            Employee employee = new Employee();
            employee.Speak();

        }
    }
}

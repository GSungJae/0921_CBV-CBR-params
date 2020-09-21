using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0921
{

    class Time
    {
        int hours;
        int minutes;

        //public Time(int hours, int minutes)
        //{
        //    this.hours = hours;
        //    if (minutes % 60 >= 1)
        //    {
        //        int a = 0;
        //        int minhours = minutes / 60;
        //        hours = hours + a;
        //        this.minutes = minutes;
        //    }
        //}
        public Time(int minutes) : this(0, minutes) { }        
        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes=minutes;
            Examine();
        }

        private void Examine()
        {
            if (hours < 0 || minutes < 0)
            {
                Console.WriteLine("올바르지 않은 입력값입니다.");
                return;
            }

            hours = hours + (minutes / 60);
            minutes = minutes % 60;
        }

        public override string ToString()
        {

            return hours + " : " + minutes;
            
        }

        public override bool Equals(object obj)
        {
            return obj is Time time && hours == time.hours && minutes == time.minutes;
        }
        public override int GetHashCode()
        {
            int hashCode = -1103285950;
            hashCode = hashCode * -1521134295 + hours.GetHashCode();
            hashCode = hashCode * -1521134295 + minutes.GetHashCode();
            return hashCode;
        }
        private int TotalMinutes()
        {
            return hours * 60 + minutes;
        }
         public static Time operator +(Time t1, Time t2)
        {
            return new Time(t1.TotalMinutes() + t2.TotalMinutes());
        }
        public static Time operator -(Time t1, Time t2)
        {
            return new Time(t1.TotalMinutes() - t2.TotalMinutes());
        }
        public static Time operator ++(Time t1)
        {
            return new Time(t1.TotalMinutes() + 1);
        }
        public static bool operator >(Time t1, Time t2)
        {

            return t1.TotalMinutes() > t2.TotalMinutes();
        }
        public static bool operator <(Time t1, Time t2)
        {
            return t1.TotalMinutes() < t2.TotalMinutes();
        }
        //public static bool operator ==(Time left, Time right)
        //{
        //    return EqualityComparer<Time>.Default.Equals(left, right);
        //}

        //public static bool operator !=(Time left, Time right)
        //{
        //    return !(left == right);
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Time 클래스를 정의한다.
            // int hours와 int minutes를 멤버로 갖는다.
            // 생성자(hour, minutes)

            
            
            Time t1 = new Time(10, 0);
            Console.WriteLine(t1.ToString());

            Time t2 = new Time(10, 0);
            Console.WriteLine(t1.Equals(t2));

            Time t3 = t1 + t2;
            Console.WriteLine(t3.ToString());

            t1++;
            Console.WriteLine(t1.ToString());

            Console.WriteLine(t1 > t2);
            Console.WriteLine(t1 < t2);

        }
    }
}

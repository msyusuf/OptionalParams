using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// a class (Time) with 4 overloaded constructors
namespace OptionalParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time();   // creating an obj of Time with no arguments
            Time t2 = new Time(10);   // creating an obj of Time with no arguments
            Time t3 = new Time(10,12);   // creating an obj of Time with no arguments
            Time t4 = new Time(10, 12, 32);   // creating an obj of Time with no arguments
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);

        } // end of method Main
    } // end of Class Program
    class Time
    {
        private int hours, minutes, seconds;    // instance variables
        public Time()
            : this(0,0,0)
        {

        } // constructor 1
        public Time(int h)
            : this (h, 0, 0)
        {
        } // constructor 2
        public Time(int h, int m) : this(h, m, 0) { } // constructor 3

        public Time(int h, int m, int sec)
        {
            hours = h;
            minutes = m;
            seconds = sec;
        } // // constructor 4
        public override string ToString()
        {
            // return base.ToString();
            return string.Format($"The time is {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    } // end of Class Time
} // end namespace

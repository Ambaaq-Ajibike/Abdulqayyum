using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int r = Environment.TickCount;
            double second = r / 1000;
            double minute = second / 60;
            double hour = minute / 60;
            double days = hour / 24;
            System.Console.WriteLine(r);
            System.Console.WriteLine(second);
            System.Console.WriteLine(minute);
            System.Console.WriteLine(hour);
            System.Console.WriteLine(days);
        
        }
    }
}
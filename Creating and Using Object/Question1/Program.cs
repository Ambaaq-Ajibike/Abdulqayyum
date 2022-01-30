using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            {
                System.Console.WriteLine("Enter the year");
                int year = int.Parse(Console.ReadLine());
                System.Console.WriteLine(DateTime.IsLeapYear(year));           
            }
        }
    }
}
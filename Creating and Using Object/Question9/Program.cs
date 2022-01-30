using System;
using System.Collections.Generic;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<DateTime> NonWorkingDays = new List<DateTime>()
            {
                new DateTime(2022, 1, 1),
                new DateTime(2022, 1, 2),
                new DateTime(2022, 4, 15),
                new DateTime(2022, 4, 18),
                new DateTime(2022, 5, 1),
                new DateTime(2022, 6, 12),
                new DateTime(2022, 7, 9),
                new DateTime(2022, 10, 1),
                new DateTime(2022, 10, 8),
                new DateTime(2022, 12, 26),
                new DateTime(2022, 12, 25)
            };
            int count = 0;
            System.Console.WriteLine("Enter the date");
            DateTime da = DateTime.Parse(Console.ReadLine());
            //System.Console.WriteLine(DateTime.Now.DayOfWeek);
            for (DateTime i = DateTime.Now; i.Date < da; i= i.AddDays(1))
            {
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !NonWorkingDays.Contains(i.Date))
                {
                    count++;
                }
            }
            System.Console.WriteLine(count);
        }
    }
}
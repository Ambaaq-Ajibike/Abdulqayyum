using System;
namespace Question10
{
    public class Program
    {        
        public static void Main(string[] args)
        {
            int sum = 0;
            string number = "43 68 9 23 318";
            var num = number.Split(" ");
            foreach (var item in num)
            {
                int a = int.Parse(item);
                sum+= a;
            }
            System.Console.WriteLine(sum);
        }              
    }
}
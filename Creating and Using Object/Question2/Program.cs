using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {    
            
            Random rnd = new Random();
           for (var i = 0; i < 10; i++)
           {
                System.Console.WriteLine(rnd.Next(100, 200));
           }
           
        }
    }
}
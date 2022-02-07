using System;
namespace Number2
{
    class Program
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine("Enter the length of the numbers");      
            int l = int.Parse(Console.ReadLine());
            Stack<int> reverse = new Stack<int>();
            for (var i = 0; i < l; i++)
            {
                System.Console.WriteLine("Enter num");
                int num = int.Parse(Console.ReadLine());
                reverse.Push(num);                
            }
            foreach (var num in reverse)
            {
                System.Console.Write(num);
            } 
        }
    }
}
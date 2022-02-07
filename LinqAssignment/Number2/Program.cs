using System;
namespace Number2
{
    class Program
    {
        public static void Main(string[] args)
        {
           int[] myarr = {1, 2, 3, 4, 7, 5};
           System.Console.WriteLine("Sum");
           int result = myarr.MySum();
           System.Console.WriteLine(result);

           System.Console.WriteLine("Max"); 
           int Maxresult = myarr.MyMax();
           System.Console.WriteLine(Maxresult);

           System.Console.WriteLine("Min");
           int Minresult = myarr.MyMin();
           System.Console.WriteLine(Minresult);
           System.Console.WriteLine(); 

           System.Console.WriteLine("Average");
           double Avresult = myarr.MyAverage();
           System.Console.WriteLine(Avresult);
           System.Console.WriteLine();          
        }
    }
}
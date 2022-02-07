using System;
namespace Number6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numarr = {2, 3, 14, 21, 42};
            System.Console.WriteLine("Method Synthax");
            var checknnumDivisibleby7and3 = numarr.Where(x => x % 3 == 0 && x % 7 == 0);
            foreach (var item in checknnumDivisibleby7and3)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Query Synthax");
            var checknumDivisibleby7and3 = from num in numarr where num % 3 == 0 && num % 7 == 0 select num;
            foreach (var item in checknumDivisibleby7and3)
            {
             System.Console.WriteLine(item);   
            }
        }
    }
}
using System;
namespace Number4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            int b = 0;
             int c = 0;
             int d = 0;
             List<int> num = new List<int>(){1, 2, 2, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3};
             List<int> occurmost = new List<int>();
             for (var i = 1; i < num.Count; i++)             
            {
               if(num[i] == num[i - 1])
               {
                   count ++;
                   b = count;
               } 
               else
               {
                   count = 0;
               }
                if (b > c )
               {
                   d = num[i - 1];
                   c = b;
                   b = 0;
               }           
            }
            for (var i = 0; i <= c; i++)
            {
                occurmost.Add(d);
            }
            foreach (var item in occurmost)
            {
                System.Console.Write(item +", ");
            }
        

        }
    }
}
using System;
namespace Number9
{
    class Program
    {
        public static void Main(string[] args)
        {
             int S1 = 2;
            int S2 = 0;
            int S3 = 0;
            int S4 = 0;
            //int l = 2;
            List<int> num = new List<int>();
            num.Add(S1);
            for (int i = 1; i < 50 ; i+= 3)
            {
                
                S2 = S1 + 1;
                S3 = 2 * S1 + 1;
                S4 = S1 + 2;
                num.Add(S2);
                num.Add(S3);
                num.Add(S4);
                S1 = num[i];                                    
            }
            Queue<int> que = new Queue<int>();
            for (var i = 0; i < 50; i++)
            {
                que.Enqueue(num[i]);
            }
            foreach (var item in que)
            {
                System.Console.Write(item+ ", ");
            }
            System.Console.WriteLine();
        }
    }
}
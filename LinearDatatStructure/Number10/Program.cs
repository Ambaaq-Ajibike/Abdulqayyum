using System;
namespace Number10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> stk = new Queue<int>();
             int N = 5;
             int M = 16;
            stk.Enqueue(N);
            //int count = 0;
            while(true)
            {
                //count++;
                int a = stk.Dequeue();
                if (!stk.Contains(N))
                {
                     stk.Enqueue(N);
                }
               if (((a + 2) < M) && !stk.Contains(a + 2))
                {
                    stk.Enqueue(a + 2);
                } 
                if (((a * 2) < M) && !stk.Contains(a * 2))
                {
                   
                    stk.Enqueue(a * 2);
                }                                
                if (((a + 1) < M) && !stk.Contains(a + 2))
                {
                    stk.Enqueue(a + 1);
                }  
                else
                {
                    stk.Enqueue(M);
                    break;
                }  
                //System.Console.WriteLine(a);   
            }
            //System.Console.WriteLine(count);
            foreach (var item in stk)
            {
                System.Console.Write(item+", ");
            }
        }
    }
}
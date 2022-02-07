using System;
namespace Number5
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> integers = new List<int>(){19, -10, 12,-3, -6, 34, -2, 5};
            foreach(int elements in integers)
            {
                if (elements >= 0)
                {
                     System.Console.WriteLine(elements);
 
                }
            }
        }
    }
}
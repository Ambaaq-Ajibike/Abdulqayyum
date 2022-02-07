using System;
namespace Number7
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> num = new List<int>(){4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 5, 5};
            Dictionary<int, int> hash = new Dictionary<int, int>();
            foreach (var item in num)
            {
                if (hash.ContainsKey(item))
                {
                    hash[item] = hash[item] + 1;
                }
                else
                {
                    hash.Add(item, 1);
                }
            }
            foreach (var element in hash)
            {
                System.Console.WriteLine($"{element.Key} ---> {element.Value}");                
            }
        }
    }
}
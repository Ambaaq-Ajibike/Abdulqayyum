using System;
namespace Number6
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
                if (element.Value % 2 == 0)
                {
                    for(int i = 0; i< element.Value; i ++)
                    {   
                        System.Console.WriteLine(element.Key);
                    }
                }
            }
        }
    }
}
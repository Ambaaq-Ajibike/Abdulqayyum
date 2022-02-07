using System;
namespace Number1
{
    class Program
    {
        public static void Main(string[] args)
        {
            double sum = 0;
            string checksp = "";
            List<int> numlist = new List<int>();
            System.Console.WriteLine("Enter num 1 after the other");            
            for (int i = 0; true; i++)
            {
                System.Console.Write($"enter num {1 + i}:\t ");
                checksp = Console.ReadLine();                    
                if(checksp != "")
                {
                    int num = int.Parse(checksp);
                    numlist.Add(num);  
                }
                else
                {
                   break;
                }                            
            }
            foreach (var item in numlist)
            {
                sum += item;
            }
            System.Console.WriteLine($"The sum of the number is{sum}");
            System.Console.WriteLine($"The average of the number is {sum / numlist.Count}");             
        }
    }
}
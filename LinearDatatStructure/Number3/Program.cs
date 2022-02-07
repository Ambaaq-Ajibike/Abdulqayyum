using System;
namespace Number3
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numlist = new List<int>();
            System.Console.WriteLine("enter the Length of the number you want to enter");
            int l = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the numbers");            
            for(int i = 0; i < l; i++)
            {      
                System.Console.WriteLine("Enter num" + (i + 1) );          
                    int num = int.Parse(Console.ReadLine());                    
                    numlist.Add(num);                                     
            }            
            numlist.Sort();
            System.Console.Write("The result after sorting is ");
            foreach (var item in numlist)
            {
                System.Console.Write(item + " ");
            }
        }
    }
}
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Who are you to this company");
            string personality = Console.ReadLine().ToLower();
            if (personality == "manager")
            {
                Menu.AllowManager();
                Console.WriteLine("Did you want to view customers profile ?");
                string viewprofile = Console.ReadLine().ToLower();
                if (viewprofile == "yes") 
                {
                    Menu.ViewTransactions();
                 }
            }
            else if (personality == "customer")
            {
                Menu.Buygoods();
            }
        }
    }
}

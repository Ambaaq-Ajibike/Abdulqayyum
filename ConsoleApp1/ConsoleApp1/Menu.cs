using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Menu
    {
        public static void AllowManager()
        {
            System.Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your Identification Number");
            int ID = int.Parse(Console.ReadLine());
            if (ID == Manager.GenerateManagerID())
            {
                Manager manage = new Manager(name, ID);
                System.Console.WriteLine("As a manger you have successfully logged in to Ambaaq SuperMart");
                Console.WriteLine("You can now fill the stall with commodities to be purchased by consumer with their prices");
                System.Console.WriteLine("Enter the number of goods for sale");
                int numberOfgood = int.Parse(Console.ReadLine());
                for (int i = 0; i < numberOfgood; i++)
                {
                    Console.WriteLine($"Enter commodity {i + 1}");
                    string stockname = Console.ReadLine();
                    global::System.Console.WriteLine("Enter the price");
                    int price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the quantity");
                    int quantity = int.Parse(Console.ReadLine());
                Stock stock = new Stock(stockname, price, quantity);

                }
                Console.WriteLine("Enter view commodities see all commodity present int the stall");
                int viewCommodity = int.Parse(Console.ReadLine());
                if (viewCommodity == 3)
                {
                        Stock.ViewStocks();
                }


            }
            else
            {
                Console.WriteLine("You are not our manager");
            }
        }
        public static void Buygoods()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your phone number");
            string phonenum = Console.ReadLine();
            Console.WriteLine("Enter the Commodity you want to purchase");
            string commoditypurchased = Console.ReadLine();
            for (int j = 0; j < Stock.Stocks.Count; j++)
            {
                Stock s = Stock.Stocks[j];
                if (commoditypurchased == s.StockName)
                {
                    Console.WriteLine("How many did you want to buy");
                    int quantity = int.Parse(Console.ReadLine());
                    if (quantity == s.StockQuantity)
                    {
                        Console.WriteLine($"The goods you intend to buy cost {s.StockPrice + 35} per one and all you money cost {(s.StockPrice + 35) * quantity}");
                        Console.WriteLine("You can pay us through Yusluv bank : account number is : 31338742");
                        Console.WriteLine("Thanks for visiting Ambaaq online shopping stall");
                        Customer customer = new Customer(name, address, phonenum, commoditypurchased, quantity, DateTime.Now);
                    }
                }
                else
                {
                    Console.WriteLine("This goods is not available now");

                }
            }
        }
        public static void ViewTransactions()
        {
            Customer.VeiwCostumers();
        }

    }
}


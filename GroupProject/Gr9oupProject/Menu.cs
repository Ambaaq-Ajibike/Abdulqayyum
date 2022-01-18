using System;


    public class Menu
    {
        public void AllowManager()
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
                        for (int i = 0; i < numberOfgood; i ++)
                    {
                            Console.WriteLine($"Enter commodity {i + 1}");
                        string stockname = Console.ReadLine();
                        global::System.Console.WriteLine("Enter the price");
                        int price = int.Parse(Console.ReadLine());
                        stockname stocks = new Stock(stockname, price);

                    }
                Console.WriteLine("Enter view commodities see all commodity present int the stall");
                string viewCommodity = Console.ReadLine().ToLower();
                if (viewCommodity == "view commodity")
                {
                    Console.WriteLine(ViewStocks());
                }

                
            }
        }
         
    }
}

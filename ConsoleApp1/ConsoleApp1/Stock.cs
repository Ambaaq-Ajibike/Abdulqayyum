using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Stock
    {
        public string StockName { get; set; }
        public  double StockPrice { get; set; }
        public int StockQuantity { get; set; }
     public  static List<Stock> Stocks = new List<Stock>();
        public Stock(string stockname, double stockprice, int stockquantity)        
         {
                        StockName = stockname;
                        StockPrice = stockprice;
                         StockQuantity = stockquantity;
                        AddStock();

          }
        public void AddStock()
        {
            Stocks.Add(this);

        }
        public static void ViewStocks()
        {
           for(int i = 0; i < Stocks.Count; i ++)
            {
                Console.WriteLine($"{i + 1} Goods Name: {Stocks[i].StockName}  and its price is {Stocks[i].StockPrice} and it contains {Stocks[i].StockQuantity}");
            }

        }
       
     }
}

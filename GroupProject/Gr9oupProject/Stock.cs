using System;

namespace GroupProject
{
                public class Stock
                {
                    public static string StockName { get; set; }
                    public static string StockPrice { get; set; }
                    List<Stock> Stocks = new List<Stock>();
                    public Stock(string stockname; string stockprice)        
                    {
                        StockName = stockname;
                        StockPrice = stockprice;
                        AddStock();
                    }
                    public void AddStock()
                    {
                        Stocks.Add(this);

                    }
                    public static void ViewStocks()
                    {
                        foreach (var items in Stocks)
                        {
                            System.Console.WriteLine(items);
                        }
                }
    

}
  



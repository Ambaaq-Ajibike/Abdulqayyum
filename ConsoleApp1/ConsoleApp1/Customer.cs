using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CommodtyPurchased { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfPurchase { get; }
        public static List<Customer> CustomersInfo = new List<Customer>();
        public Customer(string name,string address, string phonenumber, string commodityPurchased, int quantity, DateTime dateOfpurchase)
        {
            Name = name;
            Address = address;
            PhoneNumber = phonenumber;
            CommodtyPurchased = commodityPurchased;
            Quantity = quantity;
            DateOfPurchase = dateOfpurchase;
            AddCustomersInfo();
        }
        public int GenerateCostumerID()
        {
            Random random = new Random();
            return random.Next(265, 10934);
        }
        public void AddCustomersInfo()
        {
            CustomersInfo.Add(this);
        }
        public static void  VeiwCostumers()
        {
           for (int i = 0; i < CustomersInfo.Count; i ++)
            {
                Console.WriteLine($"{i + 1}  {CustomersInfo[i]. Name}  {CustomersInfo[i].Address}  {CustomersInfo[i].PhoneNumber}  {CustomersInfo[i].CommodtyPurchased} {CustomersInfo[i].Quantity}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string CommodtyPurchased { set; set; }
       public DateTime DateOfPurchase { get; }
            List<Customer> CustomersInfo = new List<Customer>();
            public Customer(string name, string commodityPurchased, DateTime dateOfpurchase)
            {
                Name = name;
                CommodtyPurchased = commodityPurchased;
                DateOfPurchase = dateOfpurchase;
                CustomersID();
            }
            public int GenerateCostumerID()
            {
                Random random = new Random();
                return random.Next(265, 10934);
            }
            public void AllCustomersInfo()
            {
                CustomersInfo.Add(this);
            }
            public void VeiwCostumers()
            {
                foreach (var info in CustomersInfo)
                {
                    System.Console.WriteLine(info);
                }
            }       
            
    }
}

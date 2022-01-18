using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public  class Manager
    {
        public string Name;
        public  int ManagerID;
        public Manager(string name, int managerID)
        {
            Name = name;
            ManagerID = managerID;
        }
        public static int GenerateManagerID()
        {
            Random rnd = new Random();
            return rnd.Next(5, 100);
        }
    }
}

using System;
namespace Number5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student[] stu = 
            {
                new Student(){FirstName = "Ajibike", LastName = "AbdulQayyum", Age = 18},
                new Student(){FirstName = "Bolu", LastName = "Tawakalt", Age = 15},
                new Student(){FirstName = "Ajibike", LastName = "Bolu", Age = 20},
                new Student(){FirstName = "Ayo", LastName = "Ade", Age = 30}
            };
            System.Console.WriteLine("Using method");
            System.Console.WriteLine();
            var sortname = stu.OrderByDescending(x => x.FirstName).ThenByDescending(p => p.LastName);
            foreach (var item in sortname)
            {
                System.Console.WriteLine($"{item.FirstName}\t{item.LastName}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Using Query");
            var sortnameByQuery = from s in stu orderby s.FirstName descending orderby s.LastName descending select s;
            foreach (var item in sortnameByQuery)
            {
                 System.Console.WriteLine($"{item.FirstName}\t{item.LastName}");
               
            }
        }
    }
}
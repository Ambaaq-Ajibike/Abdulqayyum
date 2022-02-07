using System;
namespace Number4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stu = new List<Student>()
            {
                new Student(){FirstName = "Ajibike", LastName = "AbdulQayyum", Age = 18},
                new Student(){FirstName = "Bolu", LastName = "Tawakalt", Age = 15},
                new Student(){FirstName = "Ajibike", LastName = "Bolu", Age = 20},
                new Student(){FirstName = "Ayo", LastName = "Ade", Age = 30}
            };

             var choosebetween18and24 = from s in stu where s.Age > 18 && s.Age < 24 select s;
             foreach (var item in choosebetween18and24)
             {
                 System.Console.WriteLine($"First Name: {item.FirstName}\nLast Name: {item.LastName}");
             }
        }
    }
}
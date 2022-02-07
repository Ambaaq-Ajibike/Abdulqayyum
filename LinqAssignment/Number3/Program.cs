using System;
namespace Number3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student[] st = 
            {
                new Student(){FirstName = "Ajibike", LastName = "AbdulQayyum"},
                new Student(){FirstName = "Bolu", LastName = "Ade"},
                new Student(){FirstName = "Ajibike", LastName = "Ajiboke"},
                new Student(){FirstName = "Ayo", LastName = "Ade"}
            };
            PrintStudent(st);
        }
       
        public static void PrintStudent(Student[] stu)
        {
            var cd = from s in stu where s.FirstName.CompareTo(s.LastName) == -1 select s;
            foreach (var item in cd)
            {
                System.Console.WriteLine($"{item.FirstName}\t{item.LastName}");
            }
        }
    }
}
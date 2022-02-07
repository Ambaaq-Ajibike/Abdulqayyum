using System;
using System.Collections;
using System.Collections.Generic;
namespace Number8
{
    class Program
    {
        public static void Main(string[] args)
        {
           //var phonebook = new {};
            Guid rnd = Guid.NewGuid();
            var a = rnd;
            // char ch = ((char)a);
            string name = $"{a}{a}{a}{a}{a}";
            string number = $"{a}{a}{a}{a}{a}{a}{a}{a}{a}{a}{a}{a}{a}{a}";
            string num = $"{a}{a}{a}{a}{a}{a}{a}{a}{a}{a}{a}{a}{a}";
            string nums = $"{a}{a}{a}{a}{a}{a}{a}{a}{a}{a}{a}";
            // Dictionary<string, List<string>> phoneBook = new Dictionary<string, List<string>>();
            // phoneBook.Add(Enumerable.Range(name, new List<string>(){number, number, number}));
             DateTime st = DateTime.Now;
            // System.Console.WriteLine("Using method");
            // System.Console.WriteLine(DateTime.Now - st);
             Dictionary<string, List<Guid>> phoneBooks = new Dictionary<string, List<Guid>>();
            for (var i = 0; i < 50000; i++)
            {
                phoneBooks.Add(name, new List<Guid>(){a});
            }
            System.Console.WriteLine();
            System.Console.WriteLine("using loop");
            System.Console.WriteLine(DateTime.Now - st);
            // int p = 300;
            // System.Console.WriteLine((char)p);


        }
    }
}
 //new { Color = "Red", Brand = "BMW", Speed = 180 }
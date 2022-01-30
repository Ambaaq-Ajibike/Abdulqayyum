using System;
namespace  CreatingAndUsingObjects 
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Cat cat = new cat("cat");
            List<Cat> cats = new List<Cat>()
            {
                new Cat("cat"),
                new Cat("cat"),
                new Cat("cat"),
                new Cat("cat"),
                new Cat("cat"),
                new Cat("cat"),
                new Cat("cat"),
                new Cat("cat"),
                new Cat("cat"),
                new Cat("cat")
            };
            foreach (var cat in cats)
            {
                System.Console.WriteLine($"{cat.Name} {Sequence.NextValue()} {Cat.SayMieu()}");
            }
        }
    }
}
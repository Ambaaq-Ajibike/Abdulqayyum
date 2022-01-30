using System;
namespace Question11
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] phrases = {"The product is excellent.", "This is a great product.", "I use this product constantly.",
                                 "This is the best product from this category."};
            string[] stories =  {"Now I feel better.", "I managed to change.","It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."};
            string[] firstname =  {"Dayan", "Stella", "Hellen", "Kate"};
            string[] lastname =  {"Johnson", "Peterson", "Charls"};
            string[] cities =  {"London", "Paris", "Berlin", "New York", "Madrid"};
            System.Console.WriteLine($"{phrases[rnd.Next(0, phrases.Length)]} {stories[rnd.Next(0, stories.Length)]} {firstname[rnd.Next(0, firstname.Length)]} {lastname[rnd.Next(0, lastname.Length)]}  {cities[rnd.Next(0, cities.Length)]}   ");
        
        }
    }
}
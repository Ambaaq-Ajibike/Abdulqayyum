using System;
namespace CreatingAndUsingObjects
{
    public class Cat
    {
       public string Name{get; set;}
       public Cat(string name)
       {
           Name = name;
       }
       public static string SayMieu()
       {
           return ($"say Meeeeeiiiuuu");
       }
    }
}
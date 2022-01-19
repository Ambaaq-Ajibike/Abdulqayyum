using System.Collections;
using System.Collections.Generic;
using System;

namespace MyNamespace
{
    public class MyClass
    {
       static void Main(string[] args)
       {
            int Count = 0;
               char[] arr = {'a', 'd', 'a'};
               Array.Sort(arr);
               for (var i = 0; i < arr.Length -1; i++)
               {
                   if (arr[i] == arr[i + 1])
                   {
                       Count++;
                   }
               }
               if ((Count * 2) == arr.Length || (Count * 2)== arr.Length - 1)
               {
                   Console.WriteLine("The word can form palindrome");
               } 
               else
               {
                   Console.WriteLine("The word cannot form palindrome");                   
               }
       }
    }
}
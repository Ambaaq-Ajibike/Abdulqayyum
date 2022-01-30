using System;
namespace Question65
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("To calculate the area of the triangle with 3 sides press 1");            
            System.Console.WriteLine("To calculate the area of the triangle with 2 sides press 2");            
            System.Console.WriteLine("To calculate the area of the triangle with angle press 3");            
            int ar = int.Parse(Console.ReadLine());
            if (ar == 1)
            {
                System.Console.WriteLine("Enter the length");
                double a = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the breadth");
                double b = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the height");
                double c = double.Parse(Console.ReadLine());
                double p = ((a + b + c) / 2);
                double area1 = Math.Sqrt(p*(p - a) * (p - b) * (p - c));
                System.Console.WriteLine(area1); 
            } 
            else if (ar == 2)
            {
                System.Console.WriteLine("Enter the length");
                double a = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the breadth");
                double b = double.Parse(Console.ReadLine());
                double S = ((a * b) / 2);
                System.Console.WriteLine(S);            
            }
            else if(ar == 3)
            {
                System.Console.WriteLine("Enter the length");
                double a = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the breadth");
                double b = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the angle"); 
                double angle = double.Parse(Console.ReadLine());
                double T = ((a * b * Math.Sin(angle)) / 2);
                System.Console.WriteLine(T);
            }  
        }
    }
}
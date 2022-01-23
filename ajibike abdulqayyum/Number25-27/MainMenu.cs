using System;

namespace Number25
{
    //Number 26
    public class MainMenu
    {
        public static void PrintResult()
        {
            System.Console.WriteLine("Enter the numerator");
            double numerator = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the denominator");
            double denominator = double.Parse(Console.ReadLine());
            if (denominator % numerator == 0)
            {
                Fraction.CancelFraction(numerator, denominator); 
            }
            else if (numerator  < denominator)
            {
                System.Console.WriteLine(Fraction.PrintDecimal(numerator, denominator));     
            }           
            else
            {
                System.Console.WriteLine(Fraction.Parse(numerator, denominator));
            }
            
            
            
                
                 

            
        }
    }
}
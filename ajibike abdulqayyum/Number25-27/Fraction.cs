using System;

namespace Number25
{
    public class Fraction
    {
        public double Numerator{get; set;}
        public double Denominator{get; set;}
        public Fraction(double numerator, double denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
        public static string Parse(double numerator, double denominator)
        {
            return $"{numerator} / {denominator}";
        }
        public static double PrintDecimal(double numerator, double denominator)
        {
            return (numerator / denominator);
        }
        public static void CancelFraction(double numerator, double denominator)
        {
            for (var i = 1; i < numerator; i++)
            {
                if (numerator % i == 0 && denominator % i == 0 )
                {
                       System.Console.WriteLine($"{(numerator / i )} / {denominator / i}"); 
                }
            }
        }

    }
}
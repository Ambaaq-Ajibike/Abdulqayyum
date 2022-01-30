using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            double opp = 3;
            double adj = 4;
            double oppsq = Math.Pow(opp, 2);
            double adjsq = Math.Pow(adj, 2);
            double add = oppsq + adjsq;
            double hyp = Math.Sqrt(add);
            System.Console.WriteLine(hyp);
        
        }
    }
}
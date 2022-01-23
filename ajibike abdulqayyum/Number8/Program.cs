using System;

namespace Number8
{
    class Program
    {
        static void Main(string[] args)
        {
                 MobilePhone info1 = new MobilePhone();
                info1.Model = "nokia";
                info1.Manufacturer = "sd";
                info1.Price = 90;
                info1.Owner = "Yamee";
                Battery info2 = new Battery();
                info2.Model =  "Li-ion";
                info2.IdleTime = 4;
                info2.hourTalk = 87;
                Display info3 = new Display();                
                info3.colour = "red";
                info3.size = 20;
                Console.WriteLine($"{info1.Model} {info1.Manufacturer} {info1.Price} {info1.Owner}{info2.Model} {info2.IdleTime}");
                // var x = new MobilePhone("")
                // Console.WriteLine(x);


        }
    }
}

using System;

namespace Number8
{
    public class MobilePhone : logs
    {
        public string Model;
        public string Manufacturer;
        public int Price;
        public string Owner;
        private static string nokiaN95;
        private string length{get; set;};
        public static void SetnokiaN95(string NokiaN95)
        {
            nokiaN95 = NokiaN95;
        }
         public string AddCall (logs obj)
        {
            return AddCall(obj);
        }
        public string DeleteCall (logs obj)
        {
            return DeleteCall(obj);
        }
        public static string GetnokiaN95()
        {
            return nokiaN95;
        }
        public MobilePhone(string model, string manufacturer, int price, string owner)
        {
            this.Model = model;
            this.Manufacturer
            this.Owner = owner;
        } 
        
    public override string ToString()
    {
        return $" The phone is {Model} manufactured by {Manufacturer} and the price is {Price} it is now owned by {(Owner)}";
    } 
    public void PrintInfo()
    {
        string[] arr = {Model, Manufacturer, Price.ToString(), length};
        GetnokiaN95();
    }
    }
     public enum BatteryType
    {
        LiIon,
        NIMH,
        NICd,
    }
    public class Battery
    {
        public string Model;
        public int IdleTime;
        public int HourTalk;
        public BatteryType BatType;
        private string InBuilt{get; set;};
        public Battery(string model, int idleTime, int hourTalk, BatteryType batType)
        {
            this.Model = model;
            this.IdleTime = IdleTime;
            this.HourTalk = hourTalk;
            this.BatType = batType;
        }
    }
    public class Display
    {
        public string Colour;
        public int Size;
        private string Apps{get; set;};
        public Display(string colour, int size)
        {
            this.Colour = colour;
            this.Size = size;
        }
    }
   
}
using System;
namespace Number12
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> Mystk = new Stack<int>();
            Mystk.MyPush(2);
            Mystk.MyPush(4);
            Mystk.MyPush(3);
            Mystk.MyPush(8);
            while (true)
            {
                try
                {
                    System.Console.WriteLine("To Push number press 1");
                    System.Console.WriteLine("To Pop number press 2");
                    System.Console.WriteLine("To Peek number press 3");
                    System.Console.WriteLine("To Clear number press 4");
                    System.Console.WriteLine("To Count number press 5");
                    System.Console.WriteLine("To stop press 6");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        System.Console.WriteLine("Enter the number you want to Push ");
                        int num =int.Parse(Console.ReadLine());                    
                        Mystk.Push(num);
                    }
                    else if (choice == 2)
                    {                        
                        Mystk.Pop();
                    }
                    else if (choice == 3)
                    {
                        Mystk.Peek(num);
                    }
                    else if (choice == 4)
                    {
                        Mystk.Clear();
                    }
                    
                    else if (choice == 5)
                    {
                        Mystk.Count();
                    }                                    
                    else
                    {
                        break;
                    }
                } 
                catch()               
            }
        }
    }
}
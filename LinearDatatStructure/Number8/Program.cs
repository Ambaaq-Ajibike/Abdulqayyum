using System;
namespace Number8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = {2, 2, 3, 3, 2, 3, 4, 3, 3};
            int countNum = nums.Length / 2;
            int numCount=0;
            int holder = 0;
            for (int i = 0; i <nums.Length; i++)
            {
                holder = nums[i];
                numCount = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        holder = nums[j];
                        numCount++;
                    }
                }
            }
            if (numCount >= countNum + 1)
            {
                Console.WriteLine(holder);
            }
            else
            {
                System.Console.WriteLine("The majorant is not found");
            }
        }
    }
}

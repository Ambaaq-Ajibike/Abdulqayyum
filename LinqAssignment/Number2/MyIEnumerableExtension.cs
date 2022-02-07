using System;
namespace Number2
{
    public static class MyIEnumerableExtension
    {
        public static int MySum(this IEnumerable<int> nums)
        {
            return nums.Sum();
        }
        public static int MyMax(this IEnumerable<int> nums)
        {
            return nums.Max();
        }
        public static int MyMin(this IEnumerable<int> nums)
        {
            return nums.Min();
        }

        public static double MyAverage(this IEnumerable<int> nums)
        {
            return nums.Average();
        }
    }
}
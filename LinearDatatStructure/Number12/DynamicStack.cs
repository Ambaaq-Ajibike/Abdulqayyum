using System;
namespace Number12
{
    public static class DynamicStack
    {
        public static void MyPush(this Stack<int> stk, int num)
        {
            stk.Push(num);
        }

         public static void MyPop(this Stack<int> stk, int num)
        {
            stk.Pop();
        }
         public static void MyPeek(this Stack<int> stk, int num)
        {
            stk.Peek();
        }

         public static void MyClear(this Stack<int> stk, int num)
        {
            stk.Clear();
        }
         public static void MyCount(this Stack<int> stk, int num)
        {
            stk.Count();
        }
    }
}
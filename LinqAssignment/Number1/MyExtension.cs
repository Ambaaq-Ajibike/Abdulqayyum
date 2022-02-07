using System;
namespace Number1
{
    public static class MyExtension
    {
        //public string str;
        public static string RetrurnSubString(this string str, int index, int length)
        {
            return str.Substring(index, length);
        }
    }
}
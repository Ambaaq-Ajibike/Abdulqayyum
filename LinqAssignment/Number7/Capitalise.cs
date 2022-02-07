using System;
using System.Globalization;
namespace Number7
{
    public static class Capitalise
    {
        public static string capitaliseword(this string str)
        {
            return new CultureInfo("en-US", false).TextInfo.ToTitleCase(str);
        }
    }
}
using System;
namespace CreatingAndUsingObjects
{
    public class Sequence
    {
        public static int currentvalue = 0;
        public Sequence()
        {

        }
        public static int NextValue()
        {
            Sequence.currentvalue++;
            return Sequence.currentvalue;
        }
    }
}
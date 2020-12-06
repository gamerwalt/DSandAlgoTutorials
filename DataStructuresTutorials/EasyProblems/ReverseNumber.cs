using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.EasyProblems
{
    public class ReverseNumber
    {
        public static long Reverse(int x)
        {
            long result = 0;
            long xRemaining = Math.Abs(x);
            while (xRemaining != 0)
            {
                result = result * 10 + xRemaining % 10;
                xRemaining /= 10;
            }

            return x < 0 ? -result : result;
        }
    }
}

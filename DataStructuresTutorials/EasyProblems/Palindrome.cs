using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.EasyProblems
{
    public class Palindrome
    {
        public static bool isPalindromeNumber(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int numDigits = (int)(Math.Floor(Math.Log10(x))) + 1;
            int msdMask = (int)Math.Pow(10, numDigits - 1);

            return true;
        }
    }
}

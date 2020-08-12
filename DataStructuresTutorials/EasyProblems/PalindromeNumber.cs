using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.EasyProblems
{
    public class PalindromeNumber
    {
        public bool isPalindrome(int x)
        {
            var originalNumber = x;
            if (x < 0) return false;

            long reversed = 0;
            while(x > 0)
            {
                var remainder = x % 10;
                x /= 10;

                reversed = (reversed * 10) + remainder;
            }

            if (reversed > int.MaxValue)
            {
                return false;
            }

            return reversed == originalNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials
{
    public class Factorial
    {
        public static int GetFactorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }

            return number * GetFactorial(number - 1);
        }
    }
}

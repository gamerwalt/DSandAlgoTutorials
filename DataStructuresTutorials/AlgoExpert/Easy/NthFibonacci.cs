using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.AlgoExpert.Easy
{
    public class NthFibonacci
    {
        public static int GetNthFib(int n)
        {
            if(n == 2)
            {
                return 1;
            }
            else if(n == 1)
            {
                return 0;
            }
            else
            {
                return GetNthFib(n - 1) + GetNthFib(n - 2);
            }
        }
    }
}

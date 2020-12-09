using DataStructuresTutorials.AlgoExpert;
using DataStructuresTutorials.AlgoExpert.Easy;
using DataStructuresTutorials.AVLTreesTutorials;
using DataStructuresTutorials.BinaryTreesTutorials;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DataStructuresTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            Action<int> action = new Action<int>(WriteToString);

            Array.ForEach(numbers, action);
        }

        private static void WriteToString(int r)
        {
            Console.WriteLine($"{r}");
        }
    }
}

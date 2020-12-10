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
            var array = new Arrays.Array(3);
            array.Insert(10);
            array.Insert(20);
            array.Insert(30);
            array.Insert(40);
            array.RemoveAt(4);
            array.Print();
            Console.WriteLine(array.IndexOf(100));
        }
    }
}

using DataStructuresTutorials.AlgoExpert;
using DataStructuresTutorials.AlgoExpert.Easy;
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
            var tree = new BinaryTree();
            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(9);
            tree.Insert(1);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(10);
            tree.TraversePreorder();
            Console.WriteLine("****************************************");
            tree.TraverseInOrder();
            Console.WriteLine("****************************************");
            tree.TraversePostOrder();
        }
    }
}

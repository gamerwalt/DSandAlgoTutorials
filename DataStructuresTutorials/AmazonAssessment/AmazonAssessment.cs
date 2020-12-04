using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.AmazonAssessment
{
    public class AmazonAssessment
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 5, 10, 35, 89 };

            Console.WriteLine(MinCostToConnectRopes.GetMinCostToConnectRopes(numbers));
        }
    }
}

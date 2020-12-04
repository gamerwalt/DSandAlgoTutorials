using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.AmazonAssessment
{
    public class MinCostToConnectRopes
    {
        public static int GetMinCostToConnectRopes(int[] ropes)
        {
            var result = 0;

            var mySet = new PriorityQueue(ropes.Length);

            for(int i = 0; i<ropes.Length; i++)
            {
                mySet.Enqueue(ropes[i]);
            }

            while(mySet.Count() > 1)
            {
                var number1 = mySet.remove();
                var number2 = mySet.remove();

                var added = (number1 + number2);

                result += added;
                mySet.Enqueue(added);
            }

            return result;
        }
    }
}

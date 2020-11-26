using System;

namespace DataStructuresTutorials.AlgoExpert.Easy
{
    public class TwoNumberSumClass
    {
		public static int[] TwoNumberSum(int[] array, int targetSum)
		{
			int[] results;
			Array.Sort(array);

			int leftIndex = 0;
			int rightIndex = array.Length -1;

			while(leftIndex <= rightIndex)
            {
				int summation = array[leftIndex] + array[rightIndex];
				if (summation > targetSum) 
				{
					rightIndex--;
				}
				else if(summation < targetSum)
                {
					leftIndex++;
                }
				else
                {
					results = new int[2];
					results[0] = array[leftIndex];
					results[1] = array[rightIndex];
					return results;
					break;
                }
            }

			return Array.Empty<int>();
		}
	}
}

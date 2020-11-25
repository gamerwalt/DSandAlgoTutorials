using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials.AlgoExpert.Easy
{
    public class ValidateArraySubsequence
    {
        public bool isValideSubsequence(List<int> array, List<int> sequence)
        {
            if(array.Count == 0 || sequence.Count == 0)
            {
                throw new Exception("Each array length needs to be greater than 0.");
            }

            List<int> positions = new List<int>();
            int currentIndexOfPositions = 0;
            int currentPositionOfFoundValue = 0;

            for(int needleIndex = 0; needleIndex < sequence.Count; needleIndex++)
            {
                int needleValue = sequence[needleIndex];
                bool foundValue = false;
                for(int parentIndex = currentPositionOfFoundValue; parentIndex < array.Count; parentIndex++)
                {
                    int parentValue = array[parentIndex];

                    if(needleValue == parentValue)
                    {
                        //we save the current position
                        currentPositionOfFoundValue = parentIndex;
                        positions.Add(currentPositionOfFoundValue);
                        currentIndexOfPositions++;

                        foundValue = true;

                        continue;
                    }
                }

                if(positions.Count >= sequence.Count)
                {
                    break;
                }

                if(foundValue == false)
                {
                    return false;
                }
            }

            for(int i = 0; i<positions.Count; i++)
            {
                if(i < positions.Count - 1)
                {
                    if(positions[i+1] <= positions[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

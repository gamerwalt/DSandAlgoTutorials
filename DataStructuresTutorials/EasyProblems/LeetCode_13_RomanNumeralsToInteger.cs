using System.Collections.Generic;
 
namespace DataStructuresTutorials.EasyProblems
{
    public class LeetCode_13_RomanNumeralsToInteger
    {


        public LeetCode_13_RomanNumeralsToInteger()
        {

        }

        public int Convert(string romanNumerals)
        {
            Dictionary<char, int> Mappings;

            Mappings = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            var runningTotal = 0;
            //we need to look at 2 pointers at a time while going through the string
            //if the number on the left is bigger, we add it to a running total
            //if the number on the right is bigger, we find the difference between the 2 numbers
            for (int i = 0; i < romanNumerals.Length; i++)
            {
                var firstPointer = romanNumerals[i];
                var secondPointer = default(char);
                if (i + 1 < romanNumerals.Length)
                {
                    secondPointer = romanNumerals[i + 1];
                }

                var firstPointerToInt = Mappings.GetValueOrDefault(firstPointer);
                var secondPointerToInt = 0;
                if (secondPointer != null)
                {
                    secondPointerToInt = Mappings.GetValueOrDefault(secondPointer);
                }

                if (firstPointerToInt >= secondPointerToInt)
                {
                    runningTotal += firstPointerToInt;
                }
                else
                {
                    var difference = secondPointerToInt - firstPointerToInt;
                    if (romanNumerals.Length == 2)
                    {
                        return difference;
                    }

                    runningTotal += difference;
                    i++;
                }
            }

            return runningTotal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresTutorials
{
    public class StringProblems
    {
        public string ReverseString(string stringToReverse)
        {
            if(stringToReverse == null)
            {
                throw new ArgumentException("The string to reverse cannot be null.");
            }

            Stack<char> letters = new Stack<char>();
            for(int i = 0; i<stringToReverse.Length; i++)
            {
                letters.Push(stringToReverse[i]);
            }

            StringBuilder newString = new StringBuilder();
            while(letters.Count != 0)
            {
                newString.Append(letters.Pop());
            }

            return newString.ToString();
        }

        public bool isBalancedParenthesis(string stringToCheck)
        {
            if(stringToCheck == null)
            {
                throw new ArgumentException("The string to check cannot be null.");
            }

            Stack<char> opposites = new Stack<char>();
            for(int i = 0; i<stringToCheck.Length; i++)
            {
                var charToCheck = stringToCheck[i];
                switch(charToCheck)
                {
                    case '(':
                        opposites.Push(')');
                        break;
                    case '[':
                        opposites.Push(']');
                        break;
                    case '<':
                        opposites.Push('>');
                        break;
                    case ')':
                        if (opposites.Count == 0) return false;
                        if (!opposites.Pop().Equals(')'))
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (opposites.Count == 0) return false;
                        if (!opposites.Pop().Equals(']'))
                        {
                            return false;
                        }
                        break;
                    case '>':
                        if (opposites.Count == 0) return false;
                        if (!opposites.Pop().Equals('>'))
                        {
                            return false;
                        }
                        break;
                }
            }

            //if we get here and the stack is empty, then we have a valid balanced string
            return opposites.Count == 0;
        }
    }
}

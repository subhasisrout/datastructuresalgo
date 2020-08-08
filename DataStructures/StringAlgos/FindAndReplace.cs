using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructures.StringAlgos
{
    public class FindAndReplace
    {
        public string ReplacePattern(StringBuilder inputStr, string patternStr)
        {
            if (patternStr == null)
                return "Pattern missing";

            int i = 0;
            int j = 0;
            bool isPatternFound;
            int patternlen = patternStr.Length;
            StringBuilder outputStr = new StringBuilder();

            while (j < inputStr.Length)
            {
                isPatternFound = false;

                if (this.Compare(inputStr.ToString().Substring(j),patternStr))
                {
                    j = j + patternlen;
                    isPatternFound = true;
                }

                if (isPatternFound)
                    inputStr[i++] = 'X'; //This kind of operation CANNOT be done with string because of immutability

                if (j < inputStr.Length) //inputStr is completely overwritten using 'i' index i.e. inputStr becomes output.
                    inputStr[i++] = inputStr[j++];
            }

            return inputStr.ToString().Substring(0, i); //Terminate the string at 'i'
        }
        //search for "eks" within substring geeksforgeeks forgeeks orgeeks rgeeks geeks
        private bool Compare(string substring, string patternStr)
        {
            for (int k = 0; k < patternStr.Length; k++)
            {
                if (k >= substring.Length)
                    return false;
                if (substring[k] != patternStr[k])
                    return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class Isogram
    {


        public static bool IsIsogram(string inputString)
        {
            if (inputString.Length < 2)
            {
                return true;
            }
            string workingString = new string(inputString);
            workingString = inputString.ToLower();
            char[] workingArray = workingString.ToCharArray();
            for (int i = 0; i < workingString.Length-1; i++)
            {
                if (workingString.Substring(i + 1).Contains(workingArray[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

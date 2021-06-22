using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class ReverseParentheses
    {
        public static string reverseInParentheses(string inputString)
        {
            string outString = inputString;
            int firstCloseParen = inputString.IndexOf(')');
            if (firstCloseParen > 0)
            {
                int lastOpenParen = inputString.Substring(0, firstCloseParen).LastIndexOf('(');
                int containedLength = firstCloseParen - lastOpenParen - 1;
                if (containedLength > 1)
                {
                    string containedSubstring = inputString.Substring(lastOpenParen + 1, containedLength);
                    char[] containedSubstringCharArray = containedSubstring.ToCharArray();
                    containedSubstring = new string(containedSubstringCharArray.Reverse().ToArray());
                    outString = inputString.Substring(0, lastOpenParen + 1) + "" + containedSubstring + "" + inputString.Substring(firstCloseParen);
                }
                outString = outString.Remove(lastOpenParen, 1);
                outString = outString.Remove(firstCloseParen - 1, 1);
            }
            else
            {
                return inputString;
            }

            return reverseInParentheses(outString);
        }
    }
}

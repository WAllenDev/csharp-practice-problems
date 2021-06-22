using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class ToolsLibrary
    {

        public static bool isIPV4Address(string testAddress)
        {
            //divide into 4 integers seperate by 3 '.'s
            //If there are not 3 '.'s or separating the string by them does not return 4 integers, return false
            //If any of the 4 ints are not [0,255], return false

            bool isAddress = true;
            string[] subS = testAddress.Split('.');

            foreach (string item in subS) {
                Console.WriteLine(item);
            }

            if (subS.Length == 4 )
            {
                for (int i = 0; i < 4; i++)
                {
                    if (Int32.TryParse(subS[i], out int value))
                    {
                        if (value >= 0 && value <= 255)
                        {

                        }
                    } else
                    {
                        isAddress = false;
                        break;
                    }
                }
            } else
            {
                isAddress = false;
            }

            return isAddress;
        }

        public static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {

            int yourStrongArm()
            {
                return yourLeft > yourRight ? yourLeft : yourRight;
            }
            int yourWeakArm()
            {
                return yourLeft < yourRight ? yourLeft : yourRight;
            }
            int friendsStrongArm()
            {
                return friendsLeft > friendsRight ? friendsLeft : friendsRight;
            }
            int friendsWeakArm()
            {
                return friendsLeft < friendsRight ? friendsLeft : friendsRight;
            }

            return (yourStrongArm() == friendsStrongArm()) && (yourWeakArm() == friendsWeakArm());
        }

        public static bool palindromeRearranging(string inputString)
        {
            int charCount = 0;
            int howManyOdd = 0;
            int firstIndex = 0;
            int lastIndexOfChar = 0;
            char[] inputCharArray = inputString.ToCharArray();
            Array.Sort<char>(inputCharArray);
            while (firstIndex < inputCharArray.Length && howManyOdd < 2)
            {
                lastIndexOfChar = Array.LastIndexOf(inputCharArray, inputCharArray[firstIndex]);
                charCount = (lastIndexOfChar - firstIndex) + 1;
                firstIndex = lastIndexOfChar + 1;
                if (charCount % 2 != 0)
                {
                    howManyOdd++;
                }
            }
            return howManyOdd < 2;
        }

        public static int arrayChange(int[] inputArray)
        {
            int totalMoves = 0;
            int steps = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i + 1] <= inputArray[i]) 
                {
                    Console.WriteLine(intArrayToString(inputArray));
                    steps = inputArray[i] - inputArray[i + 1] + 1;
                    Console.WriteLine("Steps: " + steps);
                    inputArray[i + 1] += steps;
                    Console.WriteLine(intArrayToString(inputArray));
                }
                totalMoves += steps;
                steps = 0;
                Console.WriteLine("Moves: " + totalMoves);
   
            }
            return totalMoves;
        }

        public static string intArrayToString(int[] inputArray)
        {
            string outputString = "[";
            for(int i=0; i<inputArray.Length; i++)
            {
                outputString = outputString + " " + inputArray[i].ToString();
            }
            outputString = outputString + " ]";
            return outputString;
        }
    }
}

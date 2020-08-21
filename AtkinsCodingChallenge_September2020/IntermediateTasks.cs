using System;

namespace AtkinsCodingChallenge_September2020
{
    public static class IntermediateTasks
    {   
        /// <summary>
    /// Euclidean algorithm to find greatest common divisor 
    /// Find the modulus of the first number divided by the second
    /// Then first number becomes the second number
    /// the second value becomes the modulus result
    /// </summary>
    /// <param name="firstValue"></param>
    /// <param name="secondValue"></param>
    /// <returns></returns>
        public static int GreatestCommonDivisor(int firstValue, int secondValue)
        {
            int modulusResult;

            while(secondValue != 0)
            {
                modulusResult = firstValue % secondValue;

                firstValue = secondValue;

                secondValue = modulusResult;
            }

            return firstValue;
        }

        /// <summary>
        /// This method finds the smallest positive integer value that can be evenly divided by the two input parameters
        /// This method takes the larger param value, then loops through each integer value up to the value of the smaller param value
        /// It takes the MOD of BiggerNo * i % SmallerNo and when it's 0 returns BiggerNo * i
        /// eg for 8 and 6: 8 * 3 % 6 = 0, therefore LowestCommonMultiple = 8 * 3 = 24...
        /// if the loop does not generate a return value before it is excited the answer is BiggerNo * SmallerNo
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public static int LowestCommonMultiple(int firstValue, int secondValue)
        {
            int biggerNumber, smallerNumber;

            if (firstValue > secondValue)
            {
                biggerNumber = firstValue; smallerNumber = secondValue;
            }
            else
            {
                biggerNumber = secondValue; smallerNumber = firstValue;
            }
            for (int i = 1; i < smallerNumber; i++)
            {
                if (biggerNumber * i % smallerNumber == 0)
                    return i * biggerNumber;
            }
            return biggerNumber * smallerNumber;
        }

        /// <summary>
        /// Check for 0 and 1 these are not prime numbers 
        /// Check for 2 as it is a prime
        /// descard negative input values
        /// Take the square root of the input no then round it down
        /// Check for a Mod2 
        /// Finally iterate from 3 to the sqaure root of the input checking the MOD each time
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool CheckIfNumberIsPrime(int value)
        {
            if (value == 2)
                return true;

            else if (value <= 1 | value % 2 == 0)
                return false;

            int upperBoundValue = (int)Math.Floor(Math.Sqrt(value));

            for (int i = 3; i <= upperBoundValue; i = i + 2)
                if (value % i == 0)
                    return false;

            return true;
        }
        /// <summary>
        /// Recursion is used to solve this problem, if necessary the base class will call a call itself in a new "stackframe"
        /// the new stack frame will then possible call a new instance of itself and so on.. until a terminating condition is reached.
        /// At which point the return value is passed back through the stack frames until it returns to the "base class".
        /// typical we need to build a string / adding numbers etc as the method "unwinds back through the stack frames" once the terminal condition has been reached.
        /// if not we would pass value by ref..
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ConvertNumberToWords(int value, ref int incCount)
        {
            incCount += 1;

            if (value == 0)
                return "zero";

            if (value < 0)
                return "please enter a positive integer";

            if (value.ToString().Length > 5)
                return "This number is too big :(";

            string wordValue = "";

            if((value / 1000) > 0)
            {
                wordValue += ConvertNumberToWords((value / 1000), ref incCount) + " thousand ";
                value %= 1000;
            }

            if ((value / 100) > 0)
            {
                wordValue += ConvertNumberToWords((value / 100), ref incCount) + " hundred ";
                value %= 100;
            }

            //now we have to deal with values < 100, if values > 0. First we prefix "and" (0ne hundred "and") if the wordValue string is now not empty
            //Values have been assigned in the first portion of the algorithm which deals with numbers >= 100...

            if (wordValue != "" & value > 0)
                wordValue += "and ";

            string[] tenOrLessStrings = new[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
            string[] teensStrings = new[] { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensStrings = new[] { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (value <= 10 & value > 0)
                wordValue += tenOrLessStrings[value];

            else if(value > 10 & value < 20)
                wordValue += teensStrings[value];

            else
            {
                wordValue += tensStrings[value / 10];
                if((value % 10 > 0))
                {
                    //checking for a modulus ie. if the value is 21 - modulus is 1 to "Twenty" - "one"
                    //remeber arrays start at value 0 not one so the "blank" has been added to shift the indexing and make things more logical

                    wordValue += " " + tenOrLessStrings[value % 10];
                }

            }
            return wordValue;
        }
    }
}

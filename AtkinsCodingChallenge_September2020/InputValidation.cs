using System;
using System.Collections.Generic;

namespace AtkinsCodingChallenge_September2020
{
    public static class InputValidation
    {
        public static string InputAlgorithmIndexCheck(Dictionary<string, string> algorithms)
        {
            string inputValue;
            bool indexMatch = false; 

            do
            {
                Console.WriteLine("Please enter the index number of the desired alogrithm");
                inputValue = Console.ReadLine();

                if (algorithms.ContainsKey(inputValue))
                    indexMatch = true;
            }
            while (indexMatch == false);

            return inputValue;
        }

        public static double InputValueCheck() 
        {
            bool isNumeric; 
            string inputValue;

            do
            {
                Console.WriteLine("Please Enter a numeric value");
                inputValue = Console.ReadLine();
                isNumeric = inputValue.IsNumeric();
            }
            while (isNumeric == false);

            return inputValue.ParseStringToDouble();
        }

        //Extention methods - tidy up the logic a bit 
        public static bool DoubleIsAnInteger(this double input) => input % 1 == 0;
        public static bool IsNumeric(this string input) => double.TryParse(input, out double number);
        public static double ParseStringToDouble(this string input)
        {
            double.TryParse(input, out double number);
            return number;
        }
    }
}

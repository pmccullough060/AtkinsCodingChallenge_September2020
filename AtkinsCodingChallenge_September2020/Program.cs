using System;
using System.Collections.Generic;

namespace AtkinsCodingChallenge_September2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //add a loop around the whole thing... when finished.. maybe 

            #region Pre-amble

            Console.WriteLine("++++Coding Challenge_Spetember2020++++ \n");
            Console.WriteLine("Please select an alogrithm, by entering its corresponding index \n");
            Console.WriteLine("+++Beginner+++");

            #endregion

            Dictionary<string, string> algorithms = BuildAlgorithmDictionary();


            foreach (KeyValuePair<string, string> algorithm in algorithms)
                Console.WriteLine("- " + algorithm.Key + " " + algorithm.Value);

            string algorithmIndex = InputValidation.InputAlgorithmIndexCheck(algorithms);

            int incCount = 0;

            switch (algorithmIndex)
            {
                case "1":
                    double case1InputValue = InputValidation.InputValueCheck();
                    Console.WriteLine(BeginnerTasks.IsEven(case1InputValue));
                    break;

                case "2":
                    double case2InputValue = InputValidation.InputValueCheck();
                    Console.WriteLine(BeginnerTasks.RoundToNearestFive(case2InputValue));
                    break;

                case "3":
                    double case3InputValue = InputValidation.InputValueCheck();
                    Console.WriteLine(BeginnerTasks.Factorial((int)case3InputValue));
                    break;

                case "4":
                    double case4FirstInputValue = InputValidation.InputValueCheck();
                    double case4SecondInputValue = InputValidation.InputValueCheck();
                    Console.WriteLine(IntermediateTasks.GreatestCommonDivisor((int)case4FirstInputValue, (int)case4SecondInputValue));
                    break;

                case "5":
                    double case5FirstInputValue = InputValidation.InputValueCheck();
                    double case5SecondInputValue = InputValidation.InputValueCheck();
                    Console.WriteLine(IntermediateTasks.LowestCommonMultiple((int)case5FirstInputValue, (int)case5SecondInputValue));
                    break;

                case "6":
                    double case6InputValue = InputValidation.InputValueCheck();
                    Console.WriteLine(IntermediateTasks.CheckIfNumberIsPrime((int)case6InputValue));
                    break;

                case "7":
                     //incrementCounter
                    double case7InputValue = InputValidation.InputValueCheck();
                    Console.WriteLine(IntermediateTasks.ConvertNumberToWords((int)case7InputValue, ref incCount));
                    Console.WriteLine($"{ incCount } recursions to complete");
                    break;

                case "8":
                    double case8InputValue = InputValidation.InputValueCheck();
                    Console.WriteLine(AdvancedTasks.PrimeFactorDecomposition((int)case8InputValue));
                    break;
            }

            Console.ReadLine();

        }
        public static Dictionary<string , string> BuildAlgorithmDictionary()
        {
            Dictionary<string, string> algorithms = new Dictionary<string, string>();

            algorithms.Add("1", "Check if value is even");
            algorithms.Add("2", "Round to the nearest 5");
            algorithms.Add("3", "Calculate factorial");
            algorithms.Add("4", "Greatest common divisor of two numbers");
            algorithms.Add("5", "Lowest common multiple of two numbers");
            algorithms.Add("6", "Check if number is prime");
            algorithms.Add("7", "Convert number to words");
            algorithms.Add("8", "Calculate prime decomposition factor");

            return algorithms;
        }

    }
}

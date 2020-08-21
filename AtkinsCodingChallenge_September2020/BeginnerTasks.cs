using System;

namespace AtkinsCodingChallenge_September2020
{
    public static class BeginnerTasks
    {
        public static bool IsEven(double input) => input % 2 == 0;

        public static int RoundToNearestFive(double input) => (int)Math.Round(input / 5) * 5;

        #region tempNotes
        //stack overflow possible w/recursion??
        #endregion

        public static long Factorial(long input)
        {
            if (input <= 1)
                return 1;

            else
                return input * Factorial(input - 1);
        }
    }
}

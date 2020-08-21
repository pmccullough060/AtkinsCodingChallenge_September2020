using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtkinsCodingChallenge_September2020
{
    public static class AdvancedTasks
    {
        public static string PrimeFactorDecomposition(int value)
        {
            List<int> result = new List<int>();

            while(value % 2 == 0)
            {
                //getting all the twos out first
                result.Add(2);
                value = value / 2;
            }

            //starting prime
            int primeDivisor = 3;

            while(primeDivisor * primeDivisor <= value)
            {
                if(value % primeDivisor == 0)
                {
                    result.Add(primeDivisor);
                    value = value / primeDivisor;
                }

                else
                {
                    //increment to the next prime number
                    bool isPrime = false;
                    do
                    {
                        primeDivisor += 2;
                        isPrime = IntermediateTasks.CheckIfNumberIsPrime(primeDivisor);
                    }
                    while (isPrime == false);
                }
            }

            if (value > 1)
                result.Add(value);

            string outputString = "";

            foreach(int primeFactor in result)
                outputString += primeFactor.ToString() + " x ";
            
            return outputString;
        }
    }
}

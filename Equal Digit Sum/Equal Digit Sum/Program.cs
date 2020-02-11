using System;
using System.Collections.Generic;

namespace Equal_Digit_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 42, 33, 60 };
            var result = HighestPair(myArray);
            Console.WriteLine(result);
        }
        public static int InternalSum(int ToSplit)
        {
            int sum = 0;
            while (ToSplit > 0)
            {
                var currentDigit = ToSplit % 10;
                sum = sum + currentDigit;
                ToSplit = (ToSplit - currentDigit) / 10;
            }
            return sum;
        }

        public static int HighestPair(int[] ArrayToPair)
        {
            int highestResult = -1;

            Dictionary<int, int> totalsValues = new Dictionary<int, int> { };

            foreach (int currentValue in ArrayToPair)
            {
                int internalSum = InternalSum(currentValue);
                if (totalsValues.ContainsKey(internalSum))
                {
                    int valueForSum = totalsValues[internalSum];
                    highestResult = valueForSum + currentValue;
                    if (currentValue > valueForSum)
                    {
                        totalsValues[internalSum] = currentValue;
                    }
                }
                else
                {
                    totalsValues.Add(internalSum, currentValue);
                }
            }
            return highestResult;
        }
    }
}

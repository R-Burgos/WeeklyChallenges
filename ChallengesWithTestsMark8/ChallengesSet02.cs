using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        { 
           return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
           return (number % 2 == 0); 
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            { 
                return 0;
            }
            int index = numbers.Count();
            if (index > 0)
            {
                var x = numbers.Min();
                var y = numbers.Max();
                return x + y;
            }
            else
            {
                return 0;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length <= str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return (numbers != null) ? numbers.Sum() : 0 ;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            for(int num = 0; num < numbers.Length; num++)
            {
                if (numbers[num] % 2 == 0)
                { 
                    sum += numbers[num];
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            { 
                return false;
            }
            var size = numbers.Count;
            var average = numbers.Average();
            var ans = average * size;
            return (ans % 2 != 0) ? true : false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number < 1) ? 0 : number / 2;
        }
    }
}

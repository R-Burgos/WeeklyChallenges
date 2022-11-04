using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
           return (number % 2 == 0) ? true : false; 
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
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
            int sum = 0;
            var size = numbers.Count;
            var average = numbers.Average();
            var ans = average * size;

            return (ans % 2 != 0) ? true : false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool b = vals.Contains(false);
            return b;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            { return false; }
            return (numbers.Sum() % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            int xUp = 0;
            int yLow = 0;
            int zNum = 0;
            foreach (char c in password)
            {
                if (Char.IsUpper(c) == true)
                { 
                    xUp++;
                }
                if (Char.IsLower(c) == true)
                { 
                    yLow++;
                }
                if (Char.IsNumber(c) == true)
                {
                    zNum++;
                }

            }
            return (xUp > 0 && yLow > 0 && zNum > 0);
        }

        public char GetFirstLetterOfString(string val)
        {
            var x = val.Substring(0, 1);
            return Convert.ToChar(x);
        }

        public char GetLastLetterOfString(string val)
        {
            var x = val.Substring(val.Length -1 , 1);
            return Convert.ToChar(x);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var x = nums.Last();
            var y = nums.First();
            return x - y;
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            words.Select(x => x.ToUpper()).ToArray();
        }
    }
}

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
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //if(numbers == null)
            //{ return false; }
            //return (numbers.Sum() % 2 != 0);

            return (numbers == null) ? false : (numbers.Where(x => x % 2 != 0).Sum() % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //int xUp = 0;
            //int yLow = 0;
            //int zNum = 0;
            //foreach (char c in password)
            //{
            //    if (Char.IsUpper(c) == true)
            //    { 
            //        xUp++;
            //    }
            //    if (Char.IsLower(c) == true)
            //    { 
            //        yLow++;
            //    }
            //    if (Char.IsNumber(c) == true)
            //    {
            //        zNum++;
            //    }

            //}
            //return (xUp > 0 && yLow > 0 && zNum > 0);

            return (password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsNumber));
        }

        public char GetFirstLetterOfString(string val)
        {
            //var x = val.Substring(0, 1);
            //return Convert.ToChar(x);

            return val[0]; // return val.First(); using LINQ
        }

        public char GetLastLetterOfString(string val)
        {
            //var x = val.Substring(val.Length -1 , 1);
            //return Convert.ToChar(x);

            return val[val.Length - 1]; // return val.Last(); using LINQ
            // val[^1];
            //val[^1] also returns the last element. The carrot is like indexing backwards

        }

        public decimal Divide(decimal dividend, decimal divisor) => (divisor == 0) ? 0 : dividend / divisor;

        public int LastMinusFirst(int[] nums) => nums.Last() - nums.First();
       // {
            //var x = nums.Last();
            //var y = nums.First();
            //return x - y;

            //return nums[nums.Length - 1] - nums[0];
            // return nums[^1] - nums[0];
       // }

        public int[] GetOddsBelow100()
        {
            //List<int> odds = new List<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        odds.Add(i);
            //    }
            //}
            //return odds.ToArray();

            return Enumerable.Range(0, 100).Where(x => x % 2 != 0).ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();  
            }
        }

    }
}

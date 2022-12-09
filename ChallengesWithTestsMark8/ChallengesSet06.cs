using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //bool containsWord = false;

            //if (string.Equals(words, null) || words.Contains(null))
            //{
            //    return false;
            //}

            //if (ignoreCase)
            //{
            //    word = word.ToLower();
            //    List<string> lc = words.Select(x => x.ToLower()).ToList();
            //    containsWord = lc.Contains(word);
            //}

            //if (!ignoreCase)
            //{ 
            //    containsWord = words.Contains(word);
            //}

            //return containsWord;

            return (ignoreCase) ? words?.Select(x => x?.ToLower()).Contains(word) ?? false : words?.Contains(word) ?? false;
        }

        public bool IsPrimeNumber(int num)
        {
            //var isPrime = false;

            //if (num >= 0)
            //{
            //    if (num % 2 != 0 && num % 3 != 0)
            //    { 
            //        isPrime= true;
            //    }
            //}

            //if (num == 2 || num == 3)
            //{ 
            //    isPrime= true;
            //}

            //if (num == 1)
            //{ 
            //    isPrime= false;
            //}

            //return isPrime;

            return (num <= 1) ? false : Enumerable.Range(2, (int)Math.Sqrt(num)-1).All(divisor => num % divisor != 0);
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //int index = -1;
            //bool uIndex;

            //for (var i = 0; i < str.Length; i++)
            //{
            //    uIndex = true;

            //    for (var j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j] && i != j)
            //        { 
            //            uIndex= false;
            //        }
            //    }

            //    if (uIndex)
            //    {
            //        index = i;
            //    }
            //}
            //return index;

            return str.IndexOf(str.Distinct().Reverse().Where(x => str.Where(y => y.Equals(x)).Count() == 1).FirstOrDefault());

            // return str.Length == 0 || str.Length > 1 && str.Distinct().Count() <= 1 ? -1 : str.Select((x, index) => new int[] { str.Count(j => j == x), index }).Where(a => a[0] == 1).Max(x => x[1]);

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                int currrentCount = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currrentCount++;
                }

                if (currrentCount > count)
                {
                    count = currrentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            //List<double> nthElement = new List<double>();

            //if (elements == null || n <= 0 || n > elements.Count)
            //{ 
            //    return nthElement.ToArray();
            //}

            //for (var i = n - 1; i < elements.Count; i += n)
            //{
            //    nthElement.Add(elements[i]);
            //}
            //return nthElement.ToArray();

            return elements == null || n <= 0 ? new double[0] : elements.Where((item, index) => (index + 1) % n == 0).ToArray();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c) => char.IsLetter(c);

        public bool CountOfElementsIsEven(string[] vals) => (vals.Length % 2 == 0);

        public bool IsNumberEven(int number) => (number % 2 == 0);

        public bool IsNumberOdd(int num) => (num % 2 != 0);

        public double SumOfMinAndMax(IEnumerable<double> numbers) => (numbers?.Count() == 0) ? 0 : numbers?.Min() + numbers?.Max() ?? 0;
        // return numbers?.Any() ?? false ? numbers.Min() + numbers.Max() : new double { };

        public int GetLengthOfShortestString(string str1, string str2) => (str1.Length <= str2.Length) ? str1.Length : str2.Length;

        public int Sum(int[] numbers) => (numbers != null) ? numbers.Sum() : 0;  // numbers?.Sum() ?? 0;

        public int SumEvens(int[] numbers) => (numbers?.Count() == 0 || numbers == null) ? 0 : numbers.Where(x => (x % 2 == 0)).Sum(); // numbers?.Where(x => x % 2 == 0).Sum() ?? 0;

        public bool IsSumOdd(List<int> numbers) => (numbers == null || numbers.Count == 0) ? false : (numbers.Sum() % 2 != 0);

        public long CountOfPositiveOddsBelowNumber(long number) => (number < 1) ? 0 : number / 2;
    }
}

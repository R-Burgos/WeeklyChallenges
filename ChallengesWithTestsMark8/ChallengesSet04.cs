using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //var even = 0;
            //var odd = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        even += numbers[i];
            //    }
            //    else
            //    { 
            //        odd += numbers[i];
            //    }
            //}
            //return even - odd;

            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            //return list.Min();

            return new string[] { str1, str2, str3, str4 }.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //int[] numbers = new int[] { number1, number2, number3, number4 };
            //Array.Sort(numbers);
            //return numbers[0];

            return new int[] { number1, number2, number3, number4 }.Min(x => x);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            //var x = 0.0;
            //return double.TryParse(input, out x);
            return double.TryParse(input, out var number);

        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //var n = 0;
            //var x = 0;
            //for (int i = 0; i < objs.Length; i++)
            //{
            //    if (objs[i] == null)
            //    {
            //        n++;
            //    }
            //    else
            //    { 
            //        x++;
            //    }
            //}
            //return n > x;

            return Convert.ToDouble(objs.Where(x => x == null).Count()) / Convert.ToDouble(objs.Length) > 0.5;

        }

        public double AverageEvens(int[] numbers)
        {
            //if (numbers == null)
            //{
            //    return 0;
            //}
            //int[] evens = numbers.Where(x => x % 2 == 0).ToArray();
            //double avg = 0.0;
            //double sum = 0.0;
            //double count = evens.Length;
            //for (int i = 0; i < evens.Length; i++)
            //{
            //    sum += evens[i];
            //}

            //if (evens.Length <= 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    avg = sum / count;
            //    return avg;
            //}



            //return (numbers == null || numbers.Length == 0) ? 0 : (numbers.Where(x => x % 2 == 0).Count() == 0) ? 0 : numbers.Where(x => x % 2 == 0).Average();

            return (numbers == null || numbers.Length == 0) ? 0 : numbers.Where(x => x % 2 == 0).DefaultIfEmpty().Average();
        }

        public int Factorial(int number)
        {
            //var fact = 1;
            //if (number < 0)
            //{ 
            //    throw new ArgumentOutOfRangeException();
            //}
            //for (int i = number; i > 0; i--)
            //{ 
            //    fact *= i;
            //}

            //return fact;

            return (number == 0) ? 1 : Enumerable.Range(1, number).Aggregate((f, s) => f * s);
        }
    }
}

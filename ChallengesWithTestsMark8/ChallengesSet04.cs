using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;

            foreach (var num in numbers)
            {
                //Even
                if(num % 2 == 0 )
                {
                    sum += num;
                }

                //Odd
                if(num % 2 != 0)
                {
                    sum -= num;
                }             
            }

            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };

            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new int[] { number1, number2, number3, number4 };

            return list.Min();
           
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 > sideLength3 &&
               sideLength1 + sideLength3 > sideLength2 &&
               sideLength3 + sideLength2 > sideLength1) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double value);

        }
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(elements => elements == null).Count() > (objs.Count() / 2);
        }

        public double AverageEvens(int[] numbers)
        {

            double sum = 0;
            double count = 0;

            if(numbers == null)
            {
                return 0;
            }

            foreach(var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }

            if(count > 0)
            {
                return sum / count;
            }
            else
            {
                return 0;
            }

        }

        public int Factorial(int number)
        {
            var fact = 1;

            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            for ( int i = number; i > 0; i--)
            {
                fact *= i;
            }

            return fact;
        }
    }
}

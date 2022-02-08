using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = true;
            
            if (words == null || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true )
            {
                //Convert to lowercase , store in a new list
                List<string> lowerCase = words.Select(x => x.ToLower()).ToList();

                //Check new list for passed in word
                containsWord = lowerCase.Contains(word);
            }

            if (ignoreCase == false)
            {

                containsWord = words.Contains(word);
    
            }
        
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i += 2)
                if (num % i == 0)
                    return false;

            return true;

        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uIndex;

            for(int i = 0; i < str.Length; i++)
            {
                uIndex = true;

                for(int j =0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i !=j)
                    {
                        uIndex = false;
                    }
                }
                
                if(uIndex == true)
                {
                    index = i;
                }
            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;
                }

                if(currentCount > count)
                {
                    count = currentCount;
                }                     
            }

            return count;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();

            double[] nullCheck = new double[0];
            
            if (elements == null)
            {
                return nullCheck;
            }

            for(int i = 0; i < elements.Count; i++)
            {
                if(elements[i] % n == 0)
                {
                    result.Add(elements[i]);
                }

                if(n < 0 || n > elements.Count)
                {
                    result.Clear();
                }
            }

            double[] finalArray = result.ToArray();

            return finalArray;
        }
    }
}

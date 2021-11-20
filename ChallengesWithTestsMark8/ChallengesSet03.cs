using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool value = false;
            var check = Array.Exists(vals, x => x == value);
            
            if (check == true)
            {
                return true;
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            
            if (numbers == null || numbers.Sum () % 2 == 0 )
            {
                return false;
            }
            return true;

        }
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) &&
            password.Any(char.IsLower) &&
            password.Any(char.IsDigit))
            {
                return true;
            }

            return false;    
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }            
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length -1]  -  nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int>();

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
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
           
        }
      
    }
}

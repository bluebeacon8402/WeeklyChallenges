using System;
using System.Collections.Generic;
using System.Linq;

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
            if (numbers == null)
            {
                return false;
            }
  
            var obj = numbers.Where(n => n % 2 != 0).Sum();
            return obj % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) &&
            password.Any(char.IsLower) &&
            password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            var x = nums[0];
            var y = nums[nums.Length - 1];

            return y - x;
        }

        public int[] GetOddsBelow100()
        {
            int[] x = new int[50];
            int y = 0;

            for (int i = 1; i < 100; i +=2)
            {
                if (i == 1)
                {
                    x[y] = 1;
                }
                else
                {
                    x[y] = i;
                }
                y++;
            }
            return x;
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

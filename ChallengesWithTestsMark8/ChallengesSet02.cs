using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if(c == 'c')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var num = vals.Length;
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count()== 0)
            {
                return 0;
            }
            
            var answer1 = numbers.Min();
            var answer2 = numbers.Max();
            return answer1 + answer2;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var str3 = str1.Length;
            var str4 = str2.Length;
            
            if (str1.Length < str2.Length)
            {
                return str3;
            }
            else
            {
                return str4;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int evens = 0;
            
            foreach(int x in numbers)
            {
                if (x % 2 == 0)
                {
                    evens += x;
                }
            }

            return evens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            
            var x = numbers.Sum();

            if (x % 2 != 0)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;
            
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
                
            }

            return count;
        }
    }
}

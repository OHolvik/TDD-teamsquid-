using System;
using System.Collections.Generic;
using System.Linq;

namespace TDD_test
{
    public class stringUtil
    {

        public int strCount(string str)
        {
            return str.Length;
        }

        public string strType(string str)
        {
            if (str.All(char.IsNumber))
                return "number";
            if (str.All(char.IsLetter))
                return "word";
            return "none";
        }

        public int nextPalindrome(int num)
        {
            string numStr = num.ToString();
            char[] charArray = numStr.ToCharArray();
            Array.Reverse(charArray);
            numStr = string.Concat(numStr, new string(charArray));
            return int.Parse(numStr);
        }

        public int[] nextPrime(int num)
        {
            int candidate = num;
            List<int> primes = new List<int>();
            do
            {
                if (isPrime(++candidate))
                {
                    primes.Add(candidate);
                }
            } while (primes.Count < 3);

            return primes.ToArray();
        }

        public bool isPrime(int num)
        {
            if ((num & 1) == 0)
            {
                if (num == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            for (int i = 3; (i * i) <= num; i += 2)
            {
                if ((num % i) == 0)
                {
                    return false;
                }
            }
            return num != 1;

        }
    }
}

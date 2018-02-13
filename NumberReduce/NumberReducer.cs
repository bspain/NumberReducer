using System;
using System.Collections.Generic;

namespace NumberReduce
{
    public class NumberReducer
    {
        /// <summary>
        /// Takes an input string (of all digits) and removes n digits.  Returns the smallest possible
        /// value that can be made from remaining digits
        /// </summary>
        /// <param name="s">String of digits</param>
        /// <param name="n">Number of digits to remove</param>
        /// <returns>Smallest possible value comprised of remaining digits</returns>
        public static uint ReduceStringDigits(string s, int n)
        {
            // Convert to int[] and recurive analyze
            int[] digits = new int[s.Length];
            for(int x = 0; x < s.Length; x++)
            {
                digits[x] = int.Parse(s[x].ToString());
            }

            return ReduceStringDigits2_Recurse(digits, n);
        }

        private static uint ReduceStringDigits2_Recurse(int[] digits, int n)
        {
            if (n == 0)
            {
                // Walk digts backwards and assemble
                uint results = 0;
                uint multiplier = 1;
                for (int x = digits.Length - 1; x >= 0; x--)
                {
                    if (digits[x] != -1)
                    {
                        results = results + (uint)digits[x] * multiplier;
                        multiplier = multiplier * 10;
                    }
                }

                return results;
            }
            else
            {
                // Walk digits, consume, recurse
                int prev = digits[0];
                int prevIndex = 0;
                bool consumed = false;
                for (int x = 1; x < digits.Length; x++)
                {
                    if (digits[x] == -1)
                    {
                        continue;
                    }

                    if (digits[x] < prev)
                    {
                        // Consume previous
                        digits[prevIndex] = -1;
                        consumed = true;
                        break;
                    }

                    prev = digits[x];
                    prevIndex = x;
                }

                // If nothing consumed, then find the last digit and consume
                if (!consumed)
                {
                    for (int y = digits.Length - 1; y > 0; y--)
                    {
                        if (digits[y] != -1)
                        {
                            digits[y] = -1;
                            break;
                        }
                    }
                }

                n--;

                return ReduceStringDigits2_Recurse(digits, n);
            }
        }
    }
}

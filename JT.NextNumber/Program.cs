using System;
using System.Collections.Generic;
using System.Linq;


namespace JT.NextNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Next number using same digits as:");

                foreach (var num in args)
                {
                    if (long.TryParse(num, out long n))
                    {
                        long nextNum = NextNumber(n);
                        Console.WriteLine($" {n:10} -> {nextNum:10}");
                    }
                    else
                        Console.WriteLine($"  Not a number: {num}");
                }
            }
            else
            {
                Console.WriteLine($"Enter numbers to test on command line separated by spaces.\n   $ ./{System.AppDomain.CurrentDomain.FriendlyName} 123 456 987");
            }
        }

        public static long NextBiggerNumber(long n)
        {
            int i=0, j;
            var digits = n.ToString().Select(c=>int.Parse(c.ToString())).Reverse().ToList();

            for (i = 1; i < digits.Count; i++)
                if (digits[i-1] > digits[i])
                    break;

            if (i == digits.Count) return -1;

            for (j = i-1; j > 0; j--)
                if (digits[j-1] <= digits[i])
                    break;

            digits[i] ^= digits[j];
            digits[j] ^= digits[i];
            digits[i] ^= digits[j];

            var sdigits = digits.GetRange(0, i).OrderByDescending(d => d);
            digits.RemoveRange(0, i);
            digits.InsertRange(0, sdigits);

            var nextNum = digits.Reverse<int>().Aggregate(0L, (a, x) => a = a * 10 + x);
            return n == nextNum ? -1 : nextNum;
        }

        public static long NextNumber(long n)
        {
            var num = n.ToString();
            var digits = num.Reverse()
                .Select(c => int.Parse(c.ToString())).ToList();  // capture the digits in reverse order
            IEnumerable<int> sdigits = null;
            for (var i = 0; i < digits.Count() - 1; i++)             //      Compare each digit to the next
            {
                if (digits[i] > digits[i + 1])                      //      Find first pair that is out of order
                {
                    digits[i] ^= digits[i + 1];                     //      swap the digits ...
                    digits[i + 1] ^= digits[i];                     //      using old-school, memory-efficient, 
                    digits[i] ^= digits[i + 1];                     //      xor method from the assembler days.
                    sdigits = digits.GetRange(0, i + 1);
                    break;                                          //      only do this once.
                }
            }
            if (sdigits != null)
            {
                digits.RemoveRange(0, sdigits.Count());
                digits.InsertRange(0, sdigits.OrderByDescending(d => d));
            }
            var nextNum = digits.Reverse<int>().Aggregate(0L, (a, i) => a = a * 10 + i); // rebuild the number from the potentially rearranged digits
            return n == nextNum ? -1 : nextNum; // compare to original and return result.
        }
    }
}

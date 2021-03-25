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

        // To produce the next larger number from existing digits, 
        // swap the lowest magnitude adjacent digits that are not in descending order
        public static long NextNumber(long n)
        {
            var num = n.ToString();
            var digits = num.Reverse().ToList<char>();  // capture the digits in reverse order
            IEnumerable<char> sdigits = null;
            for (var i = 0; i < digits.Count() - 1; i++)             //      Compare each digit to the next
            {
                if (digits[i] > digits[i + 1])                      //      Find first pair that is out of order
                {
                    digits[i] ^= digits[i + 1];                     //      swap the digits ...
                    digits[i + 1] ^= digits[i];                     //      using old-school, memory-efficient, 
                    digits[i] ^= digits[i + 1];                     //      xor method from the assembler days.
                    sdigits = digits.GetRange(0, i+1).OrderByDescending(c => c);
                    break;                                          //      only do this once.
                }
            }
            if ((sdigits?.Count()??0) > 0)
            {
                digits.RemoveRange(0, sdigits.Count());
                digits.InsertRange(0, sdigits);
            }
            digits.AsEnumerable().Reverse();
            string nextNum = string.Join(string.Empty, digits.AsEnumerable().Reverse()); // rebuild the number from the potentially rearranged digits
            return num.Equals(nextNum, StringComparison.InvariantCultureIgnoreCase) ? -1 : long.Parse(nextNum); // compare to original and return result.
        }
    }
}

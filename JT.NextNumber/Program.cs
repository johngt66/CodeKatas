using System;
using System.Linq;

namespace JT.NextNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if(args.Length == 2)
            {
                string nextNum = NextNumber(args[1]);
                Console.WriteLine($"Next number using same digits as {args[1]} is {nextNum}");
            }
        }

        // To produce the next larger number from existing digits, 
        // swap the lowest magnitude adjacent digits that are not in descending order
        public static string NextNumber(string num)
        {
            if(!int.TryParse(num, out _))
                return "-1";

            char[] digits = num.ToCharArray().Reverse().ToArray();  // capture the digits in reverse order
            for (var i = 0; i < digits.Length - 1; i++)             //      Compare each digit to the next
            {
                if (digits[i] > digits[i + 1])                      //      Find first pair that is out of order
                {   
                    digits[i] ^= digits[i + 1];                     //      swap the digits ...
                    digits[i + 1] ^= digits[i];                     //      using old-school, memory-efficient, 
                    digits[i] ^= digits[i + 1];                     //      xor method from the assembler days.
                    break;                                          //      only do this once.
                }
            }
            string nextNum = string.Join(string.Empty, digits.Reverse()); //    rebuild the number from the potentially rearranged digits
            return num.Equals(nextNum,StringComparison.InvariantCultureIgnoreCase) ? "-1" : nextNum; // compare to original and return result.
        }
    }
}

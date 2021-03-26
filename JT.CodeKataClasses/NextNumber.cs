using System;

namespace JT.CodeKataClasses
{
    public class NextNumber
    {
        public static long NextBiggerNumber(long n)
        {
            int i = 0, j;
            var digits = n.ToString().Select(c => int.Parse(c.ToString())).Reverse().ToList();

            for (i = 1; i < digits.Count; i++)
                if (digits[i - 1] > digits[i])
                    break;

            if (i == digits.Count) return -1;

            for (j = i - 1; j > 0; j--)
                if (digits[j - 1] <= digits[i])
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
    }
}

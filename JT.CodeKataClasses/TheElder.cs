using System;
using System.Collections.Generic;
using System.Linq;

namespace JT.CodeKataClasses
{
    public class TheElder
    {
        public static long ElderAge(long n, long m, long k, long newp)
        {
            long gift = 0L;

            for (var x = 0L; x < n; x++)
                for (var y = 0L; y < m; y++)
                {
                    long s = (x ^ y);
                    // TODO: inspect the bits
                    gift += s > k ? s-k : 0L;
                    if (gift >= newp)
                        gift -= newp;
                }

            return gift;
        }
    }
}
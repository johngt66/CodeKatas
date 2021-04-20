using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfK
{
    public static int? chooseBestSum(int t, int k, List<int> ls)
    {
        if (ls.Count() < k) return null;
        if (k == 1) return ls.Max(m => m > t ? null : m as int?);

        int? best = null;
        for (int i = 0; i < ls.Count; i++)
        {
            if (chooseBestSum(t - ls[i], k - 1, ls.Skip(i + 1).ToList()) is int s)
            {
                s += ls[i];
                if (s <= t && s > (best ?? 0))
                    best = s;
            }
        }
        return best;
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace JT.CodeKataClasses
{
    public class CarMileage
    {
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            if (number < 98 || number >= 1000000000 || awesomePhrases == null)
                return 0;

            var rules = new List<Func<string, bool>>
            {
                n => n.Trim('0').Length == 1,
                n => n.All(c => c == n[0]),
                n => "1234567890".Contains(n),
                n => "9876543210".Contains(n),
                n => n.Take(n.Length/2).SequenceEqual(n.Reverse().Take(n.Length/2)),
                n => awesomePhrases.Select(s=>s.ToString()).Contains(n)
            };
            for (var i = 0; i < 3; i++)
                if ((number + i) > 99 && rules.Any(r => r((number + i).ToString())))
                    return i == 0 ? 2 : 1;

            return 0;
        }
    }
}
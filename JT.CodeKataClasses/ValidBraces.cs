using System;
using System.Linq;
using System.Collections.Generic;

namespace JT.CodeKataClasses
{
    public class ValidBraces
    {
        public static bool validBraces(String braces)
        {
            Dictionary<char, char> v = new Dictionary<char, char> { { '}', '{' }, { ')', '(' }, { ']', '[' } };
            string isLeft = "{([";
            Stack<char> s = new Stack<char>();

            foreach (char c in braces)
                if (isLeft.Contains(c))
                    s.Push(c);
                else if (s.Count == 0 || v[c] != s.Pop())
                    return false;

            return s.Count==0;
        }
    }
}

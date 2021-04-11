using System;
using System.Linq;
using System.Collections.Generic;
using JT.CodeKataClasses;

namespace JT.CliRunner
{
    class Program
    {
        public static void Main(string[] args)
        {
            var t = new temp();
            var myMsg = Guid.NewGuid().ToString();
            t.Run(myMsg);
        }
    }
}

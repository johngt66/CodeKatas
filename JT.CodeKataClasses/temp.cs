using System;

namespace JT.CodeKataClasses
{
    public class temp
    {
        public void Run(string message)
        {
            Action<string,object> log = (n,m) => Console.WriteLine($"{n}: {m}");

            var someText = "hello world";

            log(nameof(someText),someText);
            log(nameof(message),message);
        }
    }
}
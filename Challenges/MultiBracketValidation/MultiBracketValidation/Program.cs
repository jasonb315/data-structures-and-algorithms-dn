using System;
using System.Collections;
using System.Collections.Generic;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MultiBracketValidation("[{The {quick([{ }])brown} fox}]");
        }

    

        public static bool MultiBracketValidation(string input)
        {
            Queue bracketQueue = new Queue();

            var bracketPairs = new Dictionary<string, string>() { {"{", "}"}, {"[", "]"}, {"(", ")"} };

            foreach (char item in input)
            {
                if (bracketPairs.ContainsKey(item.ToString()))
                {
                    Console.WriteLine("Ding");
                }
            }
            return true;
        }
    }
}

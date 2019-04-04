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
            Stack bracketQueue = new Stack();

            var bracketPairs = new Dictionary<string, string>() { {"{", "}"}, {"[", "]"}, {"(", ")"} };

            foreach (char item in input)
            {
                string i = item.ToString();
                if (bracketPairs.ContainsKey(i))
                {
                    // stack { { [ ( ...
                    bracketQueue.Push(i);
                }
                else if (bracketPairs.ContainsValue(i))
                {
                    string peek = (string)bracketQueue.Peek();
                    if (bracketPairs[peek] == i)
                    {
                        bracketQueue.Pop();
                    }
                    else
                    {
                        Console.WriteLine("false");
                        return false;
                    }
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("true");
            return true;
        }
    }
}

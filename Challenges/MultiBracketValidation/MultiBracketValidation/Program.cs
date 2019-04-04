using System;
using System.Collections;
using System.Collections.Generic;

namespace MultiBracketValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //MultiBracketValidationMethod("[{The {quick([{ }])brown} fox}]");
            MultiBracketValidationMethod("]]]]]]]]]]]]]]");
        }

        /// <summary>
        ///     Reads a sting to verify bracket pair matching
        /// </summary>
        /// <param name="input">string input</param>
        /// <returns>bool</returns>
        public static bool MultiBracketValidationMethod(string input)
        {
            Stack bracketQueue = new Stack();
            var bracketPairs = new Dictionary<string, string>() { {"{", "}"}, {"[", "]"}, {"(", ")"} };
            int closeCount = 0;

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
                    if(bracketQueue.Count == 0)
                    {
                        return false;
                    }
                    closeCount++;
                    Console.WriteLine(closeCount);

                    if (bracketQueue.Count > 0)
                    {
                        string peek = (string)bracketQueue.Peek();
                        if (bracketPairs[peek] == i)
                        {
                            bracketQueue.Pop();
                            closeCount--;
                            Console.WriteLine(closeCount);
                        }
                        else
                        {
                            Console.WriteLine("false");
                            return false;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            if(bracketQueue.Count > 0)
            {
                return false;
            }
            else if(closeCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

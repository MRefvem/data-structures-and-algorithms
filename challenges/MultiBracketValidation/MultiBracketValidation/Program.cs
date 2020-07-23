using System;
using System.Collections.Generic;
using StacksAndQueues;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MultiBracketValidation("{}");
            MultiBracketValidation("{}(){}");
            MultiBracketValidation("()[[Extra Characters}}");
            MultiBracketValidation("(){}[[]]");
            MultiBracketValidation("{}{Code}[Fellows](())");
            MultiBracketValidation("[({}]");
            MultiBracketValidation("(](");
            MultiBracketValidation("{(})");
            MultiBracketValidation("()");
            MultiBracketValidation(")(");
        }

        public static bool MultiBracketValidation(string input)
        {

            char openingRound = '(';
            char closingRound = ')';
            char openingSquare = '[';
            char closingSquare = ']';
            char openingCurly = '{';
            char closingCurly = '}';

            StacksAndQueues.Stack<char> tempStack = new StacksAndQueues.Stack<char>();
            Dictionary<char, char> keyValues = new Dictionary<char, char>();

            keyValues.Add(openingRound, closingRound);
            keyValues.Add(openingSquare, closingSquare);
            keyValues.Add(openingCurly, closingCurly);

            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    // filter for the opening shapes
                    if (input[i] == openingRound || input[i] == openingSquare || input[i] == openingCurly)
                    {
                        tempStack.Push(input[i]);
                    }
                    else if (input[i] == closingRound || input[i] == closingSquare || input[i] == closingCurly)
                    {
                        char tempChar = tempStack.Peek();

                        if (keyValues[tempChar] == input[i])
                        {
                            tempStack.Pop();
                        }
                        else
                        {
                            Console.WriteLine(false);
                            return false;
                        }
                    }
                }
                Console.WriteLine(tempStack.IsEmpty());
                return tempStack.IsEmpty();
            }
            catch (Exception)
            {
                Console.WriteLine(false);
                return false;
            }
        }
    }
}

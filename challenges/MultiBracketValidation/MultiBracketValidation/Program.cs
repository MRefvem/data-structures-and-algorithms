using System;
using System.Runtime.CompilerServices;
using 

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
        }

        public static bool MultiBracketValidation(string input)
        {
            bool isValid = true;
            bool isNotValid = false;

            //string[] charArray = input.Split(Char[']);

            //char[] newCharArray = new char[charArray];

            char openingRound = '(';
            char closingRound = ')';
            char openingSquare = '[';
            char closingSquare = ']';
            char openingCurly = '{';
            char closingCurly = '}';

            char 

            for (int i = 0; i < input.Length; i++)
            {
                // Create a stack to keep track of the opening brackets
                // Use stacks and queues library

                if (input[i] == openingRound)
                {
                    if (input[i] != closingRound)
                    {
                        Console.WriteLine(isNotValid);
                        return isNotValid;
                    }
                    else
                    {
                        Console.WriteLine(isValid);
                        return isValid;
                    }
                }
                else if (input[i] == openingSquare)
                {
                    if (input[i] != closingSquare)
                    {
                        Console.WriteLine(isNotValid);
                        return isNotValid;
                    }
                    else
                    {
                        Console.WriteLine(isValid);
                        return isValid;
                    }
                }
                else if (input[i] == openingCurly)
                {
                    if (input[i] != closingCurly)
                    {
                        Console.WriteLine(isNotValid);
                        return isNotValid;
                    }
                    else
                    {
                        Console.WriteLine(isValid);
                        return isValid;
                    }
                }
            }
            Console.WriteLine(isNotValid);
            return isNotValid;
        }
    }
}

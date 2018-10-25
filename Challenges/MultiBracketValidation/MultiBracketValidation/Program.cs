using System;
using System.Text.RegularExpressions;
using MultiBracketValidation.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string test1 = "{abc}";
            string test2 = "{(abc}";
            string test3 = "}{";
            string test4 = "";
            Console.WriteLine($"The test is balanced: {MultiBracketValidation(test4)}");
        }

        /// <summary>
        /// method checks to make sure brackets are balanced and equal.
        /// </summary>
        /// <param name="input">string containing brackets</param>
        /// <returns>true or false</returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack openBrackets = new Stack();
            string openPattern = @"[{\[\(]";
            string closePattern = @"[}\]\)]";


            foreach (char character in input)
            {
                Match resultOpen = Regex.Match(character.ToString(), openPattern);
                Match resultClose = Regex.Match(character.ToString(), closePattern);

                if (resultOpen.Success)
                {
                    Node addNode = new Node(character.ToString());
                    openBrackets.Push(addNode);
                }
                if (resultClose.Success)
                {
                    string temp = "";
                    if (character.ToString() == "}")
                    {
                        temp = "{";
                    }
                    else if (character.ToString() == "]")
                    {
                        temp = "[";
                    }
                    else if (character.ToString() == ")")
                    {
                        temp = "(";
                    }
                    if (openBrackets.Top == null || temp != (string)openBrackets.Pop().Value)
                    {
                        return false;
                    }
                }
            }
            if (openBrackets.Top == null)
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

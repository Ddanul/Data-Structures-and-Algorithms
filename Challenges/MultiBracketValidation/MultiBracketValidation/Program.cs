﻿using System;
using System.Text.RegularExpressions;
using MultiBracketValidation.Classes;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string test1 = "{abc}";
            string test2 = "{(abc}";
            string test3 = "}{";
            Console.WriteLine($"The test is balanced: {MultiBracketValidation(test3)}");
        }

        static bool MultiBracketValidation(string input)
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
            return true;
        }
    }
}

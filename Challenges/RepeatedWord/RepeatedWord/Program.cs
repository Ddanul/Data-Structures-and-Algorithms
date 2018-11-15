﻿using Hashtables.Classes;
using System;

namespace RepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string sentence = "This is a sentence and is also a test";

            Console.WriteLine($"{sentence}: The first repeated word is: ");
            Console.WriteLine(RepeatedWord(sentence));
        }

        public static string RepeatedWord(string sentence)
        {
            string[] words = sentence.Split(" ");
            Hashtable hashtable = new Hashtable();

            foreach (string word in words)
            {
                if (!hashtable.Contains(word))
                {
                    Node node = new Node(word, word);
                    hashtable.Add(node);
                }
                else
                {
                    return word;
                }
            }
            return "No Repeated Words.";
        }
    }
}

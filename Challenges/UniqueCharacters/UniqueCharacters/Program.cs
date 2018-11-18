using Hashtables.Classes;
using System;

namespace UniqueCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string testToPass = "ilovecats";
            Console.WriteLine(testToPass);
            Console.WriteLine($"The phrase has no repeated characters: {UniqueCharacters(testToPass)}");
            string testToFail = "chicken";
            Console.WriteLine(testToFail);
            Console.WriteLine($"The phrase has no repeated characters: {UniqueCharacters(testToFail)}");

        }

        public static bool UniqueCharacters(string phrase)
        {
            Hashtable hash = new Hashtable();

            foreach(char letter in phrase)
            {
                if (hash.Contains(letter.ToString().ToLower()))
                {
                    return false;
                }
                else
                {
                    Node node = new Node(letter.ToString().ToLower(), letter.ToString());
                    hash.Add(node);
                }
            }
            return true;
        }
    }
}

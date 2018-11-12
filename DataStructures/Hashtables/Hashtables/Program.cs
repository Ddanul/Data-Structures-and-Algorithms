﻿using Hashtables.Classes;
using System;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node n1 = new Node("South Lake Union", "98109");
            Node n2 = new Node("Madrona", "98110");
            Node n3 = new Node("Magnolia", "98199");
            Node n4 = new Node("Greenlake", "98103");
            Node n5 = new Node("Redmond", "98052");

            Hashtable hashtable = new Hashtable();

            hashtable.Add(n1);
            hashtable.Add(n2);
            hashtable.Add(n3);
            hashtable.Add(n4);
            hashtable.Add(n5);

            Console.WriteLine("Trying to find a value: Expected - 98199");
            Console.WriteLine(hashtable.Find("Magnolia"));

            Console.WriteLine("Trying to see if node is in hashtable: Expected - True");
            Console.WriteLine(hashtable.Contains("Magnolia"));

            Console.WriteLine("Trying to see if node is in hashtable: Expected - False");
            Console.WriteLine(hashtable.Contains("Seattle"));
        }
    }
}

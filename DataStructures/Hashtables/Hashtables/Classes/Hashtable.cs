using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {
        public LList[] hashtable = new LList[100];

        /// <summary>
        /// returns integer used for index
        /// </summary>
        /// <param name="key"></param>
        /// <returns>index integer</returns>
        public int GetHash(string key)
        {
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(key);
            int val = 0;
            foreach (byte b in ASCIIValues)
            {
                val += b;
            }

            val = val * 499;
            val = val % hashtable.Length;
            return val;
        }

        public void Add(Node newNode)
        {
            int index = GetHash(newNode.Key);
            hashtable[index].Append(newNode);
        }

        public string Find(string key)
        {
            int index = GetHash(key);
            Node current = hashtable[index].Current;

            while (current != null)
            {
                if (current.Key == key)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return null;
        }

        public bool Contains(string key)
        {
            return Find(key) != null;
        }


    }
}

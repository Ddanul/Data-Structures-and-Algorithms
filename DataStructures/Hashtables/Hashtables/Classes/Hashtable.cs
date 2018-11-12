using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
    {
        public object[] hashtable = new object[100];

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
    }

}

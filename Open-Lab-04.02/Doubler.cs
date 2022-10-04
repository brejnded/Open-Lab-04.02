using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string modified = string.Empty;
            for (int i = 0; i < original.Length; i++)
            {
                modified = modified + original[i] + original[i];
            }
            return modified;
        }
    }
}

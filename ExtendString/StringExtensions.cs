using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtendString
{
    public static class StringExtensions
    {
        public static string ToRandomClase(this string s)
        {
            string novaString = "";

            Random rd = new Random();
        
            foreach(char c in s)
            {
                novaString += rd.NextDouble() < 0.5 ? char.ToLower(c) : char.ToUpper(c);
            }

            return novaString;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ExtendString
{
    public static class StringExtensions
    {
        public static string ToRandomClase(this string s)
        {
            Random rd = new Random();
            StringBuilder sb = new StringBuilder();
        
            foreach(char c in s)
            {
                sb.Append(rd.NextDouble() < 0.5 ? char.ToLower(c) : char.ToUpper(c));
            }

            return sb.ToString();
        }
    }
}
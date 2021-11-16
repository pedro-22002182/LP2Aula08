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
                double n = rd.NextDouble();

                if(n < 0.5)
                    novaString += c.ToString().ToUpper();
                else
                    novaString += c.ToString().ToLower();
            }

            return novaString;
        }
    }
}
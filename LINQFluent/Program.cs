using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace LINQFluent
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texto = File.ReadAllLines("livro.txt");

            int linhasCompMaior30 = texto.Count(linha => linha.Length > 30);
            Console.WriteLine(linhasCompMaior30);

            double mediaCaracteres = texto.Average( linha => linha.Length );
            Console.WriteLine(mediaCaracteres);

            bool linhaMais = texto.Any( linhas => linhas.Length > 120 );
            Console.WriteLine(linhaMais);

            IEnumerable<string> ComecaY = texto.Where( linha => linha.Contains("Y") )
                                                .Select( linha => linha.Trim().Split()?[0].ToUpper());
            priprintarnt(ComecaY);
        }


        static void priprintarnt(IEnumerable<string> lista)
        {
            foreach(string s in lista)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
    }
}

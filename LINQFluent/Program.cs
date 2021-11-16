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

            linhasCompMaior30 = 
                            (from linha in texto
                            where linha.Length > 30
                            select linha).Count();



            double mediaCaracteres = texto.Average( linha => linha.Length );
            Console.WriteLine(mediaCaracteres);

            mediaCaracteres =
                            (from linha in texto
                            select linha.Length).Average();



            bool linhaMais = texto.Any( linhas => linhas.Length > 120 );
            Console.WriteLine(linhaMais);

            linhaMais =
                            (from linha in texto
                            where linha.Length > 120
                            select linha).Any();



            IEnumerable<string> ComecaY = texto.Where( linha => linha.Contains("Y") )
                                                .Select( linha => linha.Trim().Split()?[0].ToUpper());
            priprintarnt(ComecaY);


            linhaMais =
                            (from linha in texto
                            where linha.Contains("Y")
                            select linha => linha.Trim().Split()?[0].ToUpper());
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_do_2e5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tcinco = 5;       //Constante de tipo int para a tabuada do 5.
            const int tdois = 2;        //Constante de tipo int para a tabuada do 2.
            int c, d, resultado;        //Variáveis de tipo int para ambas tabuadas e resultados.


            Console.WriteLine("\t\t░░░░░▒▒▒▒▒▒▒▓▓▓ Produced by Hebert ▓▓▓▒▒▒▒▒▒▒░░░░░");

            Console.WriteLine("┌─────────────┐");
            Console.WriteLine("│Tabuada do 5 │");   //Mostrar titulo/identifica a tabuada que será mostrada abaixo (Tabuada do 5).
            Console.WriteLine("└─────────────┘");

            for (c = 1; c <= 10; ++c)   //Por meio do laço 'for' realizar a tabuada até que seja satifeita as 10 operaçôes básicas da tabuada do 5.
            {
                resultado = tcinco * c;                                       //Fórmula da tabuada do 5.
                Console.WriteLine(tcinco + " X " + c + " = " + resultado);    //Mostra resultado da tabuada do 5.
            }

            Console.WriteLine("\t\t░░░░░▒▒▒▒▒▒▒▓▓▓ Produced by Hebert ▓▓▓▒▒▒▒▒▒▒░░░░░");

            Console.WriteLine("┌─────────────┐");
            Console.WriteLine("│Tabuada do 2 │");   //Mostrar titulo/identifica a tabuada que será mostrada abaixo (Tabuada do 2).
            Console.WriteLine("└─────────────┘");

            for (d = 1; d <= 10; ++d)   //Por meio do laço 'for' realizar a tabuada até que seja satifeita as 10 operaçôes básicas da tabuada do 2.
            {
                resultado = tdois * d;                                        //Fórmula da tabuada do 2.
                Console.WriteLine(tdois + " X " + d + " = " + resultado);     //Mostra resultado da tabuada do 2.
            }

            Console.ReadKey();
        }

    }
}
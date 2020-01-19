using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long NumAnterior = 0, NumAtual = 1, fibonacci;
            int i;

            for (i = 0; i <= 50; i++)       //Por meio do laço 'for' realizar a fórmula de fibonacci até que seja satifeita as 50 primeiras.
            {
                fibonacci = NumAnterior + NumAtual;         //Fórmula de fibonacci (Onde o resultado consiste na soma do número anterior com o número atual.
                Console.WriteLine("Fibonacci {0} = {1}", i, fibonacci);          //Mostrar qual a posição do fibonacci e logo a frente seu respectivo valor. 
                NumAnterior = NumAtual;                                     /*NumAtual vale 1, portanto, NumAnterior representará o valor de maior número da
                                                                              soma anterior na segunda repetição da Fórmula de fibonacci.*/
                NumAtual = fibonacci;               //Será atribuído o valor de fibonacci á NumAtual.
            }
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCULADORA
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0; int num2 = 0, total;
            string operacao;
            total = 0;

            // Display title as the C# console calculator app | Exibe o título do aplicativo de calculadora em console C#.
            Console.WriteLine("Console Calculator in C# | Calculadora de console em C#\r");
            Console.WriteLine("-------------------------------------------------------\n");

            // Ask the user to type the first number    |   Pedi ao usuário para digitar o primeiro número.
            Console.WriteLine("Type a number, and then press Enter | Digite um número e pressione Enter:");
            num1 = Convert.ToInt32(Console.ReadLine());     //Armazenar o valor informado pelo usuário no int 'num1'.

            // Ask the user to type the first number    |   Pedi ao usuário para digitar o segundo número.
            Console.WriteLine("Type a number, and then press Enter | Digite outro número e pressione Enter:");
            num2 = Convert.ToInt32(Console.ReadLine());     //Armazenar o valor informado pelo usuário no int 'num2'.

            // Ask the user to type an operation    |   Pedi ao usuário para digitar uma operação.
            Console.WriteLine("Type an operation + - * or / and then press Enter | Digite uma operação + - * ou / e pressione Enter");
            operacao = Console.ReadLine();    //Armazenar a operação informada pelo usuário na string 'operacao'.

            switch (operacao)   //Realizar/instaciar a operação matematica escolhida pelo usuario.
            {
                case "+": total = num1 + num2; break;
                case "-": total = num1 - num2; break;
                case "*": total = num1 * num2; break;
                case "/": total = num1 / num2; break;
            }
            /*Console.WriteLine("Total value is | O valor total é: " + total);*/

            //Mostrar o resultado da operação ao usuário.
            Console.WriteLine("Total value is | O valor total é: ");
            Console.WriteLine(+ total);
            Console.ReadLine();
        }
    }
}

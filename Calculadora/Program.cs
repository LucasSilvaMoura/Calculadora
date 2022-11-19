using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int numero1, numero2, resultado = 0;
                string operacao;

                Console.WriteLine("Dite o primeiro numero?");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a operação");
                operacao = Console.ReadLine();

                Console.WriteLine("Dite o primeiro numero?");
                numero2 = int.Parse(Console.ReadLine());

                resultado = operacao switch
                {
                    "+" => numero1 + numero2,
                    "-" => numero1 - numero2,
                    "/" => numero1 / numero2,
                    "*" => (numero1 * numero2),
                    _ => throw new Exception("Expressão Invalida!"),
                };
                Console.WriteLine("{0} {1} {2} = {3}", numero1, operacao, numero2, resultado);
                Console.ReadKey(true);
            }
        }
    }
}
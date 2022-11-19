using System;
using System.Linq;
using Operadores;


namespace CalculadoraPadrao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var operacaoValida = true;

            while (operacaoValida)
            {

                Console.WriteLine("Digite a operação desejada:");
                Console.WriteLine("'+' - Soma, '-' - Subtração, '' - Multiplicação, '/' - Divisão");
                var operacao = Console.ReadLine();

                string[] operacoes = { "+", "-", "", "/" };
                operacaoValida = operacoes.Contains(operacao);

                Console.WriteLine("Digite o primeiro número:");
                var valor1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo número:");
                var valor2 = int.Parse(Console.ReadLine());

                var Adicao = new Adicao(valor1, valor2);
                var Subtracao = new Subtracao(valor1, valor2);
                var Multiplicacao = new Multiplicacao(valor1, valor2);
                var Divisao = new Divisao(valor1, valor2);

                var resultado = operacao switch
                {
                    "+" => Adicao.Soma(),
                    "-" => Subtracao.Dinimuir(),
                    "*" => Multiplicacao.Multiplicar(),
                    "/" => Divisao.Dividir(),
                    _ => throw new Exception("Inválida"),
                };

                Console.WriteLine("O Resultado é: " + resultado);

            }

        }
    }
}


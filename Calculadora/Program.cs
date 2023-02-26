using System;
using System.Linq;
using Operadores;

namespace CalculadoraPadrao
{
    internal class Program
    {
        private static double a;
        private static double b;
        private static double c;
        private static readonly int valor1;
        private static readonly int valor2;

        static void Main(string[] args)
        {
            var operacaoValida = true;

            while (operacaoValida)
            {
                Console.WriteLine("Escolha a operação desejada:");
                Console.WriteLine("1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Divisão, 5 - Potência, 6 - Raiz Quadrada, 7 - Porcentagem, 8 - Bhaskara, 0 - Sair");
                Console.WriteLine("Digite o número correspondente à operação:");

                if (!int.TryParse(Console.ReadLine(), out int operacao) || operacao < 0 || operacao > 8)
                {
                    Console.WriteLine("Opção inválida! Por favor, digite uma opção válida.");
                    continue;
                }

                if (operacao == 0)
                {
                    break;
                }

                if(operacao == 1 || operacao == 2 || operacao == 3 || operacao == 4 || operacao == 5 || operacao == 6 || operacao == 7)
                { 
                    Console.WriteLine("Digite o primeiro número:");
                     if (!int.TryParse(Console.ReadLine(), out _))
                     {
                    Console.WriteLine("Valor inválido! Por favor, digite um número inteiro.");
                      continue;
                     }

                    Console.WriteLine("Digite o segundo número:");
                      if (!int.TryParse(Console.ReadLine(), out _))
                      {
                    Console.WriteLine("Valor inválido! Por favor, digite um número inteiro.");
                      continue;
                      }

                }

                if (operacao == 8)
                {
                    Console.WriteLine("Digite o valor de a:");
                     if (!double.TryParse(Console.ReadLine(), out double a))
                     {
                        Console.WriteLine("Valor inválido! Por favor, digite um número real.");
                        continue;
                     }

                    Console.WriteLine("Digite o valor de b:");
                     if (!double.TryParse(Console.ReadLine(), out double b))
                     {
                        Console.WriteLine("Valor inválido! Por favor, digite um número real.");
                        continue;
                     }

                    Console.WriteLine("Digite o valor de c:");
                     if (!double.TryParse(Console.ReadLine(), out double c))
                     {
                        Console.WriteLine("Valor inválido! Por favor, digite um número real.");
                        continue;
                     }
                }

                var resultado = 0.0;

                switch (operacao)
                {
                    case 1:
                        var adicao = new Adicao(valor1, valor2);
                        resultado = adicao.Soma();
                        break;
                    case 2:
                        var subtracao = new Subtracao(valor1, valor2);
                        resultado = subtracao.Dinimuir();
                        break;
                    case 3:
                        var multiplicacao = new Multiplicacao(valor1, valor2);
                        resultado = multiplicacao.Multiplicar();
                        break;
                    case 4:
                        var divisao = new Divisao(valor1, valor2);
                        resultado = divisao.Dividir();
                        break;
                    case 5:
                        var potencia = new Potencia(valor1, valor2);
                        resultado = potencia.Elevar();
                        break;
                    case 6:
                        var raiz = new Raiz(valor1, valor2);
                        resultado = raiz.Calcular();
                        break;
                    case 7:
                        var porcentagem = new Porcentagem(valor1, valor2);
                        resultado = porcentagem.Calcular();
                        break;

                    case 8:
                        var bhaskara = new Bhaskara(a, b, c);
                        resultado = bhaskara.GetHashCode();
                        break;

                }

                Console.WriteLine("O Resultado é: " + resultado);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

}


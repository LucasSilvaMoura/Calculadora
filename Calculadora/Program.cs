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
                Console.WriteLine("Escolha a operação desejada:");
                Console.WriteLine("1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Divisão, 5 - Potência, 6 - Raiz Quadrada, 7 - Porcentagem, 0 - Sair");
                Console.WriteLine("Digite o número correspondente à operação:");

                if (!int.TryParse(Console.ReadLine(), out int operacao) || operacao < 0 || operacao > 6)
                {
                    Console.WriteLine("Opção inválida! Por favor, digite uma opção válida.");
                    continue;
                }

                if (operacao == 0)
                {
                    break;
                }

                Console.WriteLine("Digite o primeiro número:");
                if (!int.TryParse(Console.ReadLine(), out int valor1))
                {
                    Console.WriteLine("Valor inválido! Por favor, digite um número inteiro.");
                    continue;
                }

                Console.WriteLine("Digite o segundo número:");
                if (!int.TryParse(Console.ReadLine(), out int valor2))
                {
                    Console.WriteLine("Valor inválido! Por favor, digite um número inteiro.");
                    continue;
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
                }

                Console.WriteLine("O Resultado é: " + resultado);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

}


using System;

namespace CalculadoraPadrao
{
    internal class Porcentagem
    {
        private readonly int _valor1;
        private readonly int _valor2;

        public Porcentagem(int valor1, int valor2)
        {
            _valor1 = valor1;
            _valor2 = valor2;
        }

        public double Calcular()
        {
            return (_valor1 * _valor2) / 100;
        }
    }
}

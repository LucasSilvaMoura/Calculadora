using System;

namespace Operadores
{
    public class Raiz
    {
        private int _radicando;
        private int _indice;
        private int valor1;

        public Raiz(int valor1)
        {
            this.valor1 = valor1;
        }

        public Raiz(int radicando, int indice)
        {
            if (indice <= 0)
            {
                throw new ArgumentException("O índice deve ser um número positivo");
            }
            if (radicando < 0)
            {
                throw new ArgumentException("O radicando deve ser um número positivo ou zero");
            }

            _radicando = radicando;
            _indice = indice;
        }

        public double Calcular()
        {
            return Math.Pow(_radicando, 1.0 / _indice);
        }
    }
}

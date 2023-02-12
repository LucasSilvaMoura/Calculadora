using System;

namespace Operadores
{
    public class Potencia
    {
        private int _base;
        private int _expoente;

        public Potencia(int baseNumber, int expoente)
        {
            _base = baseNumber;
            _expoente = expoente;
        }

        public int Elevar()
        {
            return (int)Math.Pow(_base, _expoente);
        }
    }
}
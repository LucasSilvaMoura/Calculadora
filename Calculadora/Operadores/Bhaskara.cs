using System;

namespace Operadores
{
    public class Bhaskara
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Bhaskara(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public (bool temRaizes, double x1, double x2) CalcularRaizes()
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return (false, 0, 0);
            }

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return (true, x1, x2);
        }
    }
}

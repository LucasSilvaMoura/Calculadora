namespace Operadores
{
    internal class Divisao
    {
        public int numero1 { get; set; }
        public int numero2 { get; set; }

        public Divisao(int N1, int N2) { numero1 = N1; numero2 = N2; }

        public int Dividir()
        {
            return numero1 / numero2;
        }
    }
}

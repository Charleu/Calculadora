using System;

namespace Calculadora
{
    public class CalculadoraCientifica : CalculadoraBasica
    {
        public CalculadoraCientifica(double resultado) : base(resultado)
        {
        }

        public double RaizQuadrada(double a)
        {
            if (a < 0)
            {
                Console.WriteLine("Não existe raíz quadrada de número negativo.");
                return 0;
            }
            return Math.Sqrt(a);
        }
    }
}

using System;
namespace Calculadora
{
    public abstract class CalculadoraBasica
    {
        public double Resultado { get; private set; }

        public CalculadoraBasica(double resultado)
        {
            Resultado = resultado;
        }

        public double Somar(double a, double b)
        {
            return Resultado = a + b;          
        }

        public double Subtrair(double a, double b)
        {
           return Resultado = a - b;         
        }

        public double Multiplicar(double a, double b)
        {
           return Resultado = a * b;       
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Número zero.");
                return 0;
            }
            return Resultado = a / b;
        }
    }
}


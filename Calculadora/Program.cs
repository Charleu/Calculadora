using System;

namespace Calculadora
{
    public class Calculadora
    {
        public static void Main(string[] args)
        {
            CalculadoraCientifica calc = new CalculadoraCientifica(0);
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Escolha a operação:");
                Console.WriteLine("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n5 - Raiz Quadrada\n6 - Sair");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Informe os dois valores para somar:");
                        double a1 = double.Parse(Console.ReadLine());
                        double b1 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {calc.Somar(a1, b1).ToString("F2")}"); break;

                    case 2:
                        Console.WriteLine("Informe os dois valores para subtrair:");
                        double a2 = double.Parse(Console.ReadLine());
                        double b2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {calc.Subtrair(a2, b2).ToString("F2")}"); break;

                    case 3:
                        Console.WriteLine("Informe os dois valores para multiplicar:");
                        double a3 = double.Parse(Console.ReadLine());
                        double b3 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {calc.Multiplicar(a3, b3).ToString("F2")}"); break;

                    case 4:
                        Console.WriteLine("Informe os dois valores para dividir:");
                        double a4 = double.Parse(Console.ReadLine());
                        double b4 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {calc.Dividir(a4, b4).ToString("F2")}"); break;
                    case 5:
                        Console.WriteLine("Informe o valor para calcular a raiz quadrada:");
                        double valorRaiz = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {calc.RaizQuadrada(valorRaiz).ToString("F2")}"); break;

                    case 6:
                        continuar = false;
                        Console.WriteLine("Encerrando..."); break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");break;
                }
                Console.ReadKey();
            }
        }
    }
}

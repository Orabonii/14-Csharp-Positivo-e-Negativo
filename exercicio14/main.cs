using System;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor, digite um número:");
            double numero;

            if (double.TryParse(Console.ReadLine(), out numero))
            {
                if (numero > 0)
                {
                    double raizQuadrada = Math.Sqrt(numero);
                    Console.WriteLine($"O número é positivo. A raiz quadrada de {numero} é: {raizQuadrada}");
                }
                else if (numero < 0)
                {
                    double aoQuadrado = Math.Pow(numero, 2);
                    Console.WriteLine($"O número é negativo. {numero} ao quadrado é: {aoQuadrado}");
                }
                else
                {
                    Console.WriteLine("O número é zero.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        }
    }








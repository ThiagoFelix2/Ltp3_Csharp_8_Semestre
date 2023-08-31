using System;

namespace SomaETriplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double numero2 = double.Parse(Console.ReadLine());

            double soma = numero1 + numero2;

            if (numero1 == numero2)
            {
                double triploSoma = soma * 3;
                Console.WriteLine($"Os números são iguais. O triplo da soma é: {triploSoma}");
            }
            else
            {
                Console.WriteLine($"A soma dos números é: {soma}");
            }
        }
    }
}

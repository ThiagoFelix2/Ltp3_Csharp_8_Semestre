using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }
        }
    }
}

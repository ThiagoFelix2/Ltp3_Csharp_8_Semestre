using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento no formato dd/mm/aaaa:");
            string dataNascimentoStr = Console.ReadLine();

            // Convertendo a string para DateTime
            DateTime dataNascimento = DateTime.ParseExact(dataNascimentoStr, "dd/MM/yyyy", null);

            // Calculando a idade
            int idade = CalcularIdade(dataNascimento);

            Console.WriteLine($"Sua idade é: {idade} anos");
        }

        static int CalcularIdade(DateTime dataNascimento)
        {
            DateTime dataAtual = DateTime.Now;
            int idade = dataAtual.Year - dataNascimento.Year;

            // Ajustando a idade se o aniversário ainda não ocorreu este ano
            if (dataAtual.Month < dataNascimento.Month || (dataAtual.Month == dataNascimento.Month && dataAtual.Day < dataNascimento.Day))
            {
                idade--;
            }

            return idade;
        }
    }
}
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Escreva seu nome: ");
        string nomeUsuario = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idadeUsuario = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o mês do seu aniversário (1 a 12): ");
        int mesAniversario = Convert.ToInt32(Console.ReadLine());

        Console.Write("Sua expectativa de vida: ");
        int expVida = Convert.ToInt32(Console.ReadLine());

        int mesesRestantes = (expVida * 12) - (idadeUsuario * 12 + mesAniversario);
        int anosRestantes = mesesRestantes / 12;
        mesesRestantes %= 12;

        Console.WriteLine($"Olá, {nomeUsuario}! Você tem {idadeUsuario} anos e seu aniversário é no mês {mesAniversario}.");
        Console.WriteLine($"Sua expectativa de vida é de {expVida} anos.");
        Console.WriteLine($"Você tem aproximadamente {mesesRestantes} meses e {anosRestantes} anos restantes de vida.");
    }
}
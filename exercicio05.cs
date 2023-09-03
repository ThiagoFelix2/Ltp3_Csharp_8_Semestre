/* Crie um programa em C# que realize o seguinte:

Solicite ao usuário que insira seu nome completo.
Solicite ao usuário que insira sua idade.
Utilize métodos de string para realizar as seguintes operações:
Exiba o nome completo em maiúsculas.
Exiba o nome completo em minúsculas.
Conte o número de caracteres no nome completo (ignorando espaços em branco).
Converta a idade fornecida pelo usuário em um número inteiro.
Calcule o ano de nascimento do usuário com base na idade fornecida (supondo que o ano atual seja 2023).
Exiba o ano de nascimento calculado e a idade em que o usuário fará 100 anos.
Dicas:

Use os métodos ToUpper(), ToLower(), Length, Trim() e conversões para manipular as strings.
Use a classe Convert para converter a idade fornecida em um número inteiro.
Lembre-se de que o ano de nascimento pode ser calculado subtraindo a idade do ano atual (2023). */

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();
        
        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Nome em maiusculo: " + nome.ToUpper());
        Console.WriteLine("Nome em minusculo:  " + nome.ToLower()); 
        
        Console.WriteLine("Numero de caracteres no nome: " + nome.Length);
        
        DateTime dataAtual = DateTime.Now;
        
        Console.WriteLine("Data Atual : "  + dataAtual);
        
        int  anoNascimento = dataAtual.Year - idade;
        
        Console.WriteLine("\n Ano de nascimento: " + anoNascimento);
        
        int anoCem = anoNascimento  + 100;
       
        Console.WriteLine("\n Ano em que voce completara 100 anos: " + anoCem);
    }
}
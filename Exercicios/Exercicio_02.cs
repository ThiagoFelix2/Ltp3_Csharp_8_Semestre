// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insira seu nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Insira seu sobrenome: ");
        string sobrenome = Console.ReadLine();
        
        Console.WriteLine("Nome e sobrenome: " + nome + " " + sobrenome);
    }
}
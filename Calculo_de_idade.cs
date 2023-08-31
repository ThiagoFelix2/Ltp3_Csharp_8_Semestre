// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Console.WriteLine ("Escreva seu nome: ");
        Console.WriteLine ("Digite sua idade: ");
        
        //Criar uma variael do tipo string para armazenar dados de usuario
        
        int idadeUsuario = Convert.ToInt32(Console.ReadLine());
        //Console.ReadLine();
        //string
        
        //exibir o valor da var nome
        Console.WriteLine("Sua idade: " +idadeUsuario);
        // console.WriteLine("Usuario e: " +nomeUsuario);
        
        Console.WriteLine("Sua expectativa de vida: ");
        
        int expV = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(expV - idadeUsuario);
    }
}
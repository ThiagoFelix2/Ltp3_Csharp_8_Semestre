// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string email = "thiago.com.br";
       string senha = "123456";
       
       Console.WriteLine("Digite seu email: ");
       string Email = Console.ReadLine();
       
       Console.WriteLine("Digite sua senha: ");
       string Senha = Console.ReadLine();
       
       Console.WriteLine("Digite ");
       if(Email == email && Senha == senha){
            Console.WriteLine("Uario permitido a utilizar o sistema");    
           
       }
       
    }
}
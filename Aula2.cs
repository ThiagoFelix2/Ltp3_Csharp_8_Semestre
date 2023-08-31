// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

namespace HelloProgramador
{
    class Program{
        static void Main(string[] args)
        {
            int meuNumero = 5;//interger (numero inteiro)
            float meuNumeroDecimal = 5.55;//float (numero decimal) armazena 4 bytes - 3 casas decimais
            double meuNumeroDecimal = 5.55D; //double (numero decimal) - armazena 8 bytes - 7 casas decimais
            long meuNumeroGrande = 5.065664546L;//Long (numero grande)
            char meuCaractere = 'a'; //char (caractere) - armazena 2 bytes
            string minhaFrase = "Ola, programador";//String(frase) - armazena 2 bytes por caractere
            bool meuBooleano = true;//Boolean (booleano) - armazena 1 bit
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;
            console.WriteLine("A soma dos numeros e: " +soma);

            //Casting - conversão de tipos
           int num1 = Convert.ToInt32(Console.ReadLine());
           
           //Conversão Explicita
           int num2 = int.Parse(console.ReadLine());
           
           //Conversão Implicita
           int num3 = 10;

           
           // Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

namespace HelloProgramador
{
    class Program{
        static void Main(string[] args)
        {
           //operacao matematicas
           int x = 10 + 20; //soma
           int y = 30 - 10;//Subtração
           int z = 10 * 10;//multiplicação
           int w = 100 / 10; //divisão
           int v = 100 % 10; //resto da divisão:
           
           /*Desafio.. Um controle de estabilidade de aeronave mede a inclinação de asa com base no ângulo de inclinação em relação ao eixo horizoltal se o ângulo de inclinação for maior que 45 graus, o sistema de controle de estabilidade deve exibir um alerta para o sistema. por ecconomia de memoria você deve usar um booleano. Considerado que o sistema indica 2340.123. Crie o sistema de alerta. */
           //Angulo aferido pela aeronave
           double angulo = 2340.123;
           //calcular quantas voltas completas o ângulo deu
           double voltas = angulo / 360;
           //Calucular o resto das voltas completas
           double resto = angulo % 360;
           //imprimir na tela o resto
           Console.WriteLine(resto);
           //calcular o ângulo de inclinação
           double inclinacao = resto;
           //calcular o ângulo de inclinação em graus
           double graus = inclinacao * 360;
           //
           bool alerta = graus > 45;
           Console.WriteLine(aleta);
        }
    }
    
}
        
        }
    }
    
}

//exercicio de incremento e decremento
        int a = 10;
        int b = 20;
        int c = a++ +b;//c = 30, a = 11 , b = 20
        int d = ++a +b;//d = 32,  = 12, B = 20
        int e = a-- +b;//e = 32, a = 11. b = 20
        int f = --a +b
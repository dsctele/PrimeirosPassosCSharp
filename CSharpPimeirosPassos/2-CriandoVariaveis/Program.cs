using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando variáveis");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10;

            Console.WriteLine(idade);

            idade = 10 + 5;

            Console.WriteLine(idade);

            idade = (10 + 5) * 10;
            
            Console.WriteLine(idade);
            Console.WriteLine("Executação finalizada, tecle enter para sair");
            Console.Read();
        }
    }
}

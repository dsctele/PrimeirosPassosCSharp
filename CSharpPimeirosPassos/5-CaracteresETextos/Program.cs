using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execuando o projeto 5 - Caracteres e Textos");

            //character
            char primeiraletra = ' ';
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)61;
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)(primeiraletra + 1);
            Console.WriteLine(primeiraletra);

            string titulo = "Alura cursos de tecnologia " + 2020;
            string cusosProgramacao = @" 
                 - .NET 
                 - Java
                 - JavaScript";

            Console.WriteLine(titulo);
            Console.WriteLine(cusosProgramacao);

            Console.ReadLine();

        }
    }
}

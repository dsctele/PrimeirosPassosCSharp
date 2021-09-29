using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");


            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int) salario;

            Console.WriteLine(salarioEmInteiro);

            //int é um número de 32 bits 
            int idade;
            idade = 130;

            Console.WriteLine(idade);

            //long é um número de 64 bits
            long idadeUniverso;
            idadeUniverso = 130000000000000;

            Console.WriteLine(idadeUniverso);

            //short é um número de 16 bits
            short qtdProduto;
            qtdProduto = 130;

            Console.WriteLine(qtdProduto);

            float altura = 1.80f;

            Console.WriteLine(altura);


                    
        }
    }
}

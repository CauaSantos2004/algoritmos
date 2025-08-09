using System;

namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número para ver a tabuada: "); //Solicita que o usuario digite um número
            int numeroDigitado = int.Parse(Console.ReadLine()); // Lê a entrada do usuario e converte para o tipo inteiro

            Console.WriteLine($"Tabuada do {numeroDigitado}: ");

            //Lopp para fazer a tabuada
            for (int i = 1; i <= 10; i++) // Variavel começa com i = 1; (faz o loop começar na primeira multiplicação: ex: 5 x 1)
                                          // enquanto i for menor ou igual a 10, executa o código e depois aumenta i de 1 em 1
            {
                // A linha abaixo Exibe o resultado da multiplicação
                Console.WriteLine($"{numeroDigitado} x {i} = {numeroDigitado * i}"); // O "$" antes das aspas serve para adicionar a variavel dentro do texto
                                                                                    // ficara exemplo: 5 X 1                                     
            }

        }
    }
}

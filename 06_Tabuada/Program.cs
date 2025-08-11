using System;

namespace _06_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int multiplicando = 0, produto;
            bool digitacaoValida = false;

            // ! negação: inverte o valor booleano
            // ! false = true
            // ! true = false
            // while (digitacaoInvalida) == false)
            while(!digitacaoValida)
            {
                Console.WriteLine("Digite um´número Inteirio");
                digitacaoValida = int.TryParse(Console.ReadLine(), out multiplicando);
            }

            //Console.WriteLine("TABUADA DO {0}", multiplicando);
            //interpolação de String "$"
            Console.WriteLine($"TABUADA DO {multiplicando}");
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                produto = multiplicando * multiplicador;
                //Console.WriteLine("{0} X {1} = {2} ", multiplicanso, multiplicador, produto);
                Console.WriteLine($"{multiplicando} X {multiplicador}", produto);
            }


            /*
            MEU CÓDIGO DA CALCULADORA:

        Console.Write("Digite um número: "); 
        // Mostra uma mensagem na tela pedindo que o usuário digite um número.

        int n = int.Parse(Console.ReadLine()); 
        // Lê o que o usuário digitou (como texto), converte para número inteiro (int) e guarda na variável chamada 'n'.
        // Se o usuário digitar "5", por exemplo, 'n' agora vale 5.

        for (int i = 1; i <= 10; i++) 
        // Esse é um laço de repetição (loop). Ele vai repetir o que está dentro dele 10 vezes, de i = 1 até i = 10.
        // A variável 'i' muda a cada repetição: 1, 2, 3, ..., 10.

        {
            Console.WriteLine($"{n} x {i} = {n * i}"); 
            // Em cada repetição, essa linha mostra o resultado da multiplicação do número digitado (n) pelo número atual (i).
            // Exemplo: se n = 5 e i = 3, o resultado será "5 x 3 = 15".
             */
        }
    }
}

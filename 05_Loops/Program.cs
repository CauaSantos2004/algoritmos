using System;
using System.Linq;

namespace _05_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criação de um vetor para armazenamento de 100 nomes
            string[] nomes = new string[100];
            string continuar = "S";
            
            //será meu indice para atribuição no vetor
            int contador = 0;

            //Lopp while
            //Sintaxe: while( expressão booleana)
            while (continuar.ToUpper() !== "S") //"ToUpper()" converte o texto para Maiúsculo
            {

                Console.WriteLine("Digite o {0}ª nome: ", contador + 1); // Mostra uma mensagem pedindo o nome e indica o número do nome (contador + 1)
                //Append: Adiciona um item no vetor
                nomes[contador] = Console.ReadLine(); // Lê o nome digitado pelo usuário e armazena no vetor 'nomes' na posição atual

                //incrementar o contador
                contador++; // Aumenta o contador em 1 para ir para a próxima posição do vetor na próxima repetição
                Console.WriteLine("Deseja Continuar? (S/N)"); // Pergunta ao usuário se ele deseja continuar adicionando nomes
                continuar = Console.ReadLine();  // Lê a resposta do usuário e atualiza a variável 'continuar'
            }

            Console.WriteLine("Nomes Informados: "); // Quando sair do loop, exibe a mensagem informando que vai mostrar os nomes digitados
            foreach (string str in nomes) // Usa um foreach para percorrer todos os itens do vetor 'nomes'

            {

                // O comando abaixo Verifica se o valor atual (str) NÃO é nulo, evitando imprimir posições vazias no vetor
                // "!=" significa diferente de
                if (str != null)
                {
                    Console.WriteLine(str);   // Mostra o nome atual no console
                }
                    
            }
        }
    }
}

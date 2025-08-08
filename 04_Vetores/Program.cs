using System;

namespace _04_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaração de Variavel
            //Sintaxe: Tipo da variavel com o nomeVariavel = valor
            String nome = "Cauã Alves";

            //Reatribuição de valor em uma variavel
            nome = "Beltrano";
            Console.WriteLine(nome); //Imprime na tela o valor que está dentro da variavel

            //Declaração de Vetores
            //Sintaxe: tipo[] nomeVariavel = {valor1, valor2S, valor3}
            //Vetores contém "[]" o que lhe diferencia da variavel
            //índice dos vetores é a posição menos uma posição (indice começa na posição 0)
            string[] nomes = { "Fulano de tal", "Beltrano", "Sicrano", "João", "José", "Maria"};
            Console.WriteLine(nomes[0]); //Aqui imprime na tela o primeiro nome da variavel (Fulano de tal)
            Console.WriteLine(nomes[1]); //Aqui imprime na tela o segundo nome da variavel (Beltrano)
            Console.WriteLine(nomes[2]); //Aqui imprime na tela o terceiro nome da variavel (Sicrano)

            //Loop FOR - É uma estrutura que repete um bloco de códigos varias vezes
            //Sinatxe: for(indice; controle; incremento)
            for (int i = 0; i < nomes.Length; i++) //cria uma variavel i = inciando com 0, enquanto i
                                                   //for menor que nomes.Length ele incrementa em i mais um valor
            {
                Console.WriteLine("{0}º Nome: {1}", i+1, nomes[i]);
            }

            //impressão dos 100 primeiros números pares de 0 a 100
            for (int i = 0; i <= 100; i+=2) // Utiliza um loop FOR com incremento de 2 em 2, garantindo que só números pares sejam exibidos
            {
                Console.WriteLine("Número: {0}", i); //imrime o número atual na tela
            }

            //Lopp foreach
            //Sintaxe: (variavel in vetor)
            foreach (string varNome in nomes)
            { 
                Console.WriteLine("Nome: {0}", varNome);
            }

        }
    }
}

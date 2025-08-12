using System;
using System.Diagnostics.SymbolStore;

namespace _07_TempoDownload
{
    internal class TempoDownload
    {
        static void Main(string[] args)
        {
            double TamanhoMB = 0, VelocidadeMB = 0; //variáveis para armazenar o tamanho do arquivo (em MB) e a velocidade da internet (em Mbps). inicializadas com 0
            bool EntradaValida = false; // Variável booleana que controla se a entrada do usuário é válida ou não, iniciada com false.


            // Loop para validar o tamanho do arquivo
            while (!EntradaValida)
            {
                Console.WriteLine("Informe o tamanho dor arquivo (MB): "); // Solicita ao usuário que informe o tamanho do arquivo em MB

                /*
                 A linha abaixo converte a entrada do usuario (texto) para o tipo decimal (double)
                se a conversão der certo e o valor for maior que Zero, armazena na variavel TamanhoMB e a
                variavel EntradaValida fica TRUE
                caso contrário, a variavel EntradaValida fica FALSE e o Loop repetirá a pergunta.
                */
                EntradaValida = double.TryParse(Console.ReadLine(), out TamanhoMB) && TamanhoMB > 0;


                if (!EntradaValida) // Se a entrada não for válida (não numérica ou menor/igual a zero)
                {
                    Console.WriteLine("Valor Inválido! Digite um número maior que 0"); //Informa na tela esta mensagem ao usúario
                }
            }


            EntradaValida = false; // Reinicia a variável EntradaValida para false para validar a próxima entrada (velocidade)

            //Loop para validar a velocidade da Internet
            while (!EntradaValida)
            {
                Console.WriteLine("Informe a velocidade da Internert (Mbps): "); // Solicita ao usuário que informe a velocidade da internet

                /*
                 Tenta converter a entrada do usúario para número decimal (double)
                 se a conversão der certo, e o número for maior que Zero, armazena na variavel VelocidadeMb e a Entrada fica TRUE
                caso contrário, EntradaValida fica FALSE e o Loop repetirá a pergunta.
                 */
    
                EntradaValida = double.TryParse(Console.ReadLine(), out VelocidadeMB) && VelocidadeMB > 0;

                if (!EntradaValida)
                {
                    Console.WriteLine("Valor Inválido! Digite um número maior que 0"); // Se na tela esta mensagem ao usuario
                }
            }



            // Cálculo do tempo de download
            double tempoSegundos = (TamanhoMB * 8) / VelocidadeMB;
            double tempoMinutos = tempoSegundos / 60;

            Console.WriteLine($"Tempo aproximado de download: {tempoMinutos:F2} minutos");
        }   

        }
}

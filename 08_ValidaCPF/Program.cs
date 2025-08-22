using System;
using System.Text.RegularExpressions;

namespace _08_ValidaCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o seu CPF: "); //Solicita que o usuario digite o cpf
            string CpfDigitado = Console.ReadLine();  // Cria a variável CpfDigitado e guarda nela a entrada digitada pelo usuário


            string CpfSemSPontos = Regex.Replace(CpfDigitado, "[^0-9]", ""); // Regex.Replace(CpfDigitado esta pegando a entrada do usuario e tirando dela tudomque não for um número
                                                                             // "[0-9]", "") a regra: significa "qualquer coisa que NÃO seja número de 0 a 9" substituir por nada ("") ou seja, remover.


            if (CpfSemSPontos.Length != 11) //valida se o cpf digitado possui 11 digitos
            {
                Console.WriteLine("CPF Inválido!");
                return;
            }

            // Valida se todos os números são iguais (qualquer sequência repetida)

            bool todosIguais = true; // Cria uma variável booleana chamada "todosIguais" e assume que todos os números do CPF são iguais inicialmente.
            for (int i = 1; i < CpfSemSPontos.Length; i++)

            {
                if (CpfSemSPontos[i] != CpfSemSPontos[0])
                {
                    todosIguais = false;
                    break;
                }
            }

            if (todosIguais)
            {
                Console.WriteLine("CPF Inválido! Você digitou números repetidos.");
                return;
            }


            string CpfBase = CpfSemSPontos.Substring(0, 9); //.Substring(0, 9) é um método de string que pega uma parte do texto,Ou seja, pega apenas os 9 primeiros números do CPF, que são usados para calcular os dígitos verificadores e guarda na variavel CpfBase esses nove numeros


            //Calculando o primeiro digito verificador do CPF
            int soma = 0;
            for (int i = 0, peso = 10; i < 9; i++, peso--)
            {
                soma += (CpfBase[i] - '0') * peso; // Pega o caractere na posição i da base do CPF (CpfBase[i])
                                                   // Converte de caractere para número inteiro subtraindo '0'
                                                   // Multiplica pelo peso correspondente (peso decrescente de 10 a 2)
                                                   // Adiciona o resultado à variável soma para acumular todos os produtos


            }
            int dv1 = 11 - (soma % 11); // Calcula o primeiro dígito verificador (DV1) do CPF
            if (dv1 >= 10) dv1 = 0;  // Se o resultado for maior ou igual a 10, o dígito vira 0 (regra oficial do CPF)

            // Calculando o segundo digito verificador do CPF
            soma = 0;  // Zera a variável soma para começar novo cálculo
            string cpfComDV1 = CpfBase + dv1; // Junta os 9 dígitos do CPF base com o primeiro dígito verificador já calculado
            for (int i = 0, peso = 11; i < 10; i++, peso--) // Faz o cálculo do segundo dígito verificador
            {
                soma += (cpfComDV1[i] - '0') * peso; // Converte o caractere para número ((cpfComDV1[i] - '0')) e multiplica pelo peso
            }
            int dv2 = 11 - (soma % 11); // Aplica a fórmula para obter o segundo dígito verificador
            if (dv2 >= 10) dv2 = 0; // Se o resultado for maior ou igual a 10, o dígito vira 0

            Console.WriteLine($"CPF completo: {CpfBase} / os digitos verificadores são {dv1}{dv2}");

            //Compara os dígitos calculados com os dígitos informados pelo usuário
            if (int.Parse(CpfSemSPontos[9].ToString()) == dv1 &&
                int.Parse(CpfSemSPontos[10].ToString()) == dv2)
            {
                Console.WriteLine("CPF Válido");     // Se os dois baterem, o CPF é válido
            }
            else
            {
                Console.WriteLine("CPF Inválido");  // Se algum dígito não bater, o CPF é inválido
            }
            //FIM DO MEU CÓDIGO



            //CALCULO DO PRIMEIRO DIGITO VERIFICADOR, CÓDIGO DE RESOLUÇÃO DO PROFESSOR
            /* 
                int soma = 0;
                char[] cpfVetor = cpf.ToCharArray();

                        for(int i = 0; i < 9; i++)
                        {
                            soma += int.Parse(cpfVetor[i].ToString() ) * (10 - i);
                        }
                 int resto = soma % 11;

                 int digX = 0;
                 if(resto >= 2)
                 {
                    digx = 11 - resto;
                 }

            CALCULO DO SEGUNDO DIGITO VERIFICADOR, CÓDIGO DE RESOLUÇÃO DO PROFESSOR
            for(int i = 0; i < 10; i++)
                        {
                            soma += int.Parse(cpfVetor[i].ToString()) * (11 - i++);
                        }
                 int resto = soma % 11;

                 int digX = 0;
                 if(resto >= 2)
                 {
                    digx = 11 - resto;
              
            COMPARAR OS DIGITOS:
            if(
                int.Parse(cpf[9].ToString()) == digX &&
                int.Parse(cpf[10].ToString()) == digX 
              )
            {
                Console.WriteLine("CPF Válido");
            }
            else
            {
                Console.WriteLine("CPF Inválido");
            }
            */

        }


    }
}

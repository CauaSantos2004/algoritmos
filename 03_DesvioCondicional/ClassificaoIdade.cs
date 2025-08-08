using System;

class Classificacao_Idade
{
	static void Main()
	{
		int idade; // criação da variavel
		
		Console.WriteLine("Digite um número: "); //exibir a mensagem na tela
		idade = int.Parse(Console.ReadLine()); //converter a variavel de texto para o tipo Inteiro
		
		if(idade <= 12) // condição "se"
		{ 
			Console.WriteLine("Você é Criança"); //se for vardadeira exibe essa mensagem
		}
		
		else if(idade <= 17) //condição "senão se"
		{
			Console.WriteLine("Você é Adolescente"); //se for vardadeira exibe essa mensagem
		}
		
		else if(idade <= 59) //condição "senão se"
		{
			Console.WriteLine("Você é Adulto");
		}
		
		else // condição senão
		{
			Console.WriteLine("Você é Idoso"); //se for falso exibe essa mensagem	
		}
	}
}
		
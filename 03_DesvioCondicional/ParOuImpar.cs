using System;

class ParOuImpar
{
	static void Main()
	{
		int numero;
		
		Console.WriteLine("Digite um número: ");
		numero = int.Parse(Console.ReadLine() ); //Transforma o número digitado pelo usuario em texto, para inteiro.
		
		if(numero%2 == 0)
			Console.WriteLine("O Número é par");
		else
			Console.WriteLine("O Número é ímpar");
	}
}

using System;

class DeclaracaovariaveisDecimalFormatado
{
	static void Main(string[] args)
	{
		decimal x = 0.999m;
		decimal y = 99999999999999999999m;
		
		/*Utilizando o Placeholder(posição de marcação) para demonstrar 
		o conteúdo de uma variavel no texto
		{0:C} 
		0 = posição de marcação
		c = formatação de moeda (Currency)
		*/
		Console.WriteLine("Minha quantia - {0:C}", x);
		Console.WriteLine("Sua quantia - {0:C}", y);
		
		Console.WriteLine("Valor de x = {0: F3} e Valor de y = {1:C}",x,y);
	}
}
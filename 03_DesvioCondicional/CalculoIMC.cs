using System;

class DeclaracaovariaveisDecimalFormatado
{
	static void Main()
	{
	double peso, altura, imc; //variaveis do tipo "double"	
	Console.WriteLine("Digite seu peso (kg): "); //Console.WriteLine()escreve na tela
	//Console.ReadLine() é equivalente ao leia do Portugol
	peso = Double.Parse( Console.ReadLine() ); //"parse()" converte o texto para o número
	
	Console.WriteLine("Digite sua altura (m): ");
	//Double.Parse() coverte o texto em número decimal
	altura = double.Parse( Console.ReadLine() );
	
	imc = peso / (altura * altura);
	
	Console.WriteLine("Seu IMC é {0:F3}", imc );
	if(imc < imc 18.5)
	{
		Console.WriteLine("Classificação: Abaixo do peso");
	}else if(imc < 25)
	{
		Console.WriteLine("Classificação: Peso normal");
	}else
	{
		Console.WriteLine("Classificação: Acima do peso");
	}
		
	}
	
}
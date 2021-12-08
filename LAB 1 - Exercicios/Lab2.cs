// See https://aka.ms/new-console-template for more information


//======================================= LAB 2 ===============================

/*//Exercicio 1
		//intrudução dos valores
		Console.WriteLine("EScreva o valor de a");
		int a = int.Parse(Console.ReadLine());
		
		Console.WriteLine("EScreva o valor de ");
		int b = int.Parse(Console.ReadLine());
		//int mdc; //algoritmo de Euclides
		
		//double resto; //resto da divisao
		int r = 0; // resultado do alguritmo de Euclides
		
		//Calculo doalgoritmo de Euclides
		//Calcular o resto R da divisão inteira de A por B
		//Atribuir o valor de B ao A 
		//Atribuir o valor de R ao B
		
		if(b==0){
			Console.WriteLine("O MDC é" +" " + a);
		}else{
			while(b > 0 ) { //Se for para numeros pequenos (juntos) else basta. Mas para numeros maiores precisa-mos de fazer a conta varias vezes, assism usamos a funcção while
			r=b;
			b=a%b;
			a=r;
			}
			//Console.WriteLine("O MDC é" + a);
		}
		Console.WriteLine("O MDC é" +" " + a);
	}
	//-------------------------------------------------*/

/*Exercicio 2
long ce;// Graus em Celsius
long fah;//Graus em Fahrenheit

Console.WriteLine("Para converter insira os nume dos gaus em Celsius or Farenheit");
Console.WriteLine("Apenas escreva o que deseja converter, no restante coloque como 0");

Console.WriteLine("---------------------");

Console.WriteLine("Insira os graus em Celsius:");
ce = long.Parse(Console.ReadLine()); //variavel para guardar valor em Celsius
Console.WriteLine("---------------------");

Console.WriteLine("Insira os graus em Farenheit:");
fah = long.Parse(Console.ReadLine()); //variavel para guardar valor em Farenheit

long auxC = 5 / 9; //variavel auxiliar para Celsius
long auxF = 9 / 5; //variavel auxiliar para Farenheit

//Variavels de conversao auxiliares
long celsius;
long farenheit;

//Calculo de conversão de Fahrenheit para Celsius
if (fah > 0)
{
	celsius = (fah - 32) * auxC;
	Console.WriteLine("É de" + " " + celsius + " " + "Celsius");
}/*else if (ce > 0 ){
			farenheit = (ce*auxF)+32;
			Console.WriteLine("É de" + " " + farenheit + " " + "Farenheit");
		}*/

/* Exercicio 2 errado???
//Implemente uma função que faz a conversão de temperatura entre Fahrenheit e graus Celsius. 
//Faça todas as alterações propostas nos slides das aulas teóricas e verifique os resultados.
//Para converter Fahrenheit to Celsius, subtraia 32 e multiplique por 5/9

//inserir graus Celsius
Console.WriteLine("Insira a temperatura actual em graus Fahrenheit.");
double fahrenheit = double.Parse(Console.ReadLine()); //guardas o numero inserido com 2 casas decimais

double celsius ;

celsius = (fahrenheit - 32) * 0.55;
Console.WriteLine("Neste momento está" + celsius + "graus Celsius");
------------------------------------------------------------------------------------*/

/* Exercicio 3
// Escreva uma função que pede um número inteiro ao utilizador, testa se este é par ou impar e retorna o resultado.
Console.WriteLine("Insira um numero para verificar se é par ou impar");
int i = 0;
while(i == 0)
{
	int num = int.Parse(Console.ReadLine());
	int resto = 0;
	resto = num % 2;

	if (resto == 0)
	{
	Console.WriteLine("numero " + num + " é par.");
	}
	else
	{
	Console.WriteLine("numero " + num + " é impar.");
	}
}------------------------------------------------------------------------------------*/


/* Exercicio 4
//Insirir um ano e guardar na variavel
Console.WriteLine("Ver ano Bissexto");
float ano = int.Parse(Console.ReadLine());


if( ano % 4 ==0)
{
	if ( ano % 100 ==0)
	{
		if(ano % 400 == 0)
		{
			Console.WriteLine(" Bissexto");
		}else
		{
			Console.WriteLine("Não Bissexto");
		}
	}else 
	{
		Console.WriteLine("Bissexto");
	}
}else
{
	Console.WriteLine("Não Bissexto");
}------------------------------------------------------------------------------------*/


/* //Exercico 5	
int maximo = 0;
int minimo = 0;

int iteracao = 1;
Console.WriteLine("insira um valor");
int valor = 0;

while ( iteracao <= 10){
	valor = int.Parse(Console.ReadLine());
	Console.WriteLine("valor é" + valor);

	if ( iteracao == 1) //É necessario fazer set para ter um ground definido aprao minimo.
	{
		minimo = valor;
	}else //Caso o numero != 0, entao entra na condição de definir o maximo e minimo
	{
		if (valor >= maximo)
		{
			maximo = valor;
		}else 
		{
			minimo = valor;
		}
	}
	Console.WriteLine("O valor maximo é" + maximo);
	Console.WriteLine("O valor minimo é" + minimo);
	iteracao++;
}--------------------------------------------------------------*/

/*Exercicio 6
//Escreva uma função que devolve todos os números múltiplos de 19 entre 19 e 2000.


int iterador = 1; //variavel iterador para a funcao while

int numR = 19; //multiplicador parte da tabuada do 19
float result = 0;

int x = 0; // ver quantos numeros tem entre 19 e 2000
x = 2000 - 19;


while (iterador <= x) // colocar um limite no iterador 
{
	result = numR%19;

	if (result == 0) 
	{
	Console.WriteLine("Este número {0} é multiplo de 19.", numR);

	}
   // else
	//{
	 //   Console.WriteLine("Não existem mais multiplos de 19 entre 19 e 2000");
	//}
	//Console.WriteLine(iterador);
	numR++;
	iterador++;
}---------------------------------------------------------------------*/

/* Exercicio 7
// Escreva um programa que continue a pedir números ao utilizador até que ele insira um número negativo. Depois imprima a soma de todos os números inseridos.

double x = 0;
double soma; // Guarda o resultado da soma
double y = 0; //Guarda o ultimo numero inserido
int i = 0; //iterador

while (i >= 0)
{
	x = Convert.ToDouble(Console.ReadLine());
	if (x >= 0)
	{
		soma = y + x; //Faz a soma
		y = soma;
		Console.WriteLine("A soma é {0} e o valor inserido foi {1}", soma, x);
		i++;
	}
	else if (x < 0)
	{
		Console.WriteLine("A soma de {0} e {1} é {2}", y, x, y + x);
		i = -1;
	}

}
---------------------------------------------------------------------*/

//========================================== Extras e/ou correções ==================================
/*Exercicio 1
Pretende - se implementar uma função que utilize o algoritmo de Euclides para calcular o máximo divisor comum de dois números inteiros. 
O programa deve pedir ao utilizador para inserir os números e no final deve apresentar o resultado.
O algoritmo de Euclides para encontrar o MDC de quaisquer números inteiros A e B: 
Repetir:
Se B é zero, o MDC é A.
Caso contrário:
Atribuir o valor do B ao R (r=b)
Calcular o resto da divisão inteira de A por B e atribuir a B (b=a%b)
Atribuir o valor de R ao A (a=r)
Retornar A(=MDC);

//Inserir os dois numeros pedidos
Console.WriteLine("Insira o valor para a");
int a = int.Parse(Console.ReadLine()); //guarda o valor inserido em a

Console.WriteLine("Insira o valor para b");
int b = int.Parse(Console.ReadLine()); //guarda o valor inserido em b

double rx; //variaveil auxiliar

if (b == 0)
{
    Console.WriteLine("O MDC é" + a);
}
else
{
    b = rx;
    b = a % b;
    a = rx;
    
    Console.WriteLine("O MDC é" + a);
}
------------------------------------------------------------------------------------*/

/* Exercicio 2 errado???
//Implemente uma função que faz a conversão de temperatura entre Fahrenheit e graus Celsius. 
//Faça todas as alterações propostas nos slides das aulas teóricas e verifique os resultados.
//Para converter Fahrenheit to Celsius, subtraia 32 e multiplique por 5/9

//inserir graus Celsius
Console.WriteLine("Insira a temperatura actual em graus Fahrenheit.");
double fahrenheit = double.Parse(Console.ReadLine()); //guardas o numero inserido com 2 casas decimais

double celsius ;

celsius = (fahrenheit - 32) * (5/9);
Console.WriteLine("Neste momento está" + celsius + "graus Celsius");
------------------------------------------------------------------------------------*/


/* Exercicio 3
// Escreva uma função que pede um número inteiro ao utilizador, testa se este é par ou impar e retorna o resultado.
Console.WriteLine("Insira um numero para verificar se é par ou impar");
int i = 0;
while(i == 0)
{
    int num = int.Parse(Console.ReadLine());
    int resto = 0;
    resto = num % 2;

    if (resto == 0)
    {
        Console.WriteLine("numero " + num + " é par.");
    }
    else
    {
        Console.WriteLine("numero " + num + " é impar.");
    }
}------------------------------------------------------------------------------------*/


/*Exercicio 6
//Escreva uma função que devolve todos os números múltiplos de 19 entre 19 e 2000.


int iterador = 1; //variavel iterador para a funcao while

int numR = 19; //multiplicador parte da tabuada do 19
float result = 0;

int x = 0; // ver quantos numeros tem entre 19 e 2000
x = 2000 - 19;


while (iterador <= x) // colocar um limite no iterador 
{
    result = numR%19;

    if (result == 0) 
    {
        Console.WriteLine("Este número "+ numR + " é multiplo de 19.");
        
    }
    // else
    //{
    //   Console.WriteLine("Não existem mais multiplos de 19 entre 19 e 2000");
    //}
    //Console.WriteLine(iterador);
    numR++;
    iterador++;
}---------------------------------------------------------------------*/

/*EXERCÍCIO 8
Console.WriteLine("Bem-Vindo ao classificador de pessoas!"); 
Console.WriteLine("Caso nao queira participar coloque a sua idade a zero.");
				  
	string nome = "joao";
			int idade = 0;

			int idade_maxima = 0; //guardar a idade maxima
			int idade_minima = 0; //guardar a idade minima

			int i = 0; //iterador
			int soma=0;

			while (i >=0) 
			{
    				Console.WriteLine("Insira o nome da Pessoa: ");
    				nome = Console.ReadLine();
    				Console.WriteLine("Insira a idade da Pessoa: ");
    				idade = int.Parse(Console.ReadLine());
				
			string nome_Idade_Maxima; //guarda o nome da idade maxima
    		string nome_Idade_Minima; //guarda o nome da idade maxima
				
			if(idade == 0) 
    				{
					Console.WriteLine(nome + " não participa.");
				soma = i + soma; //tenho que somar é o iterador
					Console.WriteLine("Participaram " + soma + " pessoas.");
						break;
					}
    	
				if (i==0)
				{
				idade_minima = idade;
				}
				
				if (idade >= idade_maxima)
    				{
        				idade_maxima = idade; //guarda a idade maxima para depois ser comparada
        				nome_Idade_Maxima = nome; //Guarda o nome da pessoa com a idade maxima
        				Console.WriteLine("O {0} é o mais velho, com a idade de {1}.", nome_Idade_Maxima, idade_maxima);
        				i++;
    				}
    				else if (idade <= idade_minima) 
    				{
        				idade_minima = idade; //guarda a idade minima para depois ser comparada
       					nome_Idade_Minima = nome; //Guarda o nome da pessoa com a idade minima
        				Console.WriteLine("O {0} é o mais novo, com a idade de {1}.", nome_Idade_Minima, idade_minima);
        				i++;
    				}			
			}
}---------------------------------------------------------------------*/

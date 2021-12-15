﻿// See https://aka.ms/new-console-template for more information


//======================================= LAB 1 ===============================

/*Exercicio 1
Console.WriteLine("Hello World"); //Criação automática do programa 
//----------------------------------------*/


/*Exercicio 2
//criação de variais em double para mostrar caso tenha casas decimais
float a = 3.0f; //escrever a varial a=3 para poder osar nas operações em ver de calculo normal
float b = 7.0f; //escrever a varial b=7 para poder osar nas operações em ver de calculo normal
int c = 5; //escrever a varial c=5 para poder osar nas operações em ver de calculo normal

//verificação das variaveis
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine("-------------------");

//Inicio do calculo das operações aritméticas através da consola
//Console.WriteLine("Soma: a+b=" +  a+b);
//Console.WriteLine("Subtração: a menos b=" + a-b);
//Console.WriteLine("Multiplicação: a*b=" + a*b);
//Console.WriteLine("Divisão: a/b=" + a/b);
//Console.WriteLine("Quociente da divisao: a%b=" + a%b);
//Console.WriteLine("Soma e multiplicação: a+b*c" + a+b*c);
//Console.WriteLine("Soma e multiplicação fazendo a soma primeiro: (a+b)*c" + (a+b)*c );

//operação 1 (op1) Resultado 10
double op1 = a+b;
Console.WriteLine("Op1=" + op1);

//operação 2 (op2) Resultado 4
double op2 = b-a;
Console.WriteLine("Op2=" + op2);

//operação 3 (op3)Resultado 21
double op3 = a*b;
Console.WriteLine("Op3=" + op3);

//operação 4 (op4) Resultado da um numero inteiro se for usado como int no tipo de variaveis
float op4 = b/a;
Console.WriteLine("Op4=" + op4);

//operação 5 (op5) Resultado da numero decimal, devido ao uso de virgulas e serem floats ou double
double op5 = b/a;
Console.WriteLine("Op5=" + op5);

//operação 6 (op6) Resultado da o Quociente da divisão
double op6 = a%b;
Console.WriteLine("Op6=" + op6);

//operação 7 (op7) Resultado 38, multilicação feita primeiro 7*5=35 e somado a 3 (35+3=38)
double op7 = a+b*5;
Console.WriteLine("Op7=" + op7);

//operação 8 (op8) Resultado 50, perioridade da soma (7+3)=10 e seguido da multiplicação por 5 (10+5=50)
double op8 = (a+b)*c;
Console.WriteLine("Op8=" + op8); 
//---------------------------------------*/

/*Exercicio 3
//Criação de double (caso tenha casas decimais), colocar a introduzir numero (string) 
//e mudando o tipo string para double  atraves de operador de conversão.
double a = double.Parse(Console.ReadLine());

//imprimir o numero inserido
Console.WriteLine("O número inserido foi " + " " + a);

//Opereção da divisão por 2
double operacaoDivisao = a /2;

//imprimir o resultado da operação da divisao do numero inserido por 2
Console.WriteLine("O resultado do número inserido divido por 2 é " + " " + operacaoDivisao);
//---------------------------------------*/

/* Exercicio 4 
//variaveis de intruduzao de numeros inteiros
int n1;
int n2;
//resultado da soma de n1 com n2 = n3
int n3;

Console.WriteLine("Preencha os espaços com apenas Números inteiros:");
//set do numero inteiro n1 escrito pelo utilizador
Console.Write("Primeiro número(n1)");
n1 = int.Parse(Console.ReadLine());

//set do numero inteiro n2 escrito pelo utilizador
Console.Write("Segundo número(n2):");
n2 = int.Parse(Console.ReadLine());

//somatório dos numeros inteiros: n1 + n2 = n3
n3 = n1 + n2;
Console.WriteLine("A soma do primeiro número(n1) com o segundo numero(n2) é resultado de:" + " " + n3);
//---------------------------------------*/

/* Exercicios 5
//variaveis de intruduzao de numeros inteiros
double n1;
double n2;

Console.WriteLine("Preencha os espaços com apenas Números inteiros:");
//set do numero inteiro n1 escrito pelo utilizador
Console.Write("Primeiro número(n1)");
n1 = int.Parse(Console.ReadLine());

//set do numero inteiro n2 escrito pelo utilizador
Console.Write("Segundo número(n2):");
n2 = int.Parse(Console.ReadLine());

//variaveis auxiliares para contos
double r1;
double r2;
double r3;
double r4;
double r5;

//Resultado da Soma
r1 = n1 + n2;
Console.WriteLine("O resultado da Soma:" + r1);

//Resultado da Diferença
r2 = n1 - n2;
Console.WriteLine("O resultado da diferença:" + r2);

//Resultado da Produto
r3 = n1 * n2;
Console.WriteLine("O resultado do Produto:" + r3);

//Resultado da Quociente
r4 = n1 / n2;
Console.WriteLine("O resultado do Quociente:" + r4);

//Resultado da Resto da Divisão
r5 = n1 % n2;
Console.WriteLine("O resultado da Divisão:" + r5);
//---------------------------------------*/

/*Exercicio 6
//Pedir ao utilizador um raio de um circulo
double r1;
float Pi = 3.14f; //Maior precisão usar a funções Math.PI

Console.WriteLine("insira o raio do circulo");
r1 = long.Parse(Console.ReadLine());

//Variavels para os resultados
double area;
double volume;

//calculo da area
area = (r1 * r1) * Pi;
Console.WriteLine("Area do circulo é de" + " " + area);

//calculo do Volume
volume = ((Pi * (r1 * r1)) * (4 / 3) * (Pi * (r1 * r1 * r1))); //esta a dar errado
Console.WriteLine("Volume do circulo é de" + " " + volume);
//---------------------------------------*/

/*//Exercicio 7
string nome1 ;//Pergunta Priemeiro nome
Console.WriteLine("Qual o seu primeiro nome?");
nome1 = Console.ReadLine();

string nome2 ;//Pergunta ultimo nome
Console.WriteLine("Qual o seu ultimo nome?");
nome2 = Console.ReadLine();

int idade ;//Pergunta idade
Console.WriteLine("Qual a sua idade?");
idade = int.Parse(Console.ReadLine());

int anoNasc; //variavel apra colocar o ano como conta

//calculo da idade
anoNasc = 2021 - idade;

//Frase “Hi, nome1 nome2! Você nasceu em anoNasc”
Console.WriteLine("Hi,"+" "+nome1+"!"+" "+"Você Nasceu em"+" "+anoNasc);
//---------------------------------------*/

/*//Exercicio 8
//variaveis que posso ser aceites com casas decimais
double a; //variavel a
Console.Write("Insira o valor de a");

a = double.Parse(Console.ReadLine()); //Temos de conversao do Convert.ToDouble(Console.ReadLine()); //Pois double nao premite usar double.Parse(Console.ReadLine());

double b; //Variavel b
Console.Write("Insira o valor de a");
b = double.Parse(Console.ReadLine());
double resultado; //Resultado

//calculo de (a * a + b * b + 2 * a *b)
resultado = (a * a + b * b + 2 * a *b);
Console.WriteLine("O resultado de (a * a + b * b + 2 * a *b) é de"+" "+resultado);
//---------------------------------------*/

/*//Exercicio 9
// Area do triangulo é dada por (b * h)/2
Console.WriteLine("Valor da base do triangulo");
double b; //variavel com valor da base
b = double.Parse(Console.ReadLine());

Console.WriteLine("Valor da altura do triangulo");
double h; //variavel com valor da base
h = double.Parse(Console.ReadLine());

double areaTotal; //Area total do triangulo (b * h)/2
areaTotal = (b * h)/2;
Console.WriteLine("A area total do triangulo é de"+" "+areaTotal);
//---------------------------------------*/

/*//Exercicio 10
double aulas; //numero de aulas
double faltas; //numero de faltas
double PFaltas; //Numero de faltas

//escrever o numero de aulas
Console.WriteLine("indique o numero total de aulas.");
aulas = double.Parse(Console.ReadLine());

//Numero de faltas
Console.WriteLine("Quantas aulas faltou?");
faltas = double.Parse(Console.ReadLine());

//Calculo do numero de faltas possiveis
PFaltas = aulas * 0.9;
Console.WriteLine("Numero de faltas possiveis de faltar"+ " "+ PFaltas);

//Calculo de restantes faltas
//Console.WriteLine("Tem"+" "+ (PFaltas - faltas)+" "+ " faltas disponiveis! Have fun! :)");
//---------------------------------------*/

/*//Exercicio 11
int a; //intrevalo de numero menor, com numeros inteiros
int b; //intrevalo de numero maior	

//definir os intrevalos
Console.WriteLine("Insina um intrevalo de 5 numeros. Um numero Menor e Um numero Maior respectivamente");
a = int.Parse(Console.ReadLine()); //insere o numero menor do intrevalo
b = int.Parse(Console.ReadLine()); //insere o numero maio do intrevalo

int inc; //variavel que contem cada numero dentro do intrevalo
inc = a; //Inicia-se igual ao numero menor do intrevalo
int aux; //Variavel  para conter o valor da conta auxiliar

while (inc <= b){ //inc é o intrevalo entre (a,b), inicialmente sendo igual ao numero menor a, incrementando inc+1 até ser <= b (numero maior)
	aux = inc%5;
	if(aux == 0){//Se a divisao dá resto Zero, imprime o numero
		Console.WriteLine("numero divisivel " +inc);
	}
	inc++; //incrementa +1 ao inc
}
//----------------------------------------------------*/

/*//Exercicio 12
float a; //inserir um numero
a = float.Parse(Console.ReadLine());
float x;
x = a%2;

if (x==0){
	Console.WriteLine("É Par!");
}
else {
	Console.WriteLine("É impar!");
}
//----------------------------------------------------*/

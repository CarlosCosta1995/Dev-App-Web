﻿// See https://aka.ms/new-console-template for more information


//======================================= LAB 3 ===============================


/*Exercicio 1
//Escreva um programa que pede ao utilizador para inserir o nome e idade dos seus amigos (número definido pelo utilizador)
//e apresenta quem é o mais velho e quem é mais novo.

string nome = "joao";
int idade = 0;

int idade_maxima = 0; //guardar a idade maxima
int idade_minima = 0; //guardar a idade minima

int i = 0; //iterador

while (i >=0) 
{
    Console.WriteLine("Bem-Vindo ao classificador de pessoas! Caso nao queira participar coloque a sua idade a zero.");

    Console.WriteLine("Insira o nome da Pessoa: ");
    nome = Console.ReadLine();
    Console.WriteLine("Insira a idade da Pessoa: ");
    idade = int.Parse(Console.ReadLine());
    string nome_Idade_Maxima; //guarda o nome da idade maxima
    string nome_Idade_Minima; //guarda o nome da idade maxima


    if (i == 0) 
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
        Console.WriteLine("O {0} é o mais novo, com a idade de {1}.", nome_Idade_Minima, idade_maxima);
        i++;
    }
    if(idade == 0) 
    {
        i = -1; 
    }
    
}*/

//-----------------------------------------------------------------------------//

/* Exercicio 2
//Complemente o programa anterior para ter em conta o mês de nascimento no cálculo.

string nome = "joao";
int idade = 0;
int mes = 0;

int idade_maxima = 0; //guardar a idade maxima
int idade_minima = 0; //guardar a idade minima

int mes_maxima = 0; //guardar a idade maxima
int mes_minima = 0; //guardar a idade minima

int i = 0; //iterador



while (i >= 0)
{
    Console.WriteLine("Bem-Vindo ao classificador de pessoas! Caso nao queira participar coloque a sua idade a zero.");

    Console.WriteLine("Insira o nome da Pessoa: ");
    nome = Console.ReadLine();
    Console.WriteLine("Insira a idade da Pessoa: ");
    idade = int.Parse(Console.ReadLine());
    Console.WriteLine("Insira o Mês de nascimento;");
    mes = int.Parse(Console.ReadLine());

    string nome_Idade_Maxima; //guarda o nome da idade maxima
    string nome_Idade_Minima; //guarda o nome da idade maxima

    int mes_Idade_Maxima; //guarda o mes da idade maxima
    int mes_Idade_Minima; //guarda o mes da idade maxima

    if (i == 0)
    {
        idade_minima = idade;
    }

    if (idade >= idade_maxima)
    {
        idade_maxima = idade; //guarda a idade maxima para depois ser comparada
        nome_Idade_Maxima = nome; //Guarda o nome da pessoa com a idade maxima
        mes_Idade_Maxima = mes; //Guarda o mes da pessoa com idade minima
        Console.WriteLine("O {0} é o mais velho, com a idade de {1}.Nascido no mês {2}", nome_Idade_Maxima, idade_maxima, mes_Idade_Maxima);
        i++;
    }
    else if (idade <= idade_minima)
    {
        idade_minima = idade; //guarda a idade minima para depois ser comparada
        nome_Idade_Minima = nome; //Guarda o nome da pessoa com a idade minima
        mes_Idade_Minima = mes; //Guarda o mes da pessoa com idade minima
        Console.WriteLine("O {0} é o mais novo, com a idade de {1}.Nascido no mês {2}", nome_Idade_Minima, idade_maxima, mes_Idade_Minima);
        i++;
    }
    if (idade == 0)
    {
        i = -1;
    }
}*/

//-----------------------------------------------------------------------------//

/* Exercicio 3
//Escreva um programa que peça a um utilizador para inserir o número de elementos da turma.
//Peça ao utilizador para introduzir a idade dos mesmos e imprima a média de idade da turma
 
int numero_elemento = 0; //Guardar o numero de elementos da turma
int idade = 0; //guarda as idades inseridas
int idade_1 = 0; //guarda a primeira idade
int soma_idades = 0; //A soma de todas as idades
double media_idades; //Faz a media das idades

int i = 0; //iterador

while(i >= 0)
{
    if (i == 0)
    {
        Console.WriteLine("Intruduza o numero de elementos que compoem a turma: ");
        numero_elemento = int.Parse(Console.ReadLine());

        //Precisamos de guardar a primeira idade e fazer a soma apra ter 20 elementos no total
        Console.WriteLine("Introduza a idade"); 
        idade_1 = int.Parse(Console.ReadLine());

        soma_idades = idade_1;
        i++;
    }
	
    Console.WriteLine("Introduza a idade");
    idade = int.Parse(Console.ReadLine());

    if (i <= numero_elemento)
    {
        soma_idades = soma_idades + idade;
        i++;
    }
    if (i == numero_elemento)
    {
        media_idades = soma_idades / numero_elemento;
        Console.WriteLine("A média de idades dos {0} é de {1}.", numero_elemento, media_idades);
        i = -1;
    }
}*/

//-----------------------------------------------------------------------------//

/* Exercicio 4
//Escreva um programa que peça ao utilizador para inserir a nota (de 0 a 20)
//de 30 alunos de uma turma e imprime qual é a nota mais baixa, a nota mais
//alta e a média das notas atribuídas.

int alunosTurma = 30; //numero maximo de alunos
int i = 0;

float notaMin = 0;
float notaMax = 0;
float soma = 0;
float media = 0;

 //float nota = float.Parse(Console.ReadLine());//verificação

while (i <= alunosTurma)
{
    //pedido de introdução e atribuição da nota
    Console.WriteLine("Escreve a nota"); 
    float nota = float.Parse(Console.ReadLine());

    // Verifica quantas vezes é feita a incrementação automatica == 30
    // nota++;
    // Console.WriteLine(nota);

    
    if (nota >=0 && nota <= 20) // operador para verificar se as notas estao entre os 0 e 20 valores (aceita 2 casas decimais e nao mais que isso!)
    {
        if (i == 0)// operador para inicializar o while loop operator
        {
            notaMin = nota;
            Console.WriteLine("Nota minima é" + notaMin);
            i++;
        }
        else if (nota >= 0 && nota <= notaMin) //operador para nota minima
        {
            notaMin = nota;
            Console.WriteLine("Nota minima é" + notaMin);
            i++;
        }
        else if (nota >= 0 && nota >= notaMax) //operador paranota maxima
        {
            notaMax = nota;
            Console.WriteLine("Nota maxima é" + notaMax);
            i++;
        }
        else if (nota >= 0 && nota >= notaMin && nota <= notaMax) //operador para se uma nota é maior que notaMin e menor notaMax. Continua a contar na soma e media
        {
            Console.WriteLine("A sua nota foi {0}, mas esta entre a minima de {1} e a maxima de {2}", nota, notaMin, notaMax);
            i++;
        }

        // Faz a soma e a media das notas
        soma = soma + nota;
        Console.WriteLine("A soma total é " + soma);
        media = soma / alunosTurma;
        Console.WriteLine("A media foi " + media);

        //Imprime a nota minima e maxima
        Console.WriteLine("A nota minima foi {0} e a maxima foi {1}", notaMin, notaMax);

    }
    else { Console.WriteLine("Nota Invalida! Notas são entre 0 a 20 valores."); break; } //operador para invalidar notas negativas e/ou maiores que 20 valores
}*/
//-----------------------------------------------------------------------------//

/* Exercicio 5
//Escreva um programa que peça ao utilizador x números e calcule quantos
//valores são menores de 10 e quantos são maiores que 15.

int numberPut = 0; //Asks the user to write a number
int numberQuantity = 0; //Quantifies the numbers introduced

int numbersUnder10 = 0; //Quantifies all numbers under 10
int numberOver15 = 0;  //Quantifies all numbers over 15

do 
{
    Console.WriteLine("Write a number!");
    numberPut = int.Parse(Console.ReadLine());
    numberQuantity++;

    if (numberPut <= 10) { numbersUnder10++; Console.WriteLine("Numbers written under nor igual to 10 is {0}", numbersUnder10); }
    else if (numberPut >= 15) { numberOver15++; Console.WriteLine("Numbers written over nor igual to 15 is {0}", numberOver15); }
    else {Console.WriteLine("Number btween the range of 10 to 15. The number was {0}", numberPut); break;}

} while (numberQuantity >= 0); */
//-----------------------------------------------------------------------------//

/*Exercicio 6
//Escreva um programa que peça a um utilizador um número e imprima a
//tabuada do mesmo

Console.WriteLine("Intruduz um numero para fazer a tabuada do mesmo.");
int number = int.Parse(Console.ReadLine());
int numberT = 1;
int result = 0;

for (int i = 0;  i <= numberT; i++) 
{
    result = numberT * number;
    Console.WriteLine("{0} * {1} = {2}",numberT, number, result);
    numberT++;
}*/
//PS: O programa só para quando faltar a memória, pois o problema nao especifica quando fazer a paragem!
//-----------------------------------------------------------------------------/

/*Exercicio 7
//Escreva um programa que peça ao utilizador 20 números e conte quantos
//desses números são ímpar e que imprima a soma dos valores pares
//encontrados.

int number = 0;

int numberQuantity = 0;
int oddNumber = 0; //Numeros impar
int evenNumber = 0;//Numeros pares

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("Introduza um numero até ao maximo de 20. Quantidade introduzida é {0}", numberQuantity);
    number = int.Parse(Console.ReadLine()); //Escreve os numeros

    int result = number % 2;
    //Console.WriteLine("\n" + result); 

    if (result == 0) { evenNumber++;} //Quantifica os numeros impares
    else if (result > 0) { oddNumber++; } //Quantifica os numeros pares

    //Console.Write("\n {0} foi impar. Imar = {1}", number, evenNumber);
    //Console.Write("\n {0} foi par. Par = {1}", number, oddNumber);

    numberQuantity++;
    number++;
}
Console.WriteLine("\n {0} dos 20 numeros introduzidos são {1} numeros pares e {2} numeros impares.", numberQuantity, evenNumber, oddNumber);*/
//-----------------------------------------------------------------------------/

//Exercicio 8
//Um funcionário de uma empresa recebe aumento salarial anualmente.
//Sabemos que: a) esse funcionário foi contratado em 1995, com salário inicial
//de$ 1.000,00; b) em 1996, recebeu aumento de 1,5% sobre seu salário
//inicial; c) a partir de 1997 (inclusive), os aumentos salariais sempre
//corresponderam ao dobro do percentual do ano anterior. Faça um programa
//que determine o salário desse funcionário até o ano 2000.

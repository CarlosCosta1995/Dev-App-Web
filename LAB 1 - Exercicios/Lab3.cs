// See https://aka.ms/new-console-template for more information


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

// Exercicio 4
//Escreva um programa que peça ao utilizador para inserir a nota (de 0 a 20)
//de 30 alunos de uma turma e imprime qual é a nota mais baixa, a nota mais
//alta e a média das notas atribuídas.

Console.WriteLine("Insira uma nota:");
int nota = 0;

int numeroAlunos = 30;

int notaMax = 0;
int notaMin = 0;

int iterador = 0;

while (iterador <= numeroAlunos)
{
    nota = int.Parse(Console.ReadLine());

    if (iterador == 0 && nota >= 0 && nota <= 20)
    {
        notaMin = nota;
        Console.WriteLine(" Nota minima {0}", notaMin);
        iterador++;
    }
    if (iterador > 0 && nota > notaMax && nota >= 0 && nota <= 20)
    {
        notaMax = nota;
        Console.WriteLine(" Nota maxima {0}", notaMax);
        iterador++;
    }
    if (iterador > 0 && nota < notaMin && nota >= 0 && nota <= 20)
    {
        notaMin = nota;
        Console.WriteLine(" Nota minima {0}", notaMin);
        iterador++;
    }
    if (nota < 0 && nota > 20)
    {
        Console.WriteLine("Nota invalida, apenas podem ser valores inteiros entre 0 a 20.\n Nota inserida {0}", nota);
        break;
    }
}
// See https://aka.ms/new-console-template for more information

//======================================= LAB 3 ===============================//

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

/*Exercicio 8
//Um funcionário de uma empresa recebe aumento salarial anualmente.
//Sabemos que: a) esse funcionário foi contratado em 1995, com salário inicial
//de$ 1.000,00; b) em 1996, recebeu aumento de 1,5% sobre seu salário
//inicial; c) a partir de 1997 (inclusive), os aumentos salariais sempre
//corresponderam ao dobro do percentual do ano anterior. Faça um programa
//que determine o salário desse funcionário até o ano 2000.

int year = 0;
double inicialSalary = 1000;
char dolars = '$';
float raiseBefore1996 = 1.5f; // 1.5% == 15/10
float raiseAfter1996 = 2.0f;
double salary = 0;

Console.WriteLine("Escreva o Ano em que começou a trabalhar");
year = int.Parse(Console.ReadLine());

salary = inicialSalary;

do 
{
    if (year == 1995)
    {
        salary = inicialSalary;
        Console.WriteLine("Your salary in the year {0} was {1} {2}", year, inicialSalary, dolars);
    }
   else if (year <= 1996) 
   {
        salary = salary * raiseBefore1996;
        Console.WriteLine("Your salary in the year {0} was {1} {2}", year, salary, dolars);
   }
   else if (year >= 1997) 
   {
        salary = salary * raiseAfter1996;
        Console.WriteLine("Your salary in the year {0} was {1} {2}", year, salary, dolars);
    }

    year++;

}while (year <= 2000);*/
//-----------------------------------------------------------------------------/

/*Exercicio 9
//Escreva um programa que peça ao utilizador para inserir um valor e imprima
//todos os números ímpares menores que esse número e maiores que 1.

Console.WriteLine("Insert a number over 1.");
int number = int.Parse(Console.ReadLine());
int numberMaxRange = number;

do
{
    if (number % 2 != 0) 
    {
        Console.Write("\n All odd numbers between 1 and {0} are {1}", numberMaxRange, number);
    }
    number--;
} while (number > 1 && number <= numberMaxRange);*/
//-----------------------------------------------------------------------------/

/*Exercicio 10
//Escreva um programa que solicite dois números inteiros ao utilizador e
//apresente como resultado o dobro desses números, que devem ser somados
//e o resultado dessa soma ser triplicado.

int number1 = int.Parse(Console.ReadLine());//ask the user for a first number
int number2 = int.Parse(Console.ReadLine());//ask the user for a second number

double result = 0; //Stores the result

result = ((number1 * 2) + (number2 * 2)) * 3;

Console.WriteLine("The result is {0}", result);*/
//-----------------------------------------------------------------------------/

/*Exercicio 11
//Escreva um programa que peça ao utilizador um número inteiro e que
//apresenta o cubo dos números até esse valor
//a. Exemplo:
//b.Entrada: 5
//c.Resultado:
//d.O número é: 1 e o cubo do 1 é: 1
//e.O número é: 2 e o cubo dos 2 é: 8
//f.O número é: 3 e o cubo dos 3 é: 27

Console.WriteLine("Insira um numero inteiro para fazer o cubo do mesmo.");

int number = int.Parse(Console.ReadLine());

Console.WriteLine("O número é: {0} e o cubo de {0} é " + number * number * number, number); */
//-----------------------------------------------------------------------------/

/*Exercicio 12
//Crie um programa que imprima todos os números entre 20 e 40 por ordem
//decrescente e a cada dois valores (e.g., 40, 38, 36, ..)

int number = 40;

do
{
    Console.WriteLine(" " + number);
    number--;
    number--;

} while (number >= 20 && number <= 40);*/
//-----------------------------------------------------------------------------/

/*Exercicio 13
//Crie um programa que peça ao utilizador x número maior que 20 e imprima
//uma árvore de natal com esse número de asteriscos

Console.WriteLine("Escreva o Numero de estrelas entre 1 e 60.");
int estrelas = int.Parse(Console.ReadLine());
//int estrelas = 2;
//int espaco = estrelas * 2 + 1;

//tentativa 1 == Tem um buraco em cima
/*for (int i = 1; i <= espaco;)
{
    estrelas++;
    for (int a = 1; a < espaco; a++) //Cria os espaços iniciais multiplicado pelo numero das estrelas para ficar mais longe da borda.
    {
        Console.Write(" ");
    }
    for (int b = 1; b <= estrelas; b++) //Depois dos espaços criam-se as estrelas
    {
        Console.Write("*");
    }
    Console.WriteLine(); //Para que cada loop comece numa nova linha
    //estrelas++;
    estrelas++;
    espaco--;
    }
}*/

/*tentativa 2 == Full tree!
    for (int i = 1; i <= estrelas; i++) //A Condição acaba quando o numero do iterador é igual ao numero das estrelas
    {
        for (int a = 1; a < (estrelas - i); a++) //Cria os espaços diminuindo o numero para ficar mais perto da borda esquerda.
        {
            Console.Write(" ");
        }
        for (int b = 1; b < (i * 2); b++) //Depois dos espaços criam-se as estrelas. Multiplico o i para dar o dobro das estrelas em cada linha
        {
            Console.Write("*");
        }
        Console.WriteLine(); //Para que cada loop comece numa nova linha
        //estrelas++;
        //estrelas++;
        //espaco--;
    }*/
//-----------------------------------------------------------------------------/

//Exercicio 14
//Crie um programa que peça ao utilizador para inserir um número e imprima
//o padrão de meio triangulo, em que cada linha é representada pelo mesmo
//número. Exemplo:
//1
//22
//333
//444
//5555
//66666

Console.WriteLine("Escreva um numero");
int number = int.Parse(Console.ReadLine());
int i = 0;

while (i >= 0) 
{
    for (int a = 0; a >= 0; a++) 
    {
        Console.WriteLine(number+1);
        a++;
    }  
    i++;
}
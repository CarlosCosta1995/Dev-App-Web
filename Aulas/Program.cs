// See https://aka.ms/new-console-template for more information
//============================= Desenvolvimentos de aplicaçoes web_RQ_Aula1 ===============================
/*
Inserir Nome
string Name = Carlos;
Console.WriteLine(Name);


string sabeAndar = Sabe andar de bicicleta TF + console.ReadLine();
bool andarBicicleta(sabeAndar);


Console.WriteLine(Sabe andar de bicicleta TF);
bool sabeAndar = false; bool só aceita valores true or false
		Console.WriteLine(A resposta foi  + sabeAndar);


String nome = Carlos;
string apelido = Costa;
int idade = 26;
char genero = 'm';
long numeroF = 12345678912542; tambem pode ser string, Long para numeros grandes
		Console.WriteLine ( Nome  + nome);
Console.WriteLine(Apelido + apelido);
Console.WriteLine(Idade + idade);
Console.WriteLine(Genero + genero);
Console.WriteLine(Número de funcionario + numeroF);
Console.WriteLine(Nome + nome + +Apelido + apelido + +Idade + idade + +Genero + genero + +Número de funcionario + numeroF);

================================================================================================================================*/

//============================= Exercicio da Aula 1 ===============================
/*
	//Declare uma variável andarBicicleta do tipo bool e atribua um valor
	//dependendo se você sabe ou não andar de bicicleta.

	//Declaração de variaveis

	//Pergunta
	Console.WriteLine("Gostas de andar de bicicleta? escreva a sua resposta como true ou false.");

	//Declaraçao da variavel e verificação da resposta
	bool andarBicicleta = bool.Parse(Console.ReadLine());
	Console.WriteLine(andarBicicleta);

	//Diferentes outputs para cada uma das respostas
	if (andarBicicleta == true)
	{
		Console.WriteLine("Sim eu ando de Bicicleta!");
	}
	else
	{
		Console.WriteLine("Não consigo e nem sei andar de Bicicleta");
	};
//------------------------------------------------------------------------------------------------
	//Uma empresa que lida com marketing deseja manter um registro de dados de
	//seus funcionários. Cada registro deve ter as seguintes características - nome,
	//apelido, idade, género ('m' ou 'f') e número de funcionário exclusivo (27560000
	//a 27569999). Declare as variáveis apropriadas para manter as informações de
	//um funcionário usando os tipos de dados e nomes apropriados.

	Console.WriteLine("Qual o seu nome?");
	string nome = Console.ReadLine();

	Console.WriteLine("Qual o seu apelido?");
	string apelido = Console.ReadLine();

	Console.WriteLine("Qual a sua idade?");
	int idade = int.Parse(Console.ReadLine());

	Console.WriteLine("Género? Responda com m ou f");
	char genero = char.Parse(Console.ReadLine());

	Console.WriteLine("Foi lhe atribuído o seguint número de funcionário 25589413");
	long numeroF = 25589413;

	Console.WriteLine("Verifique se os seu dados estão correctos");
	Console.WriteLine("Nome" + " " + nome + " " + "Apelido" + " " + apelido + " " + "Idade" + " " + idade + " " + "Género" + " " + genero + " " + "Número de Funcionário" + " " + numeroF);

//------------------------------------------------------------------------------------------------
	//Declare duas variáveis do tipo int, por exemplo a e b. Atribua os valores 5 e 10,
	//respetivamente. Troque seus valores de forma a que as variáveis tenham os
	//valores uma da outra.

	//declaração das variaveis a=5 e b =10
	int a = 5;
	int b = 10;
	int c;

	//vericar as variaveis
	Console.WriteLine("Variavel inicial de a = " + a);
	Console.WriteLine("Variavel inicial de b = " + b);

	//inversão da variaveis
	c = a;
	a = b;
	b = c;

	//Verificar a inversão das variaveis
	Console.WriteLine("Variavel em a = " + a);
	Console.WriteLine("Variavel em b = " + b);
================================================================================================================================*/

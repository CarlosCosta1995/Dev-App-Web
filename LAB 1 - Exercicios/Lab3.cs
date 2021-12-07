// See https://aka.ms/new-console-template for more information


//======================================= LAB 3 ===============================

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

			/*Exercicio 8
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
    
			}------------------------------------------------------------------*/

			/* Exercicio 9
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
			}-----------------------------------------------------------------------------*/

			/* Exercicio 10
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
			}-----------------------------------------------------------------------------*/

			// Exercicio 11
			//Escreva um programa que peça ao utilizador para inserir a nota (de 0 a 20)
			//de 30 alunos de uma turma e imprime qual é a nota mais baixa, a nota mais
			//alta e a média das notas atribuídas.


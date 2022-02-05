// See https://aka.ms/new-console-template for more information

//===============================  EX 1   ====================================== 
/* Escreva uma função que permite a inserção de notas de uma turma com n alunos, n<30. 
 * Utilize as funções já existentes para a inserção de dados no array.
 * Implemente a função void resultados(float notas[], int tamanho); que 
 * apresenta a saída deste modo: Houve exc alunos que tiveram nota superior ou
 * igual a 18, mb com nota entre 15 e 18, b com nota entre 12 e 15, s com nota
 * entre 10 e 12 e rep que reprovaram. , onde exc, mb, b, s e rep devem ser
 * substituídos por valores correspondentes. Por fim, deve apresentar a média das
 * notas (com 2 casas decimais; usar função existente) e o número de alunos que
 * tiveram nota acima da média : int acimaDaMedia(float notas[], int tamanho,
 * float media);).*/
/*
int numeroAlunos = 30;
float[] notasAlunos = new float[numeroAlunos];
float notaInserida;

float notasMaior18 = new float();
float notas15e18 = new float();
float notas12e15 = new float();
float notas10e12 = new float();
float notasMenores10 = new float();

void inserirNotas(float nota , int index)
{
        notasAlunos[index] = nota;
}

void verificarArray()
{ 
    for(int i = 0;i < numeroAlunos;i++)
    {
        Console.WriteLine("Nota do aluno numero {0} foi de {1}", i, notasAlunos[i]);
    }
}


void resultados(float[] notas, int tamanho)
{
    float nota = new float();
    for(int i = 0; i < tamanho; i++)
    {
        nota = notas[i];    
        if (nota >= 0 && nota < 10)
        {
            notasMenores10++;
        }
        else if (nota >= 10 && nota < 12)
        {
            notas10e12++;
        }
        else if (nota >= 12 && nota < 15)
        {
            notas12e15++;
        }
        else if (nota >= 15 && nota < 18)
        {
            notas15e18++;
        }
        else
        {
            notasMaior18++;
        }
    }
    Console.WriteLine("\nHouve {0} alunos que tiveram nota superior ou igual a 18, {1} com nota entre 15 e 18, {2} com nota entre 12 e 15, {3} com nota entre 10 e 12 e {4} que reprovaram.", notasMaior18, notas15e18, notas12e15, notas10e12, notasMenores10);
}

float calcularMedia(float[] notas) => (float)Math.Floor(notas.Average());

int acimaDaMedia(float[] notas, int tamanho, float media) 
{
    int acimaDaMedia = new int();
    for (int i = 0; i < tamanho; i++)
    {
        if (notas[i] >= media)
        {
            acimaDaMedia++;
        }
    }
    return acimaDaMedia;
}

if (notasAlunos.Length <= numeroAlunos)
{
    for (int i = 0; i < numeroAlunos; i++)
    {
        Console.WriteLine("Insira a nota do Aluno");
        Console.WriteLine("->");
        notaInserida = i; // notaInserida = float.Parse(Console.ReadLine());
        Console.WriteLine(notaInserida);
        inserirNotas(notaInserida, i);
    }
    //Console.WriteLine("Todas as notas foram inseridas com sucesso!" + "Array lenght:" + notasAlunos.Length);
    //verificarArray();
}

resultados(notasAlunos, numeroAlunos);
Console.WriteLine("A média da turma é de {0} e o número de alunos com nota acima da média foi de {1}.", calcularMedia(notasAlunos), acimaDaMedia(notasAlunos, numeroAlunos, calcularMedia(notasAlunos)));
*/

//===============================  EX 2   ====================================== 
/* Um treinador de atletismo treina 5 atletas e faz 7 sessões de treino por semana.
 * Em cada sessão, cada atleta percorre uma distância que é cronometrada. 
 * Os valores dos tempos, em segundos, são registrados sob a forma de uma matriz,
 * onde cada linha identifica um atleta e cada coluna uma sessão de treino. Escreva
 * um programa para:
 *  a. calcular e escrever a média dos tempos realizados em cada sessão de treinos;
 *  b. determinar e escrever o melhor tempo realizado por cada um dos atletas nas 7 sessões.
 * Implemente as seguintes funções: 
 * - void leMatriz (float[][] tempos, int atletas,int sessoes); para inserir os tempos; 
 * - void escreveMediaColunas(float[][] tempos, int atletas, int sessoes); para calcular e escrever na consola a 
 * média dos tempos em cada sessão de treinos;
 * - void escreveMinLinhas(float[][] tempos, int atletas, int sessoes); para calcular e escrever na consola o
 * melhor tempo realizado por cada um dos atletas. */

int numeroAtletas = 5;
int numeroSessoes = 7;
float[][] Tempos = new float[numeroAtletas][];
float[][] TemposMediosPorSessao = new float[numeroSessoes][];

void leMatriz(float[][] temposAtleta, int atletas,int sessoes)
{
    for (int i = 0; i < temposAtleta.Length; i++)
    {
        for (int j = 0; j < temposAtleta[i].Length; j++)
        {
            temposAtleta[i][j] = j;
            Console.WriteLine(temposAtleta[i][j]);
        }
    }
}

void escreveMediaColunas(float[][] temposSessao, int atletas, int sessoes)
{

}

void escreveMinLinhas(float[][] tempos, int atletas, int sessoes)
{

}


//===============================  EX 3   ======================================
/*Escreva um programa que permite a inserção de números em dois arrays, a e b,
com n elementos (n<=20). O programa deve criar um novo array c, tal que c[i] =
a[i] + b[i], para cada i entre 0 e n-1.*/
/*
int[] a = new int[20];
int[] b = new int[20];
int[] c = new int[20];

for (int i = 0; i < a.Length; i++)
{
    a[i] = i;
    Console.WriteLine("Valor a:{0} para index:{1}", a[i], i);
}

Console.WriteLine();

for (int i = 0; i < b.Length; i++)
{
    b[i] = i+2;
    Console.WriteLine("Valor b:{0} para index:{1}", b[i], i);
}

Console.WriteLine();

for (int i = 0; i < c.Length; i++)
{
    c[i] = a[i] + b[i];
    Console.WriteLine("Valor c:{0} para index:{1}", c[i], i);
}
*/

//===============================  EX 4   ======================================
/*Escreva um programa que permite a inserção de números em dois arrays, a e b,
com n elementos (n<30). O programa deve calcular e escrever o produto escalar
dos dois arrays (Dica: Dados os arrays a=(a1,a2,a3,…,an) e b=(b1,b2,b3,…,bn), o
produto escalar S é S=a1b1+a2b2+a3b3+…+anbn). Teste com n=5; a={5,2,4,7,3},
b={9,3,5,7,14} (resultado S=162) e n=4; a={-2,3,6,4}, b={2,1,-3,0} (resultado S=-19).*/

/*
int[] a1 = { 5, 2, 4, 7, 3 };
int[] a2 = { -2, 3, 6, 4 };

int[] b1 = { 9, 3, 5, 7, 14 };
int[] b2 = { 2, 1, -3, 0 };

double ProdutoEscalar(int[] a, int[] b, int n)
{
    double[] produtoEscalar = new double[30];
    double Producto = new double();
    for (int i = 0; i < n; i++)
    {
        produtoEscalar[i] = a[i] * b[i];
        Producto += produtoEscalar[i];
        Console.WriteLine("producto{0}, a:{1}, b:{2}, total:{3}", produtoEscalar[i], a[i], b[i], Producto);
    }
    return Producto;
}

//int n = int.Parse(Console.ReadLine());
Console.WriteLine("162 == {0}", ProdutoEscalar(a1, b1, 5));
Console.WriteLine("-19 == {0}", ProdutoEscalar(a2, b2, 4));*/
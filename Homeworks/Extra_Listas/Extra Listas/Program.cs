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
        }
        
    }
}

void escreveMediaColunas(float[][] temposSessao, int atletas, int sessoes)
{

}

void escreveMinLinhas(float[][] tempos, int atletas, int sessoes)
{

}
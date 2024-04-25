int qtdLinhas = 0, qtdColunas = 0, operacao = 0, inicio = 0, final = 0;

void EscolherDimensao(int tamanhoLinha, int tamanhoColuna)
{
    Console.Write("Digite quantas linhas você quer: ");
    tamanhoLinha = int.Parse(Console.ReadLine());
    Console.Write("Digite quantas colunas você quer: ");
    tamanhoColuna = int.Parse(Console.ReadLine());

    qtdLinhas = tamanhoLinha;
    qtdColunas = tamanhoColuna;
}

EscolherDimensao(qtdLinhas, qtdColunas);

double[,] matriz1 = new double[qtdLinhas, qtdColunas];
double[,] matriz2 = new double[qtdLinhas, qtdColunas];
double[,] matriz3 = new double[qtdLinhas, qtdColunas];

double[,] CriarMatriz(double[,] matriz, int i, int f)
{
    Console.Write("\nDigite a partir de qual número será gerado o aleatório: ");
    i = int.Parse(Console.ReadLine());
    Console.Write("Digite até qual número será gerado o aleatório: ");
    f = int.Parse(Console.ReadLine());

    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            matriz[linha, coluna] = new Random().Next(i, f);
        }
    }
    inicio = i;
    final = i;
    return matriz;
}
void ImprimirMatriz(double[,] matriz, string titulo)
{
    Console.WriteLine();
    Console.WriteLine(titulo);
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            Console.Write(matriz[linha, coluna] + " ");
        }
    }
}

void SomarMatriz(double[,] matriz1, double[,] matriz2)
{
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
        }
    }
    ImprimirMatriz(matriz3, "Resultado adição");
}

void SubtrairMatriz(double[,] matriz1, double[,] matriz2)
{
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
        }
    }
    ImprimirMatriz(matriz3, "Resultado subtração");
}

void MultiplicarMatriz(double[,] matriz1, double[,] matriz2)
{
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
        }
    }
    ImprimirMatriz(matriz3, "Resultado multiplicação");
}

void DividirMatriz(double[,] matriz1, double[,] matriz2)
{
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            if (matriz2[linha, coluna] != 0)
            {
                matriz3[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
            }
            else
            {
                matriz3[linha, coluna] = double.NaN;
            }
        }
    }
    ImprimirMatriz(matriz3, "Resultado divisão");
}

int EscolherOperacao()
{
    Console.Write("\nDigite: 1 - Adicao | 2 - Subtracao | 3 - Multiplicacao | 4 - Divisao: ");
    int opcao = int.Parse(Console.ReadLine());

    return opcao;
}


CriarMatriz(matriz1, inicio, final);
ImprimirMatriz(matriz1, "Matriz 1");
Console.WriteLine();

CriarMatriz(matriz2, inicio, final);
ImprimirMatriz(matriz2, "Matriz 2");
Console.WriteLine();

int opcao = EscolherOperacao();
switch (opcao)
{
    case 1:
        SomarMatriz(matriz1, matriz2);
        break;

    case 2:
        SubtrairMatriz(matriz1, matriz2);
        break;

    case 3:
        MultiplicarMatriz(matriz1, matriz2);
        break;

    case 4:
        DividirMatriz(matriz1, matriz2);
        break;
    default:
        Console.WriteLine("Erro");
        break;
}
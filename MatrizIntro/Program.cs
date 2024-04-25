int qtdLinhas = 0, qtdColunas = 0, operacao = 0, inicio = 0, final = 0, aleatorio;

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

void EscolherOperacao(int opcao)
{
    Console.Write("Digite: 1 - Adicao | 2 - Subtracao | 3 - Multiplicacao | 4 - Divisao: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            for (int linha = 0; linha < qtdLinhas; linha++)
            {
                for (int coluna = 0; coluna < qtdColunas; coluna++)
                {
                    matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
                }
            }
            ImprimirMatriz(matriz3, "Resultado soma");
            break;
        case 2:
            for (int linha = 0; linha < qtdLinhas; linha++)
            {
                for (int coluna = 0; coluna < qtdColunas; coluna++)
                {
                    matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
                }
            }
            ImprimirMatriz(matriz3, "Resultado subtracao");
            break;
        case 3:
            for (int linha = 0; linha < qtdLinhas; linha++)
            {
                for (int coluna = 0; coluna < qtdColunas; coluna++)
                {
                    matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
                }
            }
            ImprimirMatriz(matriz3, "Resultado multiplicacao");
            break;
        case 4:
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
            ImprimirMatriz(matriz3, "Resultado divisao");
            break;
        default:
            Console.WriteLine("Apenas um dos numeros sugeridos.");
            break;
    }
    operacao = opcao;
}

int SortearNumero(int i, int f)
{
    Console.Write("\nDigite a partir de qual número será gerado o aleatório: ");
    i = int.Parse(Console.ReadLine());
    Console.Write("Digite até qual número será gerado o aleatório: ");
    f = int.Parse(Console.ReadLine());
    inicio = i;
    final = f;
    return new Random().Next(inicio, final);
}

//Criacao da matriz 1
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz1[linha, coluna] = SortearNumero(inicio, final);
        break;
    }
}

ImprimirMatriz(matriz1, "Matriz 1");
Console.WriteLine();

//Criacao da matriz 2
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz2[linha, coluna] = SortearNumero(inicio, final);
    }
}

ImprimirMatriz(matriz2, "Matriz 2");
Console.WriteLine();
EscolherOperacao(operacao);
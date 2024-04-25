int qtdLinhas = 3, qtdColunas = 3;
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

//Criacao da matriz 1
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(0, 10);
    }
}

ImprimirMatriz(matriz1, "Matriz 1");
Console.WriteLine();

//Criacao da matriz 2
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz2[linha, coluna] = new Random().Next(1, 10);
    }
}

ImprimirMatriz(matriz2, "Matriz 2");
Console.WriteLine();

//Criacao da matriz 3 = matriz1 + matriz2
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
    }
}

//Impressao matriz 3 - soma
ImprimirMatriz(matriz3, "Resultado soma");

for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
    }
}

ImprimirMatriz(matriz3, "\nResultado subtração");

for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
    }
}

ImprimirMatriz(matriz3, "\nResultado multiplicação");

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

ImprimirMatriz(matriz3, "\nResultado divisão");
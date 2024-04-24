int qtdLinhas = 3, qtdColunas = 3;
double[,] matriz1 = new double[qtdLinhas, qtdColunas];
double[,] matriz2 = new double[qtdLinhas, qtdColunas];
double[,] matriz3 = new double[qtdLinhas, qtdColunas];

//Criacao da matriz 1
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(0, 100);
    }
}
//Impressao da matriz 1
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        Console.Write(matriz1[linha, coluna] + " ");
    }
}
Console.WriteLine();
//Criacao da matriz 2
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz2[linha, coluna] = new Random().Next(1, 10);
    }
}
//Impressao da matriz 2
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        Console.Write(matriz2[linha, coluna] + " ");
    }
}
//Criacao da matriz 3 = matriz1 + matriz2
Console.WriteLine();
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
    }
}

//Impressao matriz 3 - soma
Console.WriteLine();
Console.WriteLine("Resultado soma");
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }
}

for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
    }
}
Console.WriteLine();
Console.WriteLine("\nResultado subtração");
//Impressao matriz 3 - subtração
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }
}

for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
    }
}
Console.WriteLine();
Console.WriteLine("\nResultado multiplicação");
//Impressao matriz 3 - multiplicação
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }
}

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
Console.WriteLine();
Console.WriteLine("\nResultado divisão");
//Impressao matriz 3 - divisão
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }
}
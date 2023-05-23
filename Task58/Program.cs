// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




int[,] CreateMatrixFirst(int rows, int columns, int min, int max)
{
    int[,] matrixOne = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            matrixOne[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixOne;
}

void PrintMatrixFirst(int[,] matrixOne)
{
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            Console.Write($"{matrixOne[i, j],5} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateMatrixSecond(int rows, int columns, int min, int max)
{
    int[,] matrixTwo = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            matrixTwo[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrixTwo;
}

void PrintMatrixSecond(int[,] matrixTwo)
{
    for (int i = 0; i < matrixTwo.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            Console.Write($"{matrixTwo[i, j],5} ");
        }
        Console.WriteLine();
    }
}


void MultiplyMatrix(int[,] matrixFirst, int[,] martrixSecond, int[,] matrixResult)
{
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                sum += matrixFirst[i, k] * martrixSecond[k, j];
            }
            matrixResult[i, j] = sum;
        }
    }
}

void PrintMatrixResult(int[,] matrixResult)
{
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            Console.Write(matrixResult);
        }
        Console.WriteLine();
    }
}


int[,] matrixOne = CreateMatrixFirst(4, 3, -10, 10);
PrintMatrixFirst(matrixOne);
Console.WriteLine();
int[,] matrixTwo = CreateMatrixSecond(4, 3, -10, 10);
PrintMatrixSecond(matrixTwo);
Console.WriteLine();
MultiplyMatrix(CreateMatrixFirst, CreateMatrixSecond, PrintMatrixResult);
PrintMatrixResult(MultiplyMatrix);
Console.WriteLine($"Произведение двух матриц равно ");

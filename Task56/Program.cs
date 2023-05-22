// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// НЕ ПОЛУЧИЛАСЬ ЗАДАЧА



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine();
    }
}


int SumString(int[,] matrix)
{
    int sum = matrix[i, 0];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    return sum;
}



int MinString(int[,] matrix)
{
    int count = 1;
    int minSum = SumString(matrix, 0);
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minSum > SumString(matrix, i))
            {
                minSum = SumString(matrix, i);
                count = i + 1;
            }
        }
    }
    Console.WriteLine($"{count} строка");
}


int[,] matrix = CreateMatrixRndInt(4, 3, -10, 10);
PrintMatrix(matrix);
Console.WriteLine();
SumString(matrix);
Console.WriteLine();
MinString(matrix);

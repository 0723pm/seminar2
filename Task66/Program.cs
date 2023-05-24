// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите первое целое положительное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int numberN = Convert.ToInt32(Console.ReadLine());

SumMN(numberM, numberN);

void SumMN (int numM, int numN)
{
    Console.Write(SumOfNumbers(numM - 1, numN));
}

int SumOfNumbers(int numM, int numN)
{
    int result = numM;
    if (numM == numN)
        return 0;
    else
    {
        numM++;
        result = numM + SumOfNumbers(numM, numN);
        return result;
    }
}
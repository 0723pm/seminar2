// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое положительное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int numberN = Convert.ToInt32(Console.ReadLine());

int sumOfNumbers = SumOfNumbers(numberM - 1, numberN);
Console.WriteLine(sumOfNumbers);

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
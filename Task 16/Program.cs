﻿// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
bool result = IsSquare(numberA, numberB);
Console.WriteLine(result ? "Да" : "Нет");

bool IsSquare(int numA, int numB)
{
    return (numA == numB * numB) || (numB == numA * numA);
}
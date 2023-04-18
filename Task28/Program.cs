// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int multipleNumbers = MultipleNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {multipleNumbers}");

int MultipleNumbers(int num)
{
    int multiple = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            multiple *= i; // sum = sum + i;
        }
    }
    return multiple;
}

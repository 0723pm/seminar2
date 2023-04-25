// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int Start(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] NewArray(int length)
{
    int[] arr = new int [length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Start($"Введите {i + 1}-й элемент: ");
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {arr[i]}");
    }
}

int CountPositiveNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    if (arr[i] > 0)
    {
        count++;
    }
    return count;
}

int length = Start("Введите количество элементов: ");
int[] arr;
arr = NewArray(length);
PrintArray(arr);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNum(arr)}");
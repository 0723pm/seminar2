// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



Console.Write("Введите длину массива: ");
int arr = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[arr];

void CreateArray(int a)
{
    Random rnd = new Random();
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = rnd.NextDouble();
        Console.Write($"{ randomArray[i]:F2} ");
}

}

double DoubArr(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
            max = randomArray[i];
        if (min > randomArray[i])
            min = randomArray[i];
        i = i + 1;
    }
    return max - min;
}

CreateArray(arr);
Console.Write($"Разница между максимальным и минимальным элементом массива: { DoubArr(randomArray):F2}");
Console.WriteLine();
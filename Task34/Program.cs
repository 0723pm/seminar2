// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Запишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2




Console.WriteLine("Введите длину массива");
int lenghtArray = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[lenghtArray];

void CreateArrayRndInt(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,999);
    }
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
       Console.Write(arr[i]+ " "); 
    }
    
}

CreateArrayRndInt(arr);
Console.Write("[");
PrintArray(arr);
Console.Write("]");
Console.WriteLine();
int count = 0;
for (int i = 0; i < arr.Length; i++)
if (arr[i] % 2 == 0)
count++;
Console.WriteLine($"В массиве {count} четных чисел");

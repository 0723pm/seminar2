// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
// 16, 4 -> кратно

int Remainder(int num, int num2)
{
int rem = num % num2;
return rem;
}


Console.WriteLine("введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второ число");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);
if (remainder == 0)
Console.WriteLine("первое число кратно второму");
else
Console.WriteLine($" числа не кратны, остаток {remainder} ");
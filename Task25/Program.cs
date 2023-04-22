// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число: ");
int DigitA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int PowerB = Convert.ToInt32(Console.ReadLine());

int Power(int digitBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= digitBase;
    }
    return power;
}

bool ValidExponent(int exponent)
{
    if (exponent < 0)

    {
        System.Console.Write("Показатель не должен быть меньше 0");
        return false;
    }
    return true;
}

int digitBase = DigitA;
int exponent = PowerB;
if (ValidExponent(exponent))
{
    System.Console.WriteLine($"Число {digitBase} в степени {exponent} равно {Power(digitBase, exponent)}");
}
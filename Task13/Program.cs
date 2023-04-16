// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int DigitNumber = Convert.ToInt32(Console.ReadLine());
string DigitNumberText = Convert.ToString(DigitNumber);
if (DigitNumberText.Length > 2){
  Console.WriteLine("Третья цифра -> " + DigitNumberText[2]);
}
else {
  Console.WriteLine("-> Третьей цифры нет");
}
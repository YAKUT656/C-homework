//  Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.

Console.Clear();

Console.Write("Введите число 1: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number2 * number2 == number)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
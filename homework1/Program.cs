// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите число 1: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number>number2)
{
    Console.WriteLine($"{number}");
}
else
{
    Console.WriteLine($"{number2}");
}
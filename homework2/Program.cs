// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите число 1: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine()!);

int max=number;

if (number2 > number)
    max = number2;
if (number3 > max)
    max = number3;
    Console.WriteLine($"{max}");
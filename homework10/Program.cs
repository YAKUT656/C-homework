// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Введите трехзначное число : ");
int number = int.Parse(Console.ReadLine()!);
int number2 = number/10;
int number3 = number2 % 10;
Console.Write(number3);

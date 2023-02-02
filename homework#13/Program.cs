//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трех значное число");
int number = int.Parse(Console.ReadLine()!);

while (number>999)
{
    number = number / 10;
}
int result = number % 10;

if (number<99)
{
    Console.WriteLine($"Третьего числа нет"!);
}
else
{
    Console.WriteLine($"{result}"!);
}
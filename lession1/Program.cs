// Напишите программу 
// 

Console.Clear();

Console.Write("Введите число 1: ");
int number = int.Parse(Console.ReadLine()!);
double number2 = int.Parse(Console.ReadLine()!);


int sqr = number * number;
double sqr2 = Math.Pow(number, 2);

Console.WriteLine($"квадрат {number} равен {sqr}");
Console.WriteLine($"квадрат {number} равен {sqr2}");
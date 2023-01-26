

Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine()!);
int k = -number;
while (k <= number)
{
    Console.Write($"{k} ");
        k++;
}



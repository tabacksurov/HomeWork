// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите последовательно три числа мы определим какое самое большое.");
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int C = Convert.ToInt32(Console.ReadLine()!);
int MAX = A;
if (B > MAX) MAX = B;
if (C > MAX) MAX = C;
{
    Console.WriteLine("Мы определили самое большое число которое Вы ввели это " + MAX);
}

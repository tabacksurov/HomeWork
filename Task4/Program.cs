// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите последовательно три числа мы определим какое самое большое.");
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int C = Convert.ToInt32(Console.ReadLine()!);
int max = A;
if (B > max) max = B;
if (C > max) max = C;
    Console.WriteLine("Мы определили самое большое число которое Вы ввели это " + max);


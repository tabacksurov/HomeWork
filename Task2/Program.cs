/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.WriteLine("Введите два числа мы угадаем какое из ни больше");
Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine()!);
if (A >= B) 
{
    Console.WriteLine("Первое число "+ A + " больше чем второе число " + B);
}
else 
{
    Console.WriteLine("Второе число " + B + " больше чем первое число " + A);
}
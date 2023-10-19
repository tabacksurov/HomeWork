// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите трехзачное число!");
int num = Convert.ToInt32(Console.ReadLine()!);
if (num < 100 || num > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число!"); 
    return;
}
Console.WriteLine("Вторая цифра введенного числа " + num / 10 % 10);

/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка) */

Console.WriteLine("Введите число я угодаю четное оно или нет");
int number = Convert.ToInt32(Console.ReadLine())!;
Console.Write("Ваше число " + number + "");
if (number % 2 == 0)
{
    Console.Write(" четное");
} 
else
{
    Console.Write(" нечетное");
}


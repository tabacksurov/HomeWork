﻿/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка) */

Console.WriteLine("Введите число я угодаю четное оно или нет");
int number = Convert.ToInt32(Console.ReadLine())!;
if (number % 2 == 0)
{
    Console.WriteLine("Ваше число " + number + " четное");
} 
else
{
    Console.WriteLine("Ваше число " + number + " нечетное");
}


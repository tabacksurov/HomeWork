﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Введите произвольное число мы определим все четные числа от одного до числа которе Вы ввели");
int N = Convert.ToInt32(Console.ReadLine()!);
for(int i=1;i<=N;i++)
{
if (i % 2 == 0)
System.Console.Write(i + " ,");
}
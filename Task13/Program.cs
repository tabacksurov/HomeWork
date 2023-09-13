// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine()!);
string text = Convert.ToString(num);
if (text.Length <3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine("третья цифра введенного числа " + num + " = " + text[2]);
}

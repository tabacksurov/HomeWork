// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число!");
int num = int.Parse(Console.ReadLine()!);
int len = Length(num);

int Length(int num)
{
int index = 0;
while (num > 0)
{
num /= 10;
index++;
}
return index;
}

int SumChiselNomera()
{
    int podshet = 0;
    for (int i = 1; i <= len; i++)
    {
        podshet+=num%10;
        num/=10;
    }
    return podshet;
}

Console.Write($"Сумма цифр в числе {num} равно: {SumChiselNomera()}");
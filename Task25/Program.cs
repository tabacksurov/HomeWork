// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число A!");
int A = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число B!");
int B = int.Parse(Console.ReadLine()!);
double GetMultyplication()
{
    int i = 1;
    int multyplication = 1;
    while (i <= B)
    {
        // sum = sum + i;
        multyplication*=A;
        i++;
    }
    return multyplication;
}
System.Console.WriteLine($"Число {A} в степени {B} = {GetMultyplication()}");
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Введите количество элеметнов массива!");
int N =int.Parse(Console.ReadLine()!);
int[] array = new int[N];
void FillArray(int[] array)
{
    int index = 0;
    while (index < N)
    {
        Console.WriteLine($"Введите {index} элемент массива");
        array[index]=int.Parse(Console.ReadLine());
        index++;
    }
}
void PrintArray(int[] arr)
{
   int i = 0;
    while (i<N)
    {
        Console.Write($"{arr[i]}\t");
        i++;
    }
}


FillArray(array);
System.Console.WriteLine("");
PrintArray(array);

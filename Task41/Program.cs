// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите количество элеметнов массива M!");
int M =int.Parse(Console.ReadLine()!);
int[] array = new int[M];
void FillArray(int[] array)
{
    int index = 0;
    while (index < M)
    {
        Console.WriteLine($"Введите {index} элемент массива");
        array[index]=int.Parse(Console.ReadLine());
        index++;      
    }
}
void PrintArray(int[] arr)
{
   int i = 0;
   int s=0;    
    while (i<M)
    {
        Console.Write($"{arr[i]}\t"); 
        if(arr[i]>0)
        {
            s=s+1;
        }
        i++;        
    }
    System.Console.WriteLine($"Число символов массиве больше 0 = {s}");
}


Console.WriteLine("");
FillArray(array);
Console.WriteLine("");
PrintArray(array);

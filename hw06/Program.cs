//                                  Задача 41:    (Семинар 6)
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here:");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();   
}

int PlusNumbers(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) count++;

    return count; 
      
}

int MinusNumbers(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0) count++;

    return count; 
      
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);
ShowArray(array);
Console.WriteLine("Чисел больше ноля : " + PlusNumbers(array)); 
Console.WriteLine("Чисел меньше ноля : " + MinusNumbers(array)); 
*/





//                                  Задача 43:  
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Input meaning b1: ");
int b1 = Convert.ToInt32.(Console.ReadLine());
Console.Write("Input meaning k1: ");
int k1 = Convert.ToInt32.(Console.ReadLine());
Console.Write("Input meaning b2: ");
int b2 = Convert.ToInt32.(Console.ReadLine());
Console.Write("Input meaning k2: ");
int k2 = Convert.ToInt32.(Console.ReadLine());
//                             Задача 19  ??????

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 10000 || num > 100000)
   Console.Write("Вы ввели неверное число. Уточните условие");

int num1 = num / 10;
int Num1 = num % 10;

int num2 = num1 / 10;
int Num2 = num1 % 10;

int num3 = num2 / 10;
int Num3 = num2 % 10;

int num4 = num3 / 10;
int Num4 = num3 % 10;

int num5 = num4 / 10;
int Num5 = num4 % 10;

if (Num1 == Num5 && Num2 == Num4)
    Console.Write("Палиндром");
else
    Console.Write("Не палиндром");  



//                             Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


/*
void Qube(int x)
{
    int current = 1;
    while(current <= x)
    {
        int qube = current * current * current;
        Console.Write(qube + " ");
        current++;
    }
}
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Qube(n);
*/



//                           Задача 27: 
// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


/*                               Через метод
int FindSumNumbers(int num)
{
    if( num < 10) return num;
    int current = num % 10;
    int sum = num / 10;
    return current + FindSumNumbers(sum);
}

Console.Write("Input number: ");
int Sum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindSumNumbers(Sum));
*/

/*                             Второе решение
Console.Write("Input number: ");
int Sum = Convert.ToInt32(Console.ReadLine());

int a = 0;
while(Sum > 0)
    {
        a = a + Sum % 10;
        Sum = Sum / 10;
    }
Console.WriteLine(a);
*/






//                             Задача 29: 
//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);  
        return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();   
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
*/

//                                 Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*
int[] RandomThreeDigitsNumber(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);  
        return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();   
}

int Sum(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;

    return count;    
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = 100;
int maxValue = 1000;
int[] array = RandomThreeDigitsNumber(size, minValue, maxValue);
ShowArray(array);

Console.Write(Sum(array));
*/




//                              Задача 36: 
//Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);  
        return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();   
}

int FindSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(i % 2 != 0) sum += array[i];

    return sum;    
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.Write(FindSum(array));
*/


//                                 Задача 38:   ?????
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
/*
double[] CreateRandomArray(double size, double minValue, double maxValue)
{
    double[] newArray = new double[size];

    for(double i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);  
        return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();   
}



Console.Write("Input size of array: ");
double size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
double min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
double max = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.Write(MaxNumber(array));
*/


/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int MaxNumber(int[] array)
{
    int maxNum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum) maxNum = array[i];
    }
    return maxNum;
}

int MinNumber(int[] array)
{
    int minNum = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNum) minNum = array[i];
    }
    return minNum;
}


Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

int Difference = MaxNumber(array) - MinNumber(array);
Console.WriteLine($"минимальное число " + MinNumber(array));
Console.WriteLine($"максимальное число " + MaxNumber(array));
Console.WriteLine($"разница между числами " + Difference);
*/
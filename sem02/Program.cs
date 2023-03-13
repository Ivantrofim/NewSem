//                  ЗАДАЧИ НА МЕМИНАРЕ 3 - 4 - 5

//Координаты X / Y 


/*
void ShowArea(int quart)
{
    if(quart >= 1 && quart <= 4)
    {
        if(quart == 1) Console.WriteLine("In this quart x > 0 and y > 0");
        if(quart == 2) Console.WriteLine("In this quart x < 0 and y > 0");
        if(quart == 3) Console.WriteLine("In this quart x < 0 and y < 0");
        if(quart == 4) Console.WriteLine("In this quart x > 0 and y < 0");
    }
    else
        Console.WriteLine("This number is uncorrect");
}

Console.Write("Input quart: ");
int numQuart = Convert.ToInt32(Console.ReadLine());

ShowArea(numQuart);
*/


// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.



/*
Console.Write("Input x number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y number: ");
int y = Convert.ToInt32(Console.ReadLine());

void NumArea()
{
    if (x > 0 && y > 0) Console.WriteLine("1st quart");
    if (x < 0 && y > 0) Console.WriteLine("2nd quart");
    if (x < 0 && y < 0) Console.WriteLine("3rd quart");
    if (x > 0 && y < 0) Console.WriteLine("4th quart");
}
NumArea();
*/

//               Другое решение

/*
int Quart(int x, int y)
{
    int result = -1;
    if (x > 0 && y > 0) result = 1;
    if (x < 0 && y > 0) result = 2;
    if (x < 0 && y < 0) result = 3;
    if (x > 0 && y < 0) result = 4;
    return result;
}

Console.Write("Input x number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y number: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Quart(x, y));
*/


// Напишите программу, которая принимает на вход число (N)  
// и выдаёт квадраты чисел от 1 до N.


/*
void Quart(int x)
{
    int current = 1;
    while(current <= x)
    {
        int quart = current * current;
        Console.Write(quart + " ");
        current++;
    }
}
Console.Write("Inpet number: ");
int n = Convert.ToInt32(Console.ReadLine());
Quart(n);
*/

// Напишите программу, которая принимает на вход число (А)  
// и выдаёт сумму чисел от 1 до А.


/*
int FindSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++)
        sum += current; // сокращение от  sum = sum + current 

        return sum;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers from 1 to {num} is {FindSum(num)}");
*/


//  ЗАДАЧА 1      Напишите программу, которая принимает на вход число 
//   и выдаёт количество цифр в числе.

/*
int Quantity (int A)
{
    int result = 1;
    int i = 1;
    while(A / i > 10)
    {
        i = i *10;
        result++;
    }
    return result;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Quantity(num));
*/



// ЗАДАЧА 2      Напишите программу, которая принимает на вход число N 
//   и выдаёт произведение чисел от 1 до N.

/*
int FindMult(int a)
{
    int sum = 1;

    for(int current = 1; current <= a; current++)
        sum *= current; // сокращение от  sum = sum * current 

        return sum;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Multiplication of numbers from 1 to {num} is {FindMult(num)}");
*/



//  ЗАДАЧА 3      Напишите программу, которая принимает на вход два числа (A и B) 
//   и возводит число A в натуральную степень B.


/*
int Rate(int A, int B)
{
    int result = 1; 
    for(int C = 0; C < B; C++)
    {
        result = result * A;
    }
    return result;
    
}

Console.Write("Input 1st positive integer number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2nd positive integer number: ");
int B = Convert.ToInt32(Console.ReadLine());

int Res = Rate(A, B);

Console.WriteLine($"{A} в степени {B} = {Res}");
*/


// Создание массива 
//Ваиант 1 РАНДОМНЫЙ 
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);  
        return newArray;
}


//ВАРИАНТ 2 ВВОД ПОЛЬЗОВАТЕЛЕМ

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


//      ВАРИАНТ 3 


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

int[] array1 = CreateRandomArray(size, min, max);
int[] array2 = CreateArray(size);

ShowArray(array1);
ShowArray(array2);

int FindPossitiveSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum += array[i];

    return sum;    
}
*/



//                    ЗАДАЧА 1 

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму положительных элементов массива.

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

int FindPositiveSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > 0) sum += array[i];

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

int SumOfPositive = FindPositiveSum(array);
Console.Write("Сумма положительных элементов массива " + SumOfPositive);
*/

//                       ЗАДАЧА 2
// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.  
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);  
        return array;
}

int[] ChangePlusToMinus(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * -1;

    return array;    
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
int[] change = ChangePlusToMinus(array);
ShowArray(change);
*/





//                    ЗАДАЧА 2 
// Задайте одномерный массив из 20 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);  
        return newArray;
}

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

int FindTwoDigits(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] >= 10 && array[i] <= 99) count++;

    return count;    
}

int size = 20;
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.Write("Count of two-digit elements is" + FindTwoDigits(array));
*/
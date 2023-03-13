//ЗАДАЧИ 2,4,6,8,10,13,15

// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 > num1)
    Console.WriteLine("Второе число больше первого");
else
    Console.WriteLine("Первое число больше второго");
*/





// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine("Max number is " + max);
*/



// Задача 6: Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Чётное число");
}
if (num % 2 != 0)
{
    Console.Write("Нечётное число");
}
*/





// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
int num, index;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());
index = 2;

while(index <= num)
{
    Console.Write(index + " ");
    index = index + 2; 
}
*/







// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// И на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
void Number()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Cлучайное число " + num);

    int num1 = num / 10;
    int num2 = num1 / 10;
    int result = num1 % 10;

    Console.WriteLine("Вторая цифра " + result);
}
Number();
*/





// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// Или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
void RandNum()
{
    int result = 0;
    int num = new Random().Next(10, 1000000);
    Console.WriteLine("Cлучайное число " + num);

    while (num > 999)
    {
      num = num / 10;
    }
    result = num % 10;
    Console.WriteLine("Третья цифра " + result);

    if (num <= 99)
       Console.WriteLine("Третьей цифры нет");
}
RandNum();
*/






// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
/*
void WeekDay()
{
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 5 && num < 8)
  Console.WriteLine("Это выходной день");
else
   if(num > 0 && num < 6)
     Console.WriteLine("Это будний день");
    else
     Console.WriteLine("Такого дня нет");   
}
WeekDay();
*/

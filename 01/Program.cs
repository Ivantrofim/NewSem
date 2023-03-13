// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

int CutNumber()
{

  int num = new Random().Next(100, 1000);
  Console.WriteLine("current" + num);

  int sotni = num / 10;
  int ed = num % 10;

   int result = sotni * 10 + ed;
   return result;

}

int result = CutNumber();
Console.WriteLine("max number is " + result);


//ЗАДАЧИ НА СЕМЕНАРЕ


//   01 Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  показывает наибольшую цифру числа.


/*
int Number()
{

  int num = new Random().Next(10, 100);
  Console.WriteLine("current" + num);

  int thirstNum = num / 10;
  int secondNum = num % 10;

  if (thirstNum > secondNum) 
       return thirstNum;
       else
       return secondNum;

}

int result = Number();
Console.WriteLine("max number is " + result);
*/


// 02   Напишите программу, которая принимает на вход число и
// проверяет, кратно ли оно одновременно 7 и 23.


/*
void Number()
{
    Console.WriteLine("Input number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if(num % 7 == 0 && num % 23 == 0)
    Console.WriteLine("Число является кратным 7 и 23");
    else
    Console.WriteLine("Число не является кратным 7 и 23");
}
Number();
*/


// 03    Напишите программу, которая принимает на вход два числа и
// проверяет, является ли одно число квадратом другого.

/*
void squad()
{
    Console.Write("Input thirst number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if(num1 * num1 == num2)
    Console.WriteLine("num1 является квадратом num2");
    else
    Console.WriteLine("num1 не является квадратом num2");

    if(num2 * num2 == num1)
    Console.WriteLine("num2 является квадратом num1");
    else
    Console.WriteLine("num2 не является квадратом num1");

}
squad();
*/


//Другое решение
/*
void squad()
{
    Console.Write("Input thirst number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    if(num1 * num1 == num2)
    Console.WriteLine("num1 является квадратом num2");
    else
        if(num2 * num2 == num1)
    Console.WriteLine("num2 является квадратом num1");
    else 
        Console.WriteLine("N0");
}
squad();
*/

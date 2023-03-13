//                Семинар 6

// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*
int[] ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}

/*                                Второй способ написания 
int[] ReverseArray(int[] array)
{
    int i = 0, j = array.Length - 1;

    while(i < j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;
    }
    return array;
}
*/
/*
int[] myArray = {3, 5, 1, 8, 2, 9, 4, 6, 9};
myArray = ReverseArray(myArray);

for(int i = 0; i < myArray.Length; i++)
    Console.Write(myArray[i] + " ");
*/

//
//
//
//              Напишите программу, которая будет преобразовывать десятичное число в двоичное.    

/*
string ChangeDigitNumber(int num)
{
    string resultNumber = string.Empty;

    while(num > 0)
    {
        resultNumber = num % 2 + resultNumber;
        num /= 2;   //  num = num / 2;
    }
    return resultNumber;
}
Console.WriteLine(ChangeDigitNumber(202));  // Число поставляем любое 
*/


//              По формуле  a < b + c
// Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.


//                         Решение через bool

/*
bool Triangle(int a,int b,int c)
{
    return(a < b + c && b < a + c && c < a + b);
}

bool isTriangle = false;
isTriangle = Triangle(1, 2, 2);

Console.WriteLine(isTriangle);
*/


/*
void Triangle(int a,int b,int c)
{
    if(a < b + c && b < a + c && c < a + b)
       Console.Write("Positive");
    else
        Console.Write("Negative");  
}

Console.Write("Input first number : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number : ");
int c = Convert.ToInt32(Console.ReadLine());

Triangle(a, b, c);
*/  


// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();   
}

int[] Fibonacci(int n)
{
    int[] newArray = new int[n];
    Console.WriteLine("Creating new Fibonacci array here: ");
    newArray[0] = 0;
    newArray[1] = 1;

    for(int i = 2; i < n; i++)
    {
        newArray[i] = newArray[i -1] + newArray[i - 2];
    }
    return newArray;
}

Console.Write("Input array size: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowArray (Fibonacci(num));
*/
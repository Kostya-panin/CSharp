//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
/*
int max;
int min;
Console.WriteLine("Input first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    max = number1;
    min = number2;
}
else
{
    max = number2;
    min = number1;
}

Console.Write("maximum number:"+ max +" ");
Console.Write("minimum number:"+ min);
*/
//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
/*
Console.WriteLine("Input first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max=number1;
if (number1 == number2 & number2 == number3) Console.Write("numbers equal");
    else
        {
        if (number1 > max) max=number1;
        if (number2 > max) max=number2;
        if (number3 > max) max=number3;
        Console.Write("Maximum number: "+ max);
        }
  */      
//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
/*
Console.WriteLine("Input integer number:");
int number = Convert.ToDouble(Console.ReadLine());
int div = number % 2;
if (div==0) Console.WriteLine(number + "-"+"even number");
else
Console.WriteLine(number + "-"+"uneven number");
Console.WriteLine(number % 2);
*/
//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
/*
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 0;
while (current<=number)
{
    current=current + 2;
 Console.Write((current) +" ");
}
*/


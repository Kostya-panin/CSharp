//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//Решение1
/*
Console.WriteLine("input number1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number2");
int number2 = Convert.ToInt32(Console.ReadLine());
double number3 = Math.Pow(number1, number2);
Console.WriteLine(number3);
*/
//Решение2
/*
int exponentiation(int number, int exponent)
{
    int count = exponent;
    int result = 1;
    for (int i = 1; i <= count; i++)
    {
        result = result * number;
    }
    return result;
}
Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input exponent");
int exponent = Convert.ToInt32(Console.ReadLine());
Console.Write(exponentiation(number,exponent));
*/
//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
int sumdigit(int number)
{
    int number1 = number;
    int sumdigit = 0;
    while (number1 > 0)
    {
        int digitN = number1 % 10;
        number1 = number1 / 10;
        sumdigit = sumdigit + digitN;
    }
    return sumdigit;
}
Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number + "->" + sumdigit(number));
*/
//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*
void showarray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 9);
        Console.Write(array[i] + " ");
    }
}
*/
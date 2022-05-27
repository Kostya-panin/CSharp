//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
//int i = 0;
/*
int sum = 0;
int summa(int m, int n)
{
    if (m <= n)
    {
        //Console.WriteLine(m);
        sum = sum + m;
        summa(m+1,n);
    }
    return sum;
}
int sum1 = summa(1,9);
Console.WriteLine(sum1);
*/
//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9
/*
int sumdigit1 = 0;
int sumdigit(int number)
{
    int number1 = number;
    if (number1 > 0)
    {
        int digitN = number1 % 10;
        //number1 = number1 / 10;
        sumdigit1 = sumdigit1 + digitN;
        sumdigit(number / 10);
    }
    return sumdigit1;
}
Console.WriteLine("input num");
int num = Convert.ToInt32(Console.ReadLine());
int sum = sumdigit(num);
Console.WriteLine(num + " -> " + sum);
*/
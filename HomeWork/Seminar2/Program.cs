/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
//Решение
int showseconddigit(int number)
{
int seconddigit=(number / 10)%10;
return seconddigit;
}
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int seconddigit = showseconddigit(number);
Console.WriteLine("Second digit of the number "+ number + " = " + seconddigit);
*/
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
//Решение
/*
//Способ1
int number = 5997;
int thirddigit = (number % 1000) % 100;
Console.Write("third digit of the number "+ number +" = "+ thirddigit);
*/
//Способ2
/*
string showthirddigit(string number)
{
    if (number.Length < 3)
    {
    string thirddigit = "missing third digit";
    return ("missing third digit");
    }
    else
    {
    string thirddigit = Convert.ToString(number[2]);
    return thirddigit;
    }
}
Console.WriteLine("input number");
string number = Console.ReadLine();
string thirddigit = showthirddigit(number);
Console.Write(number +" => "+ thirddigit);


//Способ3
/*
int number = 537;
int a= number % 100;
Console.WriteLine(a);
int b = a/10;
Console.WriteLine(b);
Console.Write("third digit of the number "+ number +" = "+ b);
*/
/*
/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
//Решение:
string freeday()
{
Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 0)&(number < 6))
{
    string freeday = "No";
    return freeday;
}
else
{
    if ((number >5)&(number<8))
    {
       string freeday = "yes";
    return freeday;
    }
}
return "not dayweek";
}
string a=freeday();
Console.WriteLine(a);
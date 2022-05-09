//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
//Решение
/*
int[] createarray()
{
    Console.WriteLine("Введите количество чисел");
    int kol = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[kol];
    for (int i = 0; i < kol; i++)
    {
        Console.WriteLine("Введите число" + " " + i);
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void showarray (int [] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}
Console.WriteLine();
}
void skollkochiselbolshe0(int [] array)
{
    int result =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)result=result+1;
    }
    Console.WriteLine("Чисел больше 0"+"->"+ result);
}
skollkochiselbolshe0(createarray());
*/
//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
/*
Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());
int numberforoutput=number;
string number1 = string.Empty;
while (number > 0)
{
    int digit = number % 2;
    number = number / 2;
    number1 = number1 + digit;
}
string newnumber = string.Empty;
int i = 0;
int j = number1.Length - 1;
while (i < number1.Length)
{
    newnumber = newnumber + number1[j];
    j--;
    i++;
}
Console.WriteLine(numberforoutput+"->"+newnumber);
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
/*
Console.WriteLine("input b1");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k1");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input b2");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k2");
double k2=Convert.ToDouble(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
double y = (b2*k1-b1*k2)/(k1-k2);
Console.WriteLine(x);
Console.WriteLine(y);
*/
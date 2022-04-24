//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
//Решение
//Способ через строку(массив)
/*
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int i = 0;
int j = (number.Length)-1;
int length = number.Length;
string result =string.Empty;
while (i < length)
{
result = result + $"{number[j]}";
i=i+1;
j=j-1;
}
int number1 = Convert.ToInt32(number);
int result1 = Convert.ToInt32(result);
if (number1 == result1)
{
Console.WriteLine($"{"Число:"}{result}{" Является полиндромом"}");
}
else
Console.WriteLine($"{"Число:"}{result}{" Не является полиндромом"}");
*/
//Способ арифметический
/*
void palindromedDefinition(int number1)
{
    int number2 = number1;
    int invertedNumber = 0;
    while (number2 > 0)
    {
        invertedNumber = invertedNumber * 10 + (number2 % 10);
        number2 = number2 / 10;
    }
    if (invertedNumber == number1) Console.WriteLine(number1 + " =>yes");
    else
        Console.WriteLine(number1 + "=>no");
}
Console.WriteLine("input five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
palindromedDefinition(number);
*/
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//Формула AB=sqrt(pow(xb-xa))+(pow(yb-ya))+(pow(zb-za))
//Решение
/*
double distanceABMethod()
{
Console.WriteLine("input coordinate X dot А");
double xa= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input coordinate Y dot А");
double ya=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input coordinate Z dot А");
double za=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input coordinate X dot B");
double xb=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input coordinate Y dot B");
double yb=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input coordinate Z dot B");
double zb=Convert.ToInt32(Console.ReadLine());
double distanceAB=Math.Sqrt((Math.Pow(xb-xa,2))+(Math.Pow(yb-ya,2))+(Math.Pow(zb-za,2)));
return distanceAB;
}
double distanceAB = distanceABMethod();
Console.WriteLine(distanceAB);
*/
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
//Решение
/*
string listofcubesnumber(int n)
{
string listofcubes=string.Empty;
int i=1;
while (i <= n)
{
    double cube = Math.Pow(i,3);
    listofcubes = listofcubes + Convert.ToString(cube)+", ";
    i++;
}
return listofcubes;
}
Console.WriteLine("input number");
int n=Convert.ToInt32(Console.ReadLine());
string listofcubes=listofcubesnumber(n);
Console.Write(n+"->"+listofcubes);
*/
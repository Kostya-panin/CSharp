//Задача1 Ввести число и вывести его квадрат
//Вариант1
/* 
Console.Write("Type integer number ");
int squarenum;
int num = Convert.ToInt32(Console.ReadLine());
squarenum = num * num;
Console.WriteLine("Квадрат числа равен " + squarenum);
*/
//Задача1 Ввести число и вывести его квадрат 
//Вариант2
/*
Console.Write("Type integer number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(Math.Pow(num, 3));
*/


//Задача2 Программа принимает на вход 2 числа и проверяет являеться ли первое число квадратом воторого
/*
Console.WriteLine("Type number1");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type number2");
int number2=Convert.ToInt32(Console.ReadLine());
if (number2==(number1 * number1))
    Console.WriteLine("number1 is a square number2");
else
    Console.WriteLine("number 1 is a not square number2");
*/
//Задача3 Ввести номер дня недели а в ответ получить название дня недели
/*
Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day<1||day>7)
    Console.WriteLine("Че ты вводишь УРОД!!!");
if (day == 1)
    Console.WriteLine("Понедельник");
if (day == 2)
    Console.WriteLine("Вторник");
if (day == 3)
    Console.WriteLine("Среда");
if (day == 4)
    Console.WriteLine("Четверг");
if (day == 5)
    Console.WriteLine("Пятница");
if (day == 6)
    Console.WriteLine("Суббота");
if (day == 7)
    Console.WriteLine("Воскресенье");
    */
    //Задача 4 Прием на ввод одного числа N а вывод чисел в промежутке от -N до N
    Console.WriteLine("Ввведите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
int Current = -1*num;
while(Current <= num)
{
    Console.Write(Current +" ");
    Current++;
}
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
//Решение
/*
Console.WriteLine("input m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array=new double[m,n];
for (int rows = 0; rows < m; rows++)
{
    for (int columns = 0; columns < n; columns++)
    {
        array[rows,columns]=(Convert.ToDouble(new Random().Next(-10,10)))/2;
        Console.Write($" {array[rows,columns]}");
    }
    Console.WriteLine();
}
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
/*
int searchelement=0;
Console.WriteLine("input m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input position x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input position y");
int y = Convert.ToInt32(Console.ReadLine());
if (x >= m | y >= n)Console.Write("Этот элемент находиться за пределами маасива");
else{
int[,] array = new int[m, n];
for (int rows = 0; rows < m; rows++)
{
    for (int columns = 0; columns < n; columns++)
    {
        array[rows, columns] = new Random().Next(1, 10);
        Console.Write($" {array[rows,columns]}");
        if (rows == y && columns == x)
        {
          searchelement=array[rows,columns];
        }
    }
Console.WriteLine();
}
Console.Write(searchelement);
}
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
double divider = 0;
double sum = 0;
double average = 0;
Console.WriteLine("input m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int rows = 0; rows < m; rows++)
{
    for (int columns = 0; columns < n; columns++)
    {
        array[rows, columns] = new Random().Next(1, 10);
        Console.Write($" {array[rows, columns]}");
    }
    Console.WriteLine();
}
Console.Write("Среднее арифметическое каждого столбца: ");
for (int columns = 0; columns < n; columns++)
{
    for (int rows = 0; rows < m; rows++, divider++)
    {
        sum = sum + array[rows, columns];
    }
    average = sum / divider;
    Console.Write(average+"; ");
    sum = 0;
    divider = 0;
}
*/
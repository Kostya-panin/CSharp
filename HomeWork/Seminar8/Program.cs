//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8
/*
int[,] createArray(int height, int width)
{
    int[,] array = new int[height, width];
    for (int rows = 0; rows < height; rows++)
    {
        for (int columns = 0; columns < width; columns++)
        {
            array[rows, columns] = new Random().Next(1, 10);
        }
    }
    return array;
}
void printArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            Console.Write($" {array[rows, columns]}");
        }
        Console.WriteLine();
    }
}
int[,] sortElementsInRows(int[,] array)
{
    int temp;
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1) - 1; columns++)
        {
            for (int j = columns + 1; j < array.GetLength(1); j++)
            {
                if (array[rows, columns] > array[rows, j])
                {
                    temp = array[rows, columns];
                    array[rows, columns] = array[rows, j];
                    array[rows, j] = temp;
                }
            }
        }
    }
    return array;
}
int [,] array=createArray(9,8);
printArray(array);
Console.WriteLine();
printArray(sortElementsInRows(array));
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] createArray(int height, int width)
{
    int[,] array = new int[height, width];
    for (int rows = 0; rows < height; rows++)
    {
        for (int columns = 0; columns < width; columns++)
        {
            array[rows, columns] = new Random().Next(1, 10);
        }
    }
    return array;
}
void minSumElementInRow(int [,]array)
{
int numberRows=0;
int temp=0;
int sumInRows=0;
 for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            sumInRows=sumInRows+array[rows,columns];
        }
        if (sumInRows < temp)
        {
            numberRows = rows;
        }
        temp = sumInRows;
        sumInRows = 0;
    }
    Console.WriteLine(numberRows);
}
void printArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            Console.Write($" {array[rows, columns]}");
        }
        Console.WriteLine();
    }
}
int [,] array=createArray(3,3);
printArray(array);
Console.WriteLine();
minSumElementInRow(array);
*/
//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7
/*
int[,] createArray()
{
    int columns = 0;
    int rows = 0;
    int number = 1;
    int[,] array = new int[4, 4];
    for (;columns < 4;columns++)
    {
        array[rows, columns] = number;
        number++;
    }
    for (rows = 1; rows < 4; rows++)
    {
        array[rows, columns - 1] = number;
        number++;
    }
    for (columns = 2; columns >= 0; columns--)
    {
        array[rows - 1, columns] = number;
        number++;
    }
    for (rows = 2; rows >= 1; rows--)
    {
        array[rows, columns + 1] = number;
        number++;
    }
    for (;columns < 2;columns++)
    {
        array[rows + 1, columns + 1] = number;
        number++;  
    }
    array[2, 2] = 16;
    array[2, 1] = 17;
    return array;
}
void printArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int columns = 0; columns < array.GetLength(1); columns++)
        {
            Console.Write($" {array[rows, columns]}");
        }
        Console.WriteLine();
    }
}
int[,] array = createArray();
printArray(array);
*/


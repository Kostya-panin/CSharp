//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//Решение
/*
void numberevennum(int[] massiv)
{
int evennumber = 0;
for (int i=0;i < massiv.Length;i++)
{
    massiv[i] = new Random().Next(100, 999);
    if ((massiv[i] % 2) == 0)
    {
        evennumber += 1;
    }
    Console.Write(massiv[i] + " ");
}
Console.Write("->" + evennumber);
}
int[] massiv = { 0, 0, 0, 0, 0, 0 };
numberevennum(massiv);
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
int[] array = new int[10];
int sum=0;
for (int i = 0; i < array.Length; i++)
{
    array[i]=new Random().Next(0,50);
    if (!(array[i] % 2 ==0))
    {
        sum+=array[i];
    }
    Console.Write(array[i]+" ");
}
Console.Write("->"+sum);
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
void difMaxMinNumber()
{
    double[] array = { 4, -2, 3, 8, -2, 3, 20, -5.1 };
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] > max) max = array[i];
        else
        {
            if (array[i] < min) min = array[i];
        }
    }
    double dif = max - min;
    Console.Write("->" + dif);
}
difMaxMinNumber();
*/
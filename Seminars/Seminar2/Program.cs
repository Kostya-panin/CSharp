//int a;
//a = new Random().Next(5,9);

//Console.Write(a);

//Задача1
//написать программу которая выводит случайное трехзначное число а потом удаляет вторую цифу этого числа
//456->46
int ShowNumber()
{
int number = new Random().Next(100,998);
Console.Write(number+"-> ");
int newnumber1 = (number / 100)*10;
int newnumber2 = number % 10;
int finalnumber = newnumber1+newnumber2;
return finalnumber;
}
int a=ShowNumber();
Console.Write(a);
//Console.Write(456%10);
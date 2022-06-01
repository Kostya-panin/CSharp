//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
//Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
/*
string[] array = { "owe", "ure", "iwr", "drt" };
void wordCount(string[]array)
{
char[] vowelsAlphabet = { 'a', 'e', 'i', 'o', 'u' };
int i = 0;
int j = 0;
int numberWord = 0;
while (i < array.Length)
{
    while (j < vowelsAlphabet.Length)
    {
        if (array[i][0].Equals(vowelsAlphabet[j]))
        {
            numberWord++;
        }
        j++;
    }
    j=0;
    i++;
}
Console.Write("numberWord=> "+numberWord);
}
wordCount(array);
*/
//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
//Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
/*
string [] array = {"qwe","rty","asd","fgh","zxc","vbn"};
string [] createArray(string [] array)
{
    int len =array.Length/2;
    string[] newArray = new string[len];
    int j =0;
for (int i = 0; i < len; i++,j=j+2)
{
    newArray[i]=array[j]+array[j+1];
}
    return newArray;
}
void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}
printArray(createArray(array));
*/
string[] array = { "rmvfk", "7", "gjnv", ":-)", "Wea", "rew" };
string[] arrayEdit(string[] array)
{
    string[] newArray = new string[array.Length];
    int i = 0;
    int j = 0;
    int maxLength = 3;
    while (i < array.Length)
    {
        if (array[i].Length <= maxLength)
        {
            newArray[j] = array[i];
            j++;
        }
        i++;
    }
    Array.Resize(ref newArray, j);
    return newArray;
}
void printArray(string [] array)
{
Console.Write("[");
for (int i = 0;i < array.Length;i++)
{
    Console.Write(array[i]);
    if (i<(array.Length-1))Console.Write(" ");
}
Console.Write("]");
}
string [] newarray=arrayEdit(array);
printArray(array);
Console.Write(" -> ");
printArray(newarray);
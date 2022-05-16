void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"'{array[i]}', ");
    }
    Console.WriteLine("'{0}']", array[array.Length - 1]);
}

string[] MakeNewArray(string[] arra, int num)
{
    int len = arra.Length;
    string[] resArra = new string[len];
    for (int i = 0; i < len; i++)
    {
        if (arra[i].Length <= num) resArra[i] = arra[i];
        else resArra[i] = string.Empty;
    }
    return resArra;
}

void PrintNewArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length - 1; i++)
    {
        if (newArray[i] != string.Empty) Console.Write("['{0}', ",newArray[i]  );
    }
    Console.WriteLine("'{0}']" , newArray[newArray.Length - 1]);
}

string[] initialArray = { "hello", "2", "world", ":-)" };
int symbol = 3;
PrintArray(initialArray);
Console.WriteLine();
Console.Write("Нажмите Enter, чтобы показать 2 элемента в новом массиве");
Console.ReadLine();
PrintNewArray(MakeNewArray(initialArray, symbol));
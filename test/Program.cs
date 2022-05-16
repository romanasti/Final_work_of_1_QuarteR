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
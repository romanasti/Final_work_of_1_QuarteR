void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"'{array[i]}', ");
    }
    Console.WriteLine("'{0}']", array[array.Length - 1]);
}
string[] array = new string[5] { "123ww", "56e7", "hele", "wo3333", "res333" };
string[] newarr = new string[array.Length];
void MetodArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarr[i] = array[i];
            Console.Write($"{newarr[i]}, ");
        }
    }
    System.Console.Write("]");
}

void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    System.Console.Write("]");
}
System.Console.WriteLine();
PrintArray(array);
System.Console.Write("->");
MetodArray(array);
System.Console.WriteLine();
System.Console.WriteLine();





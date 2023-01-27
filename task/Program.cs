void search(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {   
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void printArray (string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]}, ");
    }
    Console.WriteLine();
}

string[] array1 = new string [4] {"Hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];
search(array1,array2);
printArray(array2);
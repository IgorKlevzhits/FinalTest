string[] getNewArray(string[] arrayStrings)
{
    int lengthNewArray = 0;

    for (int i = 0; i < arrayStrings.Length; i++)
    {
        if (arrayStrings[i].Length <= 3) 
        {
            lengthNewArray++;
        }
    }

    string[] result = new string[lengthNewArray];
    int j = 0;

    for (int i = 0; i < arrayStrings.Length; i++)
    {
        if (arrayStrings[i].Length <= 3) 
        {
            result[j] = arrayStrings[i];
            j++;
        }
    }
    return result;
}

void showArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]} ]");
}

string[] arrayStrings = { "Hello", "Hi", "Tom", "Cool", "Bottom", "Key"};
string[] resultArray = getNewArray(arrayStrings);
showArray(arrayStrings);
Console.Write(" -> ");
showArray(resultArray);
Console.WriteLine();
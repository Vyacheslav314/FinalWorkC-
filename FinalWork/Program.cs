string[] firstArray = {"Hello", "2", "world", ":-)"};
int value = SecondArrayLength(firstArray);
string[] secondArray = CreatingSecondArray(firstArray, value);
PrintArray(firstArray);
PrintArray(secondArray);

string[] CreatingSecondArray(string[] array, int value)
{
    string[] newArray = new string[value];
    int startIndex = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[startIndex++] = array[i];
        }
    }
    return newArray;
}

int SecondArrayLength(string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count++;
    }
    return count;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

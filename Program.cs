string[] CreateRandomArray(int min=1, int max=10)
{
    int arraySize = new Random().Next(min,max);
    string[] randomArray = new string [arraySize];

    for(int i = 0; i < randomArray.Length; i++)
    {
        int stringRandomLength = new Random().Next(min,max);
        for(int j = 0; j < stringRandomLength; j++)
        {
            randomArray[i] = randomArray[i] + Convert.ToChar(new Random().Next(33, 126));
        }
    }

    return randomArray;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+"   ");
    }
    Console.WriteLine();
}
    
string[] LessThreeChar(string[] array)
{
    int size = 0;
    
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 3) size++;
    }

    string[] newArray = new string [size];
    
    for(int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length < 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}

string[] randomArray = CreateRandomArray();
PrintArray(randomArray);
Console.WriteLine();

string[] newArray = LessThreeChar(randomArray);
PrintArray(newArray);

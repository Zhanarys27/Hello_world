Console.Clear();

int Max(int[] array)
{
    int result = 0;
    for(int i=0; i < array.Length; i++)
    {
        if(result<=array[i])
        {
            result = array[i];
        }
        
    }
    return result;
}

int[] numbers = {11, 2, 3, 4, 5, 6, 7, 8, 9};

Console.WriteLine(Max(numbers));
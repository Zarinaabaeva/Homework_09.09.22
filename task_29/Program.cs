int[] GetArray()
{
    int[] numbers = new int[8];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-50, 50);
    }
    return numbers;  
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
PrintArray(GetArray());

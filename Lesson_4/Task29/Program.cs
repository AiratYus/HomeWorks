void FillArray(int[] array)
{
    var random = new Random();
    
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    
    Console.WriteLine(array[array.Length - 1]);
}

int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);

void FillArray(int[] array)
{
    var random = new Random();
    
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
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

Console.WriteLine("Введите количество элементов массива");
int length = int.Parse(Console.ReadLine());

int[] arr = new int[length];
FillArray(arr);
PrintArray(arr);

var count = 0;
for (var i = 0; i < length; i++)
{
    if (arr[i] % 2 == 0) count++;
}

Console.WriteLine(count);

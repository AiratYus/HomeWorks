void FillArray(int[] array)
{
    var random = new Random();
    
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 1000);
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

var sum = 0;
for (var i = 1; i < length; i += 2)
{
    sum += arr[i];
}

Console.WriteLine(sum);

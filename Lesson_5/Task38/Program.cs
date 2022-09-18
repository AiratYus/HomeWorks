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

Console.WriteLine("Введите количество элементов массива");
int length = int.Parse(Console.ReadLine());

int[] arr = new int[length];
FillArray(arr);
PrintArray(arr);

var max = arr[0];
var min = arr[0];
for (var i = 1; i < arr.Length; i++)
{
    if (max < arr[i]) max = arr[i];
    if (min > arr[i]) min = arr[i];
}

Console.WriteLine(max - min);

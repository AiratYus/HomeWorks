void FillMatrix(int[,] matrix, int m, int n)
{
    var random = new Random();
    
    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            matrix[x, y] = random.Next(0, 100);
        }
    }
}

void PrintMatrix(int[,] matrix, int m, int n)
{
    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            Console.Write(matrix[x, y] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());

var matrix = new int[m, n];

FillMatrix(matrix, m, n);
PrintMatrix(matrix, m, n);

Console.WriteLine("Введите позиции элемента двумерного массива через пробел");
var str = Console.ReadLine().Split(' ');
int a = int.Parse(str[0]);
int b = int.Parse(str[1]);

if (a > m || b > n)
{
    Console.WriteLine("Такого числа в массиве нет");
    return;
}

Console.WriteLine("Элемент в двумерном массиве: " + matrix[a, b]);

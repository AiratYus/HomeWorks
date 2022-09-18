void FillMatrix(double[,] matrix, int m, int n)
{
    var random = new Random();
    
    for (int x = 0; x < m; x++)
    {
        for (int y = 0; y < n; y++)
        {
            matrix[x, y] = random.Next(-10, 10);
        }
    }
}

void PrintMatrix(double[,] matrix, int m, int n)
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

var matrix = new double[m, n];

FillMatrix(matrix, m, n);
PrintMatrix(matrix, m, n);

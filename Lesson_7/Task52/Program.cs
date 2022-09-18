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

void PrintAverageInRow(int[,] matrix, int m, int n)
{
    for (int x = 0; x < m; x++)
    {
        int sum = 0;
        for (int y = 0; y < n; y++)
        {
            sum += matrix[x, y];
        }
        
        Console.Write(sum / n + " ");
    }
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());

var matrix = new int[m, n];

FillMatrix(matrix, m, n);
PrintMatrix(matrix, m, n);

PrintAverageInRow(matrix, m, n);

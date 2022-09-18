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

void PrintMinSumRow(int[,] matrix, int m, int n)
{
    var minRow = 0;
    var minSum = GetSumInRow(matrix, minRow, n);
    for (int x = 1; x < m; x++)
    {
        var sum = GetSumInRow(matrix, x, n);
        
        if (sum < minSum)
        {
            minRow = x;
            minSum = sum;
        }
    }

    Console.WriteLine(minRow + 1);
}

int GetSumInRow(int[,] matrix, int row, int rowSize)
{
    int sum = 0;
    for (int y = 0; y < rowSize; y++)
    {
        sum += matrix[row, y];
    }

    return sum;
}

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());

var matrix = new int[m, n];

FillMatrix(matrix, m, n);
PrintMatrix(matrix, m, n);
PrintMinSumRow(matrix, m, n);
